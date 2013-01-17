namespace FontArranger
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.specialCharTextBox = new System.Windows.Forms.TextBox();
            this.packCheckBox = new System.Windows.Forms.CheckBox();
            this.specialChars = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.lowerLetters = new System.Windows.Forms.CheckBox();
            this.capLetters = new System.Windows.Forms.CheckBox();
            this.trimInput = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cocosCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPathTextBox
            // 
            this.inputPathTextBox.AllowDrop = true;
            this.inputPathTextBox.Location = new System.Drawing.Point(6, 19);
            this.inputPathTextBox.Name = "inputPathTextBox";
            this.inputPathTextBox.Size = new System.Drawing.Size(522, 20);
            this.inputPathTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(537, 17);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPictureBox.BackgroundImage")));
            this.previewPictureBox.Location = new System.Drawing.Point(4, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(595, 165);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previewPictureBox.TabIndex = 2;
            this.previewPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.specialCharTextBox);
            this.groupBox2.Controls.Add(this.packCheckBox);
            this.groupBox2.Controls.Add(this.specialChars);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.numbers);
            this.groupBox2.Controls.Add(this.lowerLetters);
            this.groupBox2.Controls.Add(this.capLetters);
            this.groupBox2.Controls.Add(this.trimInput);
            this.groupBox2.Controls.Add(this.inputPathTextBox);
            this.groupBox2.Controls.Add(this.browseButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // specialCharTextBox
            // 
            this.specialCharTextBox.Enabled = false;
            this.specialCharTextBox.Location = new System.Drawing.Point(184, 65);
            this.specialCharTextBox.Name = "specialCharTextBox";
            this.specialCharTextBox.Size = new System.Drawing.Size(344, 20);
            this.specialCharTextBox.TabIndex = 11;
            // 
            // packCheckBox
            // 
            this.packCheckBox.AutoSize = true;
            this.packCheckBox.Checked = true;
            this.packCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.packCheckBox.Enabled = false;
            this.packCheckBox.Location = new System.Drawing.Point(86, 88);
            this.packCheckBox.Name = "packCheckBox";
            this.packCheckBox.Size = new System.Drawing.Size(88, 17);
            this.packCheckBox.TabIndex = 10;
            this.packCheckBox.Text = "Pack Images";
            this.packCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialChars
            // 
            this.specialChars.AutoSize = true;
            this.specialChars.Enabled = false;
            this.specialChars.Location = new System.Drawing.Point(86, 65);
            this.specialChars.Name = "specialChars";
            this.specialChars.Size = new System.Drawing.Size(91, 17);
            this.specialChars.TabIndex = 9;
            this.specialChars.Text = "Special Chars";
            this.specialChars.UseVisualStyleBackColor = true;
            this.specialChars.CheckedChanged += new System.EventHandler(this.specialChars_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(537, 112);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Load";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Checked = true;
            this.numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numbers.Enabled = false;
            this.numbers.Location = new System.Drawing.Point(7, 112);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(71, 17);
            this.numbers.TabIndex = 8;
            this.numbers.Text = "Chars 0-9";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // lowerLetters
            // 
            this.lowerLetters.AutoSize = true;
            this.lowerLetters.Checked = true;
            this.lowerLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerLetters.Enabled = false;
            this.lowerLetters.Location = new System.Drawing.Point(7, 88);
            this.lowerLetters.Name = "lowerLetters";
            this.lowerLetters.Size = new System.Drawing.Size(70, 17);
            this.lowerLetters.TabIndex = 7;
            this.lowerLetters.Text = "Chars a-z";
            this.lowerLetters.UseVisualStyleBackColor = true;
            // 
            // capLetters
            // 
            this.capLetters.AutoSize = true;
            this.capLetters.Checked = true;
            this.capLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capLetters.Enabled = false;
            this.capLetters.Location = new System.Drawing.Point(7, 65);
            this.capLetters.Name = "capLetters";
            this.capLetters.Size = new System.Drawing.Size(73, 17);
            this.capLetters.TabIndex = 6;
            this.capLetters.Text = "Chars A-Z";
            this.capLetters.UseVisualStyleBackColor = true;
            // 
            // trimInput
            // 
            this.trimInput.AutoSize = true;
            this.trimInput.Checked = true;
            this.trimInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trimInput.Enabled = false;
            this.trimInput.Location = new System.Drawing.Point(86, 111);
            this.trimInput.Name = "trimInput";
            this.trimInput.Size = new System.Drawing.Size(73, 17);
            this.trimInput.TabIndex = 5;
            this.trimInput.Text = "Trim Input";
            this.trimInput.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.previewPictureBox);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 171);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fontNameTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.cocosCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font Name";
            // 
            // fontNameTextBox
            // 
            this.fontNameTextBox.Location = new System.Drawing.Point(9, 36);
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.Size = new System.Drawing.Size(518, 20);
            this.fontNameTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(520, 82);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cocosCheckBox
            // 
            this.cocosCheckBox.AutoSize = true;
            this.cocosCheckBox.Checked = true;
            this.cocosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cocosCheckBox.Location = new System.Drawing.Point(499, 62);
            this.cocosCheckBox.Name = "cocosCheckBox";
            this.cocosCheckBox.Size = new System.Drawing.Size(113, 17);
            this.cocosCheckBox.TabIndex = 5;
            this.cocosCheckBox.Text = "Generate .FNT file";
            this.cocosCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 196);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Font Arranger";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox specialChars;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox lowerLetters;
        private System.Windows.Forms.CheckBox capLetters;
        private System.Windows.Forms.CheckBox trimInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cocosCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox fontNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox packCheckBox;
        private System.Windows.Forms.TextBox specialCharTextBox;
    }
}

