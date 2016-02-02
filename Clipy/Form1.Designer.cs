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
            this.horizontalSplitter = new System.Windows.Forms.SplitContainer();
            this.renameGroupButton = new System.Windows.Forms.Button();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.verticalSplitter = new System.Windows.Forms.SplitContainer();
            this.snippetsList = new System.Windows.Forms.ListBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.editSnippetButton = new System.Windows.Forms.Button();
            this.deleteSnippetButton = new System.Windows.Forms.Button();
            this.addSnippetButton = new System.Windows.Forms.Button();
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
            // horizontalSplitter
            // 
            resources.ApplyResources(this.horizontalSplitter, "horizontalSplitter");
            this.horizontalSplitter.Name = "horizontalSplitter";
            // 
            // horizontalSplitter.Panel1
            // 
            resources.ApplyResources(this.horizontalSplitter.Panel1, "horizontalSplitter.Panel1");
            this.horizontalSplitter.Panel1.Controls.Add(this.renameGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.deleteGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.groupNameTextBox);
            this.horizontalSplitter.Panel1.Controls.Add(this.addGroupButton);
            this.horizontalSplitter.Panel1.Controls.Add(this.groupsList);
            // 
            // horizontalSplitter.Panel2
            // 
            resources.ApplyResources(this.horizontalSplitter.Panel2, "horizontalSplitter.Panel2");
            this.horizontalSplitter.Panel2.Controls.Add(this.verticalSplitter);
            // 
            // renameGroupButton
            // 
            resources.ApplyResources(this.renameGroupButton, "renameGroupButton");
            this.renameGroupButton.Name = "renameGroupButton";
            this.renameGroupButton.UseVisualStyleBackColor = true;
            this.renameGroupButton.Click += new System.EventHandler(this.renameGroupButton_Click);
            // 
            // deleteGroupButton
            // 
            resources.ApplyResources(this.deleteGroupButton, "deleteGroupButton");
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            resources.ApplyResources(this.groupNameTextBox, "groupNameTextBox");
            this.groupNameTextBox.Name = "groupNameTextBox";
            // 
            // addGroupButton
            // 
            resources.ApplyResources(this.addGroupButton, "addGroupButton");
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupsList
            // 
            resources.ApplyResources(this.groupsList, "groupsList");
            this.groupsList.FormattingEnabled = true;
            this.groupsList.Name = "groupsList";
            this.groupsList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // verticalSplitter
            // 
            resources.ApplyResources(this.verticalSplitter, "verticalSplitter");
            this.verticalSplitter.Name = "verticalSplitter";
            // 
            // verticalSplitter.Panel1
            // 
            resources.ApplyResources(this.verticalSplitter.Panel1, "verticalSplitter.Panel1");
            this.verticalSplitter.Panel1.Controls.Add(this.snippetsList);
            // 
            // verticalSplitter.Panel2
            // 
            resources.ApplyResources(this.verticalSplitter.Panel2, "verticalSplitter.Panel2");
            this.verticalSplitter.Panel2.Controls.Add(this.contentTextBox);
            // 
            // snippetsList
            // 
            resources.ApplyResources(this.snippetsList, "snippetsList");
            this.snippetsList.FormattingEnabled = true;
            this.snippetsList.Name = "snippetsList";
            this.snippetsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.snippetsList.SelectedIndexChanged += new System.EventHandler(this.snippetsList_SelectedIndexChanged);
            this.snippetsList.DoubleClick += new System.EventHandler(this.snippetsList_DoubleClick);
            // 
            // contentTextBox
            // 
            resources.ApplyResources(this.contentTextBox, "contentTextBox");
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // editSnippetButton
            // 
            resources.ApplyResources(this.editSnippetButton, "editSnippetButton");
            this.editSnippetButton.Name = "editSnippetButton";
            this.editSnippetButton.UseVisualStyleBackColor = true;
            this.editSnippetButton.Click += new System.EventHandler(this.editSnippetButton_Click);
            // 
            // deleteSnippetButton
            // 
            resources.ApplyResources(this.deleteSnippetButton, "deleteSnippetButton");
            this.deleteSnippetButton.Name = "deleteSnippetButton";
            this.deleteSnippetButton.UseVisualStyleBackColor = true;
            this.deleteSnippetButton.Click += new System.EventHandler(this.deleteSnippetButton_Click);
            // 
            // addSnippetButton
            // 
            resources.ApplyResources(this.addSnippetButton, "addSnippetButton");
            this.addSnippetButton.Image = global::Clipy.Properties.Resources.add_small;
            this.addSnippetButton.Name = "addSnippetButton";
            this.addSnippetButton.UseVisualStyleBackColor = true;
            this.addSnippetButton.Click += new System.EventHandler(this.addSnippetButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editSnippetButton);
            this.Controls.Add(this.deleteSnippetButton);
            this.Controls.Add(this.addSnippetButton);
            this.Controls.Add(this.horizontalSplitter);
            this.Name = "MainForm";
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

