using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Clipy
{
    class DataProcess
    {
        public static string DataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Process.GetCurrentProcess().ProcessName);
        public static string DBPATH = Path.Combine(DataDirectory, "data.db");

        private string DataSource
        {
            get
            {
                if (!Directory.Exists(DataDirectory))
                {
                    Directory.CreateDirectory(DataDirectory);
                }
                return "Data Source=" + DBPATH;
            }
        }

        public DataProcess()
        {
            if (!File.Exists(DBPATH))
            {
                using (var conn = new SQLiteConnection(DataSource))
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        command.CommandText = "CREATE TABLE Groups(id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, name string UNIQUE NOT NULL)";
                        command.ExecuteNonQuery();
                        command.CommandText = "CREATE TABLE Histories(id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, name string, content text, obj data, group_id integer, created_at timestamp)";
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AddGroup(string name)
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "INSERT INTO Groups ('name') values (@name)";
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@name";
                    parameter.DbType = DbType.String;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = name;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteGroup(Group group)
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "DELETE FROM Groups WHERE id=@gid; DELETE FROM Histories WHERE group_id=@gid";
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@gid";
                    parameter.DbType = DbType.Int32;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = group.Id;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RenameGroup(Group group, string name)
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = string.Format("UPDATE Groups SET name=@name WHERE id={0}", group.Id);
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@name";
                    parameter.DbType = DbType.String;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = name;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Group> LoadGroups()
        {
            List<Group> list = new List<Group>();
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    
                    var sql = "SELECT id, name FROM Groups ORDER BY `id` ASC";
                    command.CommandText = sql;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetValue(1);
                        //Console.WriteLine(name);
                        list.Add(new Group(id, ""+name)); // Nasty string fix.
                    }
                }
            }
            return list;
        }

        public void SaveHistory(History history)
        {
            var latest = LatestHistory();
            if (latest.Content == history.Content) {
                return; // Do not 
            }
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "INSERT INTO Histories ('content', 'created_at') values (@content, @timestamp)";
                    SQLiteParameter contentParam = new SQLiteParameter();
                    contentParam.ParameterName = "@content";
                    contentParam.DbType = DbType.String;
                    contentParam.Direction = ParameterDirection.Input;
                    contentParam.Value = history.Content;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(contentParam);
                    
                    SQLiteParameter tsParam = new SQLiteParameter();
                    tsParam.ParameterName = "@timestamp";
                    tsParam.DbType = DbType.Time;
                    tsParam.Direction = ParameterDirection.Input;
                    tsParam.Value = history.CreatedAt;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(tsParam);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAllHistories()
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "DELETE FROM Histories WHERE group_id IS NULL";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteHistory(History h)
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "DELETE FROM Histories WHERE id=@hid";
                    SQLiteParameter contentParam = new SQLiteParameter();
                    contentParam.ParameterName = "@hid";
                    contentParam.DbType = DbType.Int32;
                    contentParam.Direction = ParameterDirection.Input;
                    contentParam.Value = h.Id;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(contentParam);
                    command.ExecuteNonQuery();
                }
            }
        }

        public History LatestHistory()
        {
            History history = new History();
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    var sql = "SELECT * FROM Histories WHERE `group_id` IS NULL ORDER BY `id` DESC LIMIT 1";
                    command.CommandText = sql;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        history.Id = reader.GetInt32(0);
                        history.Name = "" + reader.GetValue(1);
                        history.Content = "" + reader.GetValue(2);
                        // obj 3, group_id 4
                        history.CreatedAt = reader.GetDateTime(5);
                    }
                }
            }
            return history;
        }

        public History LoadHistoryOfId(int hid)
        {
            History history = new History();
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    var sql = "SELECT * FROM Histories WHERE id=@hid";
                    command.CommandText = sql;
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@hid";
                    parameter.DbType = DbType.Int32;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = hid;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        history.Id = reader.GetInt32(0);
                        history.Name = "" + reader.GetValue(1);
                        history.Content = "" + reader.GetValue(2);
                        // obj 3, group_id 4
                        history.GroupID = reader.GetInt32(4);
                        history.CreatedAt = reader.GetDateTime(5);
                    }
                }
            }
            return history;
        }

        public Group LoadGroup(string name)
        {
            Group group = null;
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    var sql = "SELECT * FROM groups WHERE name=@name";
                    command.CommandText = sql;
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@name";
                    parameter.DbType = DbType.String;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = name;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        group = new Group(reader.GetInt32(0), "" + reader.GetValue(1));
                    }
                }
            }
            return group;
        }

        public List<History> LoadHistories()
        {
            List<History> list = new List<History>();
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    var sql = "SELECT * FROM histories WHERE `group_id` IS NULL ORDER BY `id` DESC";
                    command.CommandText = sql;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var history = new History();
                        history.Id = reader.GetInt32(0);
                        history.Name = "" + reader.GetValue(1);
                        history.Content = "" + reader.GetValue(2);
                        // obj 3, group_id 4
                        history.CreatedAt = reader.GetDateTime(5);
                        list.Add(history);
                    }
                }
            }
            return list;
        }
        
        public List<History> LoadSnippetsInGroup(Group group)
        {
            List<History> list = new List<History>();
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    var sql = "SELECT * FROM histories WHERE group_id=@group_id ORDER BY `id` DESC";
                    command.CommandText = sql;
                    SQLiteParameter parameter = new SQLiteParameter();
                    parameter.ParameterName = "@group_id";
                    parameter.DbType = DbType.Int32;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = group.Id;
                    // Add the parameter to the Parameters collection. 
                    command.Parameters.Add(parameter);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var history = new History();
                        history.Id = reader.GetInt32(0);
                        history.Name = "" + reader.GetValue(1);
                        history.Content = "" + reader.GetValue(2);
                        //obj 3, group_id 4
                        history.GroupID = reader.GetInt32(4);
                        history.CreatedAt = reader.GetDateTime(5);
                        list.Add(history);
                    }
                }
            }
            return list;
        }

        public void SaveSnippet(Group group, string content, string name = "")
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "INSERT INTO Histories ('name', 'content', 'group_id', 'created_at') values (@name, @content, @group_id, @timestamp)";
                    SQLiteParameter nameParam = new SQLiteParameter();
                    nameParam.ParameterName = "@name";
                    nameParam.DbType = DbType.String;
                    nameParam.Direction = ParameterDirection.Input;
                    nameParam.Value = name;
                    command.Parameters.Add(nameParam);

                    SQLiteParameter contentParam = new SQLiteParameter();
                    contentParam.ParameterName = "@content";
                    contentParam.DbType = DbType.String;
                    contentParam.Direction = ParameterDirection.Input;
                    contentParam.Value = content;
                    command.Parameters.Add(contentParam);

                    SQLiteParameter gidParam = new SQLiteParameter();
                    gidParam.ParameterName = "@group_id";
                    gidParam.DbType = DbType.Int32;
                    gidParam.Direction = ParameterDirection.Input;
                    gidParam.Value = group.Id;
                    command.Parameters.Add(gidParam);

                    SQLiteParameter tsParam = new SQLiteParameter();
                    tsParam.ParameterName = "@timestamp";
                    tsParam.DbType = DbType.Time;
                    tsParam.Direction = ParameterDirection.Input;
                    tsParam.Value = new DateTime();
                    command.Parameters.Add(tsParam);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSnippet(History history, Group group, string content, string name = "")
        {
            using (var conn = new SQLiteConnection(DataSource))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "Update Histories SET name=@name, content=@content, group_id=@group_id WHERE id=@hid";
                    SQLiteParameter nameParam = new SQLiteParameter();
                    nameParam.ParameterName = "@name";
                    nameParam.DbType = DbType.String;
                    nameParam.Direction = ParameterDirection.Input;
                    nameParam.Value = name;
                    command.Parameters.Add(nameParam);

                    SQLiteParameter contentParam = new SQLiteParameter();
                    contentParam.ParameterName = "@content";
                    contentParam.DbType = DbType.String;
                    contentParam.Direction = ParameterDirection.Input;
                    contentParam.Value = content;
                    command.Parameters.Add(contentParam);

                    SQLiteParameter gidParam = new SQLiteParameter();
                    gidParam.ParameterName = "@group_id";
                    gidParam.DbType = DbType.Int32;
                    gidParam.Direction = ParameterDirection.Input;
                    gidParam.Value = group.Id;
                    command.Parameters.Add(gidParam);

                    SQLiteParameter hidParam = new SQLiteParameter();
                    hidParam.ParameterName = "@hid";
                    hidParam.DbType = DbType.Int32;
                    hidParam.Direction = ParameterDirection.Input;
                    hidParam.Value = history.Id;
                    command.Parameters.Add(hidParam);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
