using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clipy
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        IntPtr nextClipboardViewer;
        List<Group> groups;
        List<History> histories;

        public Form1()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
            // Initialize database.
            DataProcess db = new DataProcess();
            ReloadGroupsUI();
            ReloadHistoriesUI();
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x0308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        void DisplayClipboardData()
        {
            IDataObject iData = Clipboard.GetDataObject();

            try
            {
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    var content = (string)iData.GetData(DataFormats.Text);
                    var history = new History();
                    history.Content = content;
                    history.CreatedAt = DateTime.Now;
                    var db = new DataProcess();
                    db.SaveHistory(history);
                    histories = db.LoadHistories();
                    ReloadHistoriesUI();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            }
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectionCount = groupsList.SelectedIndices.Count;
            if (selectionCount == 1)
            {
                deleteGroupButton.Enabled = true;
                renameGroupButton.Enabled = true;
            }
            else if (selectionCount > 1)
            {
                deleteGroupButton.Enabled = true;
                renameGroupButton.Enabled = false;
            }
            else
            {
                deleteGroupButton.Enabled = false;
                renameGroupButton.Enabled = false;
            }
            int selectedIndex = ((ListBox)sender).SelectedIndex;
            if (selectedIndex >= groups.Count || selectedIndex < 0) { return; }
            var group = groups[selectedIndex];
            // TODO: Do more, like show snippets in the groups.
            Console.WriteLine(string.Format("id: {0}, name: {1}", group.Id, group.Name));
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            var name = groupNameTextBox.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Group name can not be empty!");
            }
            else
            {
                var db = new DataProcess();
                try
                {
                    db.AddGroup(name);
                    ReloadGroupsUI();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void ReloadGroupsUI()
        {
            DataProcess db = new DataProcess();
            groupNameTextBox.Text = ""; // clear textbox.
            groupsList.Items.Clear();
            groups = db.LoadGroups();
            groups.ForEach(delegate(Group v) {
                groupsList.Items.Add(v.Name);
            });
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            var indices = groupsList.SelectedIndices;
            var db = new DataProcess();
            foreach (int i in indices)
            {
                db.DeleteGroup(groups[i]);
            }
            ReloadGroupsUI();
        }

        private void renameGroupButton_Click(object sender, EventArgs e)
        {
            var index = groupsList.SelectedIndex;
            var group = groups[index];
            string input = Microsoft.VisualBasic.Interaction.InputBox("Rename group", "Rename", group.Name).Trim();
            if (input != "")
            {
                var db = new DataProcess();
                db.RenameGroup(group, input);
                ReloadGroupsUI();
            }
        }

        private void ReloadHistoriesUI()
        {
            DataProcess db = new DataProcess();
            histories = db.LoadHistories();
            historiesList.Items.Clear();
            histories.ForEach(delegate (History h) {
                var c = h.Content.Trim();
                if (c.Count() > 50)
                {
                    c = c.Substring(0, 50);
                }
                historiesList.Items.Add(c);
            });
        }

        private void historiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = historiesList.SelectedIndex;
            contentTextBox.Text = histories[index].Content;
        }
    }
}
