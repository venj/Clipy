namespace Clipy
{
    partial class MainForm
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
            ChangeClipboardChain(this.Handle, nextClipboardViewer);
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.horizontalSplitter = new System.Windows.Forms.SplitContainer();
            this.renameGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.verticalSplitter = new System.Windows.Forms.SplitContainer();
            this.snippetsList = new System.Windows.Forms.ListBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.addSnippetButton = new System.Windows.Forms.Button();
            this.deleteSnippetButton = new System.Windows.Forms.Button();
            this.editSnippetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSplitter)).BeginInit();
            this.horizontalSplitter.Panel1.SuspendLayout();
            this.horizontalSplitter.Panel2.SuspendLayout();
            this.horizontalSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitter)).BeginInit();
            this.verticalSplitter.Panel1.SuspendLayout();
            this.verticalSplitter.Panel2.SuspendLayout();
            this.verticalSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clipy";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // horizontalSplitter
            // 
            this.horizontalSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalSplitter.Location = new System.Drawing.Point(12, 63);
            this.horizontalSplitter.Name = "horizontalSplitter";
            // 
            // horizontalSplitter.Panel1
            // 
            this.horizontalSplitter.Panel1.Controls.Add(this.renameGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.deleteGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.groupNameTextBox);
            this.horizontalSplitter.Panel1.Controls.Add(this.addGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.groupsList);
            // 
            // horizontalSplitter.Panel2
            // 
            this.horizontalSplitter.Panel2.Controls.Add(this.verticalSplitter);
            this.horizontalSplitter.Size = new System.Drawing.Size(595, 279);
            this.horizontalSplitter.SplitterDistance = 198;
            this.horizontalSplitter.TabIndex = 6;
            // 
            // renameGroupButton
            // 
            this.renameGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.renameGroupButton.Enabled = false;
            this.renameGroupButton.Location = new System.Drawing.Point(3, 253);
            this.renameGroupButton.Name = "renameGroupButton";
            this.renameGroupButton.Size = new System.Drawing.Size(64, 23);
            this.renameGroupButton.TabIndex = 13;
            this.renameGroupButton.Text = "Rename";
            this.renameGroupButton.UseVisualStyleBackColor = true;
            this.renameGroupButton.Click += new System.EventHandler(this.renameGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteGroupButton.Enabled = false;
            this.deleteGroupButton.Location = new System.Drawing.Point(73, 253);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(66, 23);
            this.deleteGroupButton.TabIndex = 12;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(162, 21);
            this.groupNameTextBox.TabIndex = 11;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGroupButton.Location = new System.Drawing.Point(171, 2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(23, 23);
            this.addGroupButton.TabIndex = 10;
            this.addGroupButton.Text = "+";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupsList
            // 
            this.groupsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsList.FormattingEnabled = true;
            this.groupsList.ItemHeight = 12;
            this.groupsList.Location = new System.Drawing.Point(3, 30);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(191, 220);
            this.groupsList.TabIndex = 9;
            this.groupsList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // verticalSplitter
            // 
            this.verticalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitter.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitter.Name = "verticalSplitter";
            this.verticalSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // verticalSplitter.Panel1
            // 
            this.verticalSplitter.Panel1.Controls.Add(this.snippetsList);
            // 
            // verticalSplitter.Panel2
            // 
            this.verticalSplitter.Panel2.Controls.Add(this.contentTextBox);
            this.verticalSplitter.Size = new System.Drawing.Size(393, 279);
            this.verticalSplitter.SplitterDistance = 100;
            this.verticalSplitter.TabIndex = 0;
            // 
            // snippetsList
            // 
            this.snippetsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snippetsList.FormattingEnabled = true;
            this.snippetsList.ItemHeight = 12;
            this.snippetsList.Location = new System.Drawing.Point(0, 0);
            this.snippetsList.Name = "snippetsList";
            this.snippetsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.snippetsList.Size = new System.Drawing.Size(393, 100);
            this.snippetsList.TabIndex = 8;
            this.snippetsList.SelectedIndexChanged += new System.EventHandler(this.snippetsList_SelectedIndexChanged);
            this.snippetsList.DoubleClick += new System.EventHandler(this.snippetsList_DoubleClick);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTextBox.Location = new System.Drawing.Point(0, 2);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(393, 170);
            this.contentTextBox.TabIndex = 10;
            // 
            // addSnippetButton
            // 
            this.addSnippetButton.Location = new System.Drawing.Point(15, 12);
            this.addSnippetButton.Name = "addSnippetButton";
            this.addSnippetButton.Size = new System.Drawing.Size(50, 45);
            this.addSnippetButton.TabIndex = 7;
            this.addSnippetButton.Text = "Add";
            this.addSnippetButton.UseVisualStyleBackColor = true;
            this.addSnippetButton.Click += new System.EventHandler(this.addSnippetButton_Click);
            // 
            // deleteSnippetButton
            // 
            this.deleteSnippetButton.Enabled = false;
            this.deleteSnippetButton.Location = new System.Drawing.Point(127, 12);
            this.deleteSnippetButton.Name = "deleteSnippetButton";
            this.deleteSnippetButton.Size = new System.Drawing.Size(50, 45);
            this.deleteSnippetButton.TabIndex = 8;
            this.deleteSnippetButton.Text = "Delete";
            this.deleteSnippetButton.UseVisualStyleBackColor = true;
            this.deleteSnippetButton.Click += new System.EventHandler(this.deleteSnippetButton_Click);
            // 
            // editSnippetButton
            // 
            this.editSnippetButton.Enabled = false;
            this.editSnippetButton.Location = new System.Drawing.Point(71, 12);
            this.editSnippetButton.Name = "editSnippetButton";
            this.editSnippetButton.Size = new System.Drawing.Size(50, 45);
            this.editSnippetButton.TabIndex = 9;
            this.editSnippetButton.Text = "Edit";
            this.editSnippetButton.UseVisualStyleBackColor = true;
            this.editSnippetButton.Click += new System.EventHandler(this.editSnippetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 354);
            this.Controls.Add(this.editSnippetButton);
            this.Controls.Add(this.deleteSnippetButton);
            this.Controls.Add(this.addSnippetButton);
            this.Controls.Add(this.horizontalSplitter);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "MainForm";
            this.Text = "Edit Snippets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.horizontalSplitter.Panel1.ResumeLayout(false);
            this.horizontalSplitter.Panel1.PerformLayout();
            this.horizontalSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSplitter)).EndInit();
            this.horizontalSplitter.ResumeLayout(false);
            this.verticalSplitter.Panel1.ResumeLayout(false);
            this.verticalSplitter.Panel2.ResumeLayout(false);
            this.verticalSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitter)).EndInit();
            this.verticalSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.SplitContainer horizontalSplitter;
        private System.Windows.Forms.Button renameGroupButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ListBox groupsList;
        private System.Windows.Forms.SplitContainer verticalSplitter;
        private System.Windows.Forms.ListBox snippetsList;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button addSnippetButton;
        private System.Windows.Forms.Button deleteSnippetButton;
        private System.Windows.Forms.Button editSnippetButton;
    }
}

