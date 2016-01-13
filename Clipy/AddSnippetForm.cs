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
            Console.WriteLine("Selected Index " + groupListCombo.SelectedIndex);
        }
    }
}
