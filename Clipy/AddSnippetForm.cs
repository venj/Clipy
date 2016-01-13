using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipy
{
    public partial class AddSnippetForm : Form
    {
        public int SelectedId { get; set; }

        private List<Group> groups;
        public AddSnippetForm()
        {
            InitializeComponent();
            var db = new DataProcess();
            groups = db.LoadGroups();
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
        }

        private void addSnippetButton_Click(object sender, EventArgs e)
        {

            if (snippetContentBox.Text.Trim() == "")
            {
                MessageBox.Show("Snippet can not be empty.");
                return;
            }

            if (groupListCombo.Text.Trim() == "")
            {
                MessageBox.Show("Group can not be empty.");
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
    }
}
