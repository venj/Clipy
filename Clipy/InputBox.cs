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
    public partial class InputBox : Form
    {
        private string Prompt { get; set; }
        private string Title { get; set; }
        private string DefaultResponse { get; set; }

        public InputBox(string prompt, string title, string defaultResponse) : this()
        {
            Prompt = prompt;
            Title = title;
            DefaultResponse = defaultResponse;
            // UI
            Text = title;
            promptLabel.Text = Prompt;
            contentBox.Text = defaultResponse;
            contentBox.SelectAll();
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
