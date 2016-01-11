namespace Clipy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupsBox = new System.Windows.Forms.GroupBox();
            this.renameGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.historiesList = new System.Windows.Forms.ListBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsBox
            // 
            this.groupsBox.Controls.Add(this.renameGroupButton);
            this.groupsBox.Controls.Add(this.deleteGroupButton);
            this.groupsBox.Controls.Add(this.groupNameTextBox);
            this.groupsBox.Controls.Add(this.addGroupButton);
            this.groupsBox.Controls.Add(this.groupsList);
            this.groupsBox.Location = new System.Drawing.Point(12, 66);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(150, 294);
            this.groupsBox.TabIndex = 4;
            this.groupsBox.TabStop = false;
            this.groupsBox.Text = "Groups";
            // 
            // renameGroupButton
            // 
            this.renameGroupButton.Enabled = false;
            this.renameGroupButton.Location = new System.Drawing.Point(6, 261);
            this.renameGroupButton.Name = "renameGroupButton";
            this.renameGroupButton.Size = new System.Drawing.Size(64, 23);
            this.renameGroupButton.TabIndex = 8;
            this.renameGroupButton.Text = "Rename";
            this.renameGroupButton.UseVisualStyleBackColor = true;
            this.renameGroupButton.Click += new System.EventHandler(this.renameGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Enabled = false;
            this.deleteGroupButton.Location = new System.Drawing.Point(76, 261);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(66, 23);
            this.deleteGroupButton.TabIndex = 7;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(6, 18);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(106, 21);
            this.groupNameTextBox.TabIndex = 6;
            this.groupNameTextBox.Enter += new System.EventHandler(this.addGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(118, 17);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(24, 24);
            this.addGroupButton.TabIndex = 5;
            this.addGroupButton.Text = "+";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupsList
            // 
            this.groupsList.FormattingEnabled = true;
            this.groupsList.ItemHeight = 12;
            this.groupsList.Location = new System.Drawing.Point(6, 47);
            this.groupsList.Name = "groupsList";
            this.groupsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.groupsList.Size = new System.Drawing.Size(136, 208);
            this.groupsList.TabIndex = 4;
            this.groupsList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(175, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.historiesList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.contentTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(342, 347);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 5;
            // 
            // historiesList
            // 
            this.historiesList.FormattingEnabled = true;
            this.historiesList.ItemHeight = 12;
            this.historiesList.Location = new System.Drawing.Point(2, 6);
            this.historiesList.Name = "historiesList";
            this.historiesList.Size = new System.Drawing.Size(337, 100);
            this.historiesList.TabIndex = 7;
            this.historiesList.SelectedIndexChanged += new System.EventHandler(this.historiesList_SelectedIndexChanged);
            this.historiesList.DoubleClick += new System.EventHandler(this.historiesList_DoubleClick);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(3, 6);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(337, 217);
            this.contentTextBox.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clipy";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupsBox.ResumeLayout(false);
            this.groupsBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupsBox;
        private System.Windows.Forms.Button renameGroupButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ListBox groupsList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox historiesList;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

