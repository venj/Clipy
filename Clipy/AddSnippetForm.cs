using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Clipy
{
    public partial class AddSnippetForm : Form
    {
        public int SelectedId { get; set; }
        private History _currentHistory;

        // For localization.
        private ResourceManager resmgr = new ResourceManager("Clipy.Strings", Assembly.GetExecutingAssembly());
        private CultureInfo ci = Thread.CurrentThread.CurrentUICulture;

        private List<Group> groups;
        public AddSnippetForm()
        {
            InitializeComponent();
            var db = new DataProcess();
            groups = db.LoadGroups();
        }

        public AddSnippetForm(History h)
        {
            InitializeComponent();
            var db = new DataProcess();
            groups = db.LoadGroups();
            _currentHistory = h;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillComboBox()
        {
            groups.ForEach((group) => {
                groupListCombo.Items.Add(group.Name);
            });
        }

        private void AddSnippetForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
            groupListCombo.SelectedIndex = SelectedId;
            nameTextBox.Focus();
            snippetContentBox.Font = fetchMonoFont();
            if (_currentHistory != null)
            {
                nameTextBox.Text = _currentHistory.Name;
                snippetContentBox.Text = _currentHistory.Content;
                Text = resmgr.GetString("__message_box_message_edit_snippet", ci);
            }
            else
            {
                Text = resmgr.GetString("__message_box_message_add_snippet", ci);
            }
        }
        
        private Font fetchMonoFont()
        {
            string fontName = Properties.Settings.Default.monoFontName;
            float fontSize = Properties.Settings.Default.monoFontSize;
            FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), Properties.Settings.Default.monoFontStyle);
            var UIFont = new Font(fontName, fontSize, fontStyle);
            return UIFont;
        }

        private void addSnippetButton_Click(object sender, EventArgs e)
        {
            if (snippetContentBox.Text.Trim() == "")
            {
                MessageBox.Show(resmgr.GetString("__message_box_message_snippet_cannot_empty", ci));
                return;
            }

            if (groupListCombo.Text.Trim() == "")
            {
                MessageBox.Show(resmgr.GetString("__message_box_message_group_cannot_empty", ci));
                return;
            }

            var db = new DataProcess();
            int selectedIndex = groupListCombo.SelectedIndex;
            string name = groupListCombo.Text;
            Group selectedGroup;
            if (selectedIndex == -1)
            {
                try
                {
                    db.AddGroup(name);
                }
                catch (Exception err)
                {
                    // TODO: Catch name unique error.
                    MessageBox.Show(err.Message);
                    return;
                }
                selectedGroup = db.LoadGroup(name);
            }
            else
            {
                selectedGroup = groups[selectedIndex];
            }
            if (_currentHistory == null)
            {
                try
                {
                    db.SaveSnippet(selectedGroup, snippetContentBox.Text, nameTextBox.Text.Trim());
                    Close();
                }
                catch (Exception err) // catch potential error.
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    db.UpdateSnippet(_currentHistory, selectedGroup, snippetContentBox.Text, nameTextBox.Text.Trim());
                    Close();
                }
                catch (Exception err) // catch potential error.
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
            
        }
    }
}
