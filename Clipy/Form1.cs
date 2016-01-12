using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clipy
{
    public partial class MainForm : Form
    {
        // MFC Import
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        // Bring window to front while not in focus.
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);

        // Should go to settings later.
        private int MAX_COUNT = 50;
        private int MAX_MENU_TITLE = 20;

        // Local variable
        IntPtr nextClipboardViewer;
        List<Group> groups;
        List<History> histories;

        // Calculated Property
        private MenuItem settingsMenu;
        private MenuItem SettingsMenu
        {
            get
            {
                if (settingsMenu == null)
                {
                    settingsMenu = new MenuItem();
                    settingsMenu.Text = "Settings";
                    settingsMenu.Click += SettingsMenu_Click;
                }
                return settingsMenu;
            }
        }

        private void SettingsMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings window here.");
        }

        private MenuItem editMenu;
        private MenuItem EditMenu
        {
            get
            {
                if (editMenu == null)
                {
                    editMenu = new MenuItem();
                    editMenu.Text = "Edit";
                    editMenu.Click += EditMenu_Click;
                }
                return editMenu;
            }
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            MakeKeyAndVisiable();
        }

        private MenuItem exitMenu;
        private MenuItem ExitMenu
        {
            get
            {
                if (exitMenu == null)
                {
                    exitMenu = new MenuItem();
                    exitMenu.Text = "Exit";
                    exitMenu.Click += ExitMenu_Click;
                }
                return exitMenu;
            }
        }
        
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public MainForm()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
            // Initialize database.
            DataProcess db = new DataProcess();
            ReloadGroupsUI();
            ReloadHistoriesUI();
            // Initialize Tray Menu.
            UpdateTrayMenu();
            // Hide App When start.
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x0308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    ClipboardDataChanged();
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

        void ClipboardDataChanged()
        {
            IDataObject iData = Clipboard.GetDataObject();

            try
            {
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    var content = (string)iData.GetData(DataFormats.Text);
                    if (content == null || content == "") { return; }
                    var history = new History();
                    history.Content = content;
                    history.CreatedAt = DateTime.Now;
                    var db = new DataProcess();
                    db.SaveHistory(history);
                    histories = db.LoadHistories();
                    ReloadHistoriesUI();
                    UpdateTrayMenu();
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
            groups.ForEach((v) => {
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
            if (groupsList.SelectedIndices.Count != 1)
            {
                snippetsList.Items.Clear();
            }
            else
            {
                DataProcess db = new DataProcess();
                histories = db.LoadHistories();
                snippetsList.Items.Clear();
                histories.ForEach((h) => {
                    var c = h.Content.Trim();
                    if (c.Count() > 50)
                    {
                        c = c.Substring(0, 50);
                    }
                    snippetsList.Items.Add(c);
                });
            }
        }

        private void historiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = snippetsList.SelectedIndex;
            contentTextBox.Text = histories[index].Content;
        }

        private void historiesList_DoubleClick(object sender, EventArgs e)
        {
            var index = snippetsList.SelectedIndex;
            var content = histories[index].Content;
            if (content == null) { return;  }
            contentTextBox.Text = content;
            if (content.Trim() == "") { return; }
            Clipboard.SetText(content);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Normal == WindowState)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
            else {
                MakeKeyAndVisiable();
            }
        }

        private void UpdateTrayMenu()
        {
            if (histories.Count == 0)
            {
                var db = new DataProcess();
                histories = db.LoadHistories();
            }

            var contextMenu = new ContextMenu();
            int totalItems = Math.Min(histories.Count, MAX_COUNT);
            
            MenuItem menu = new MenuItem(); // dummy 
            for (int i = 0; i < totalItems; i++) {
                if (i % 10 == 0)
                {
                    menu = new MenuItem();
                    menu.Text = string.Format("{0} - {1}", 1 + i, (i / 10 + 1) * 10);
                    contextMenu.MenuItems.Add(menu);
                }
                MenuItem subMenu = new MenuItem();
                var content = histories[i].Content.Trim();
                subMenu.Text = content.Substring(0, Math.Min(content.Count(), MAX_MENU_TITLE));
                // TODO: Tooltip? 
                subMenu.Tag = i;
                subMenu.Click += SubMenu_Click;
                menu.MenuItems.Add(subMenu);
            }

            // Add more menus.
            contextMenu.MenuItems.Add("-");
            contextMenu.MenuItems.Add(EditMenu);
            contextMenu.MenuItems.Add(SettingsMenu);
            contextMenu.MenuItems.Add("-");
            contextMenu.MenuItems.Add(ExitMenu);

            notifyIcon1.ContextMenu = contextMenu;
        }

        private void SubMenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("Menu clicked {0}.", ((MenuItem)sender).Tag));
            int tag = (int)((MenuItem)sender).Tag;
            var history = histories[tag];

            var content = history.Content;
            if (content == null || content.Trim() == "") { return; }
            Clipboard.SetText(content);
        }

        private void MakeKeyAndVisiable()
        {
            Show();
            SetForegroundWindow(Handle.ToInt32());
            WindowState = FormWindowState.Normal;
        }

    }
}

