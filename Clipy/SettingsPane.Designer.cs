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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code Font";
            // 
            // changeCodeFontButton
            // 
            this.changeCodeFontButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeCodeFontButton.Location = new System.Drawing.Point(190, 51);
            this.changeCodeFontButton.Name = "changeCodeFontButton";
            this.changeCodeFontButton.Size = new System.Drawing.Size(76, 23);
            this.changeCodeFontButton.TabIndex = 1;
            this.changeCodeFontButton.Text = "Change";
            this.changeCodeFontButton.UseVisualStyleBackColor = true;
            this.changeCodeFontButton.Click += new System.EventHandler(this.changeCodeFontButton_Click);
            // 
            // fontNameTextBox
            // 
            this.fontNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fontNameTextBox.Location = new System.Drawing.Point(80, 22);
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.ReadOnly = true;
            this.fontNameTextBox.Size = new System.Drawing.Size(186, 23);
            this.fontNameTextBox.TabIndex = 0;
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(292, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // startupAtLoginCheckBox
            // 
            this.startupAtLoginCheckBox.AutoSize = true;
            this.startupAtLoginCheckBox.Enabled = false;
            this.startupAtLoginCheckBox.Location = new System.Drawing.Point(9, 114);
            this.startupAtLoginCheckBox.Name = "startupAtLoginCheckBox";
            this.startupAtLoginCheckBox.Size = new System.Drawing.Size(169, 21);
            this.startupAtLoginCheckBox.TabIndex = 6;
            this.startupAtLoginCheckBox.Text = "Start up when user login";
            this.startupAtLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemPerGroupStepper
            // 
            this.itemPerGroupStepper.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.itemPerGroupStepper.Location = new System.Drawing.Point(195, 81);
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
            this.itemPerGroupStepper.Size = new System.Drawing.Size(69, 23);
            this.itemPerGroupStepper.TabIndex = 5;
            this.itemPerGroupStepper.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Items Per Group (5-30)";
            // 
            // menuLengthStepper
            // 
            this.menuLengthStepper.Location = new System.Drawing.Point(195, 52);
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
            this.menuLengthStepper.Size = new System.Drawing.Size(69, 23);
            this.menuLengthStepper.TabIndex = 3;
            this.menuLengthStepper.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menu Length (10-30)";
            // 
            // numberOfHistoriesStepper
            // 
            this.numberOfHistoriesStepper.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfHistoriesStepper.Location = new System.Drawing.Point(195, 23);
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
            this.numberOfHistoriesStepper.Size = new System.Drawing.Size(69, 23);
            this.numberOfHistoriesStepper.TabIndex = 1;
            this.numberOfHistoriesStepper.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Histories (20-200)";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(406, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.Location = new System.Drawing.Point(487, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(13, 283);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 318);
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
            this.Text = "SettingsPane";
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