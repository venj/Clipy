namespace Clipy
{
    partial class AddSnippetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSnippetForm));
            this.groupListCombo = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.snippetContentBox = new System.Windows.Forms.TextBox();
            this.addSnippetButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // groupListCombo
            // 
            resources.ApplyResources(this.groupListCombo, "groupListCombo");
            this.groupListCombo.FormattingEnabled = true;
            this.groupListCombo.Name = "groupListCombo";
            // 
            // groupLabel
            // 
            resources.ApplyResources(this.groupLabel, "groupLabel");
            this.groupLabel.Name = "groupLabel";
            // 
            // snippetContentBox
            // 
            resources.ApplyResources(this.snippetContentBox, "snippetContentBox");
            this.snippetContentBox.Name = "snippetContentBox";
            // 
            // addSnippetButton
            // 
            resources.ApplyResources(this.addSnippetButton, "addSnippetButton");
            this.addSnippetButton.Name = "addSnippetButton";
            this.addSnippetButton.UseVisualStyleBackColor = true;
            this.addSnippetButton.Click += new System.EventHandler(this.addSnippetButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // AddSnippetForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addSnippetButton);
            this.Controls.Add(this.snippetContentBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupListCombo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSnippetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddSnippetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupListCombo;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox snippetContentBox;
        private System.Windows.Forms.Button addSnippetButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}