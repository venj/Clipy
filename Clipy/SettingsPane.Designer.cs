namespace Clipy
{
    partial class SettingsPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPane));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeCodeFontButton = new System.Windows.Forms.Button();
            this.fontNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startupAtLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.itemPerGroupStepper = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuLengthStepper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfHistoriesStepper = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerGroupStepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLengthStepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfHistoriesStepper)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changeCodeFontButton);
            this.groupBox1.Controls.Add(this.fontNameTextBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // changeCodeFontButton
            // 
            resources.ApplyResources(this.changeCodeFontButton, "changeCodeFontButton");
            this.changeCodeFontButton.Name = "changeCodeFontButton";
            this.changeCodeFontButton.UseVisualStyleBackColor = true;
            this.changeCodeFontButton.Click += new System.EventHandler(this.changeCodeFontButton_Click);
            // 
            // fontNameTextBox
            // 
            resources.ApplyResources(this.fontNameTextBox, "fontNameTextBox");
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startupAtLoginCheckBox);
            this.groupBox2.Controls.Add(this.itemPerGroupStepper);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.menuLengthStepper);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numberOfHistoriesStepper);
            this.groupBox2.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // startupAtLoginCheckBox
            // 
            resources.ApplyResources(this.startupAtLoginCheckBox, "startupAtLoginCheckBox");
            this.startupAtLoginCheckBox.Name = "startupAtLoginCheckBox";
            this.startupAtLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemPerGroupStepper
            // 
            this.itemPerGroupStepper.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.itemPerGroupStepper, "itemPerGroupStepper");
            this.itemPerGroupStepper.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.itemPerGroupStepper.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.itemPerGroupStepper.Name = "itemPerGroupStepper";
            this.itemPerGroupStepper.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // menuLengthStepper
            // 
            resources.ApplyResources(this.menuLengthStepper, "menuLengthStepper");
            this.menuLengthStepper.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.menuLengthStepper.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.menuLengthStepper.Name = "menuLengthStepper";
            this.menuLengthStepper.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numberOfHistoriesStepper
            // 
            this.numberOfHistoriesStepper.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.numberOfHistoriesStepper, "numberOfHistoriesStepper");
            this.numberOfHistoriesStepper.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numberOfHistoriesStepper.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfHistoriesStepper.Name = "numberOfHistoriesStepper";
            this.numberOfHistoriesStepper.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsPane
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsPane";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerGroupStepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuLengthStepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfHistoriesStepper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeCodeFontButton;
        private System.Windows.Forms.TextBox fontNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown numberOfHistoriesStepper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown itemPerGroupStepper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown menuLengthStepper;
        private System.Windows.Forms.CheckBox startupAtLoginCheckBox;
    }
}