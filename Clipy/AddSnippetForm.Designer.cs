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
            this.groupListCombo.FormattingEnabled = true;
            this.groupListCombo.Location = new System.Drawing.Point(220, 10);
            this.groupListCombo.Name = "groupListCombo";
            this.groupListCombo.Size = new System.Drawing.Size(125, 20);
            this.groupListCombo.TabIndex = 0;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(179, 13);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(35, 12);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Group";
            // 
            // snippetContentBox
            // 
            this.snippetContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snippetContentBox.Location = new System.Drawing.Point(12, 36);
            this.snippetContentBox.Multiline = true;
            this.snippetContentBox.Name = "snippetContentBox";
            this.snippetContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.snippetContentBox.Size = new System.Drawing.Size(381, 198);
            this.snippetContentBox.TabIndex = 2;
            // 
            // addSnippetButton
            // 
            this.addSnippetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSnippetButton.Location = new System.Drawing.Point(237, 240);
            this.addSnippetButton.Name = "addSnippetButton";
            this.addSnippetButton.Size = new System.Drawing.Size(75, 23);
            this.addSnippetButton.TabIndex = 3;
            this.addSnippetButton.Text = "Save";
            this.addSnippetButton.UseVisualStyleBackColor = true;
            this.addSnippetButton.Click += new System.EventHandler(this.addSnippetButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(318, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(48, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 21);
            this.nameTextBox.TabIndex = 6;
            // 
            // AddSnippetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 275);
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
            this.Text = "Add Snippet";
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