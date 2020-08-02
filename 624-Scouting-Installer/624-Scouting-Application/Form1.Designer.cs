namespace _624_Scouting_Application
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
            this.PythonEngineLabel = new System.Windows.Forms.Label();
            this.PythonExeText = new System.Windows.Forms.TextBox();
            this.PythonExeButton = new System.Windows.Forms.Button();
            this.scheduleGeneratorButton = new System.Windows.Forms.Button();
            this.eventCodeLabel = new System.Windows.Forms.Label();
            this.eventCodeText = new System.Windows.Forms.TextBox();
            this.sechduleLabel = new System.Windows.Forms.Label();
            this.ImportMatchDataLabel = new System.Windows.Forms.Label();
            this.devicePath = new System.Windows.Forms.TextBox();
            this.ChooseDeviceButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.team_list_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PythonEngineLabel
            // 
            this.PythonEngineLabel.AutoSize = true;
            this.PythonEngineLabel.BackColor = System.Drawing.Color.Transparent;
            this.PythonEngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PythonEngineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.PythonEngineLabel.Location = new System.Drawing.Point(17, 143);
            this.PythonEngineLabel.Name = "PythonEngineLabel";
            this.PythonEngineLabel.Size = new System.Drawing.Size(161, 20);
            this.PythonEngineLabel.TabIndex = 31;
            this.PythonEngineLabel.Text = "Select Python Engine";
            this.PythonEngineLabel.Click += new System.EventHandler(this.PythonEngineLabel_Click);
            // 
            // PythonExeText
            // 
            this.PythonExeText.Location = new System.Drawing.Point(177, 167);
            this.PythonExeText.Name = "PythonExeText";
            this.PythonExeText.Size = new System.Drawing.Size(268, 20);
            this.PythonExeText.TabIndex = 30;
            this.PythonExeText.TextChanged += new System.EventHandler(this.PythonExeText_TextChanged);
            // 
            // PythonExeButton
            // 
            this.PythonExeButton.BackColor = System.Drawing.Color.Transparent;
            this.PythonExeButton.ForeColor = System.Drawing.Color.Black;
            this.PythonExeButton.Location = new System.Drawing.Point(37, 167);
            this.PythonExeButton.Name = "PythonExeButton";
            this.PythonExeButton.Size = new System.Drawing.Size(120, 20);
            this.PythonExeButton.TabIndex = 29;
            this.PythonExeButton.Text = "Choose Python";
            this.PythonExeButton.UseVisualStyleBackColor = false;
            this.PythonExeButton.Click += new System.EventHandler(this.PythonExeButton_Click);
            // 
            // scheduleGeneratorButton
            // 
            this.scheduleGeneratorButton.ForeColor = System.Drawing.Color.Black;
            this.scheduleGeneratorButton.Location = new System.Drawing.Point(200, 453);
            this.scheduleGeneratorButton.Name = "scheduleGeneratorButton";
            this.scheduleGeneratorButton.Size = new System.Drawing.Size(100, 23);
            this.scheduleGeneratorButton.TabIndex = 28;
            this.scheduleGeneratorButton.Text = "Generate";
            this.scheduleGeneratorButton.UseVisualStyleBackColor = true;
            this.scheduleGeneratorButton.Click += new System.EventHandler(this.scheduleGeneratorButton_Click);
            // 
            // eventCodeLabel
            // 
            this.eventCodeLabel.AutoSize = true;
            this.eventCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.eventCodeLabel.Location = new System.Drawing.Point(68, 406);
            this.eventCodeLabel.Name = "eventCodeLabel";
            this.eventCodeLabel.Size = new System.Drawing.Size(89, 18);
            this.eventCodeLabel.TabIndex = 25;
            this.eventCodeLabel.Text = "Event Code:";
            this.eventCodeLabel.Click += new System.EventHandler(this.eventCodeLabel_Click);
            // 
            // eventCodeText
            // 
            this.eventCodeText.Location = new System.Drawing.Point(177, 404);
            this.eventCodeText.Name = "eventCodeText";
            this.eventCodeText.Size = new System.Drawing.Size(268, 20);
            this.eventCodeText.TabIndex = 24;
            // 
            // sechduleLabel
            // 
            this.sechduleLabel.AutoSize = true;
            this.sechduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sechduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.sechduleLabel.Location = new System.Drawing.Point(17, 373);
            this.sechduleLabel.Name = "sechduleLabel";
            this.sechduleLabel.Size = new System.Drawing.Size(153, 20);
            this.sechduleLabel.TabIndex = 23;
            this.sechduleLabel.Text = "Schedule Generator";
            // 
            // ImportMatchDataLabel
            // 
            this.ImportMatchDataLabel.AutoSize = true;
            this.ImportMatchDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportMatchDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ImportMatchDataLabel.Location = new System.Drawing.Point(17, 201);
            this.ImportMatchDataLabel.Name = "ImportMatchDataLabel";
            this.ImportMatchDataLabel.Size = new System.Drawing.Size(142, 20);
            this.ImportMatchDataLabel.TabIndex = 22;
            this.ImportMatchDataLabel.Text = "Import Match Data";
            this.ImportMatchDataLabel.Click += new System.EventHandler(this.ImportMatchDataLabel_Click);
            // 
            // devicePath
            // 
            this.devicePath.Location = new System.Drawing.Point(177, 283);
            this.devicePath.Name = "devicePath";
            this.devicePath.Size = new System.Drawing.Size(268, 20);
            this.devicePath.TabIndex = 19;
            // 
            // ChooseDeviceButton
            // 
            this.ChooseDeviceButton.ForeColor = System.Drawing.Color.Black;
            this.ChooseDeviceButton.Location = new System.Drawing.Point(39, 283);
            this.ChooseDeviceButton.Name = "ChooseDeviceButton";
            this.ChooseDeviceButton.Size = new System.Drawing.Size(120, 20);
            this.ChooseDeviceButton.TabIndex = 18;
            this.ChooseDeviceButton.Text = "Choose Device";
            this.ChooseDeviceButton.UseVisualStyleBackColor = true;
            this.ChooseDeviceButton.Click += new System.EventHandler(this.ChooseDeviceButton_Click);
            // 
            // importButton
            // 
            this.importButton.ForeColor = System.Drawing.Color.Black;
            this.importButton.Location = new System.Drawing.Point(200, 331);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(100, 23);
            this.importButton.TabIndex = 20;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Black;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(177, 240);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Match Data";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(273, 240);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Pit Data";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(78, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Data Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_624_Scouting_Application.Properties.Resources._624_loading;
            this.pictureBox4.Location = new System.Drawing.Point(287, 406);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 125);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_624_Scouting_Application.Properties.Resources._624_loading;
            this.pictureBox2.Location = new System.Drawing.Point(287, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_624_Scouting_Application.Properties.Resources.scouting_manager_banner;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 128);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // team_list_button
            // 
            this.team_list_button.ForeColor = System.Drawing.Color.Black;
            this.team_list_button.Location = new System.Drawing.Point(200, 571);
            this.team_list_button.Name = "team_list_button";
            this.team_list_button.Size = new System.Drawing.Size(100, 23);
            this.team_list_button.TabIndex = 38;
            this.team_list_button.Text = "Generate";
            this.team_list_button.UseVisualStyleBackColor = true;
            this.team_list_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_624_Scouting_Application.Properties.Resources._624_loading;
            this.pictureBox3.Location = new System.Drawing.Point(287, 526);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Team List Generator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(68, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Event Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(499, 624);
            this.Controls.Add(this.team_list_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.scheduleGeneratorButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.devicePath);
            this.Controls.Add(this.eventCodeLabel);
            this.Controls.Add(this.eventCodeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PythonEngineLabel);
            this.Controls.Add(this.ChooseDeviceButton);
            this.Controls.Add(this.PythonExeText);
            this.Controls.Add(this.PythonExeButton);
            this.Controls.Add(this.ImportMatchDataLabel);
            this.Controls.Add(this.sechduleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(515, 663);
            this.MinimumSize = new System.Drawing.Size(515, 663);
            this.Name = "Form1";
            this.Text = "624 Scouting Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PythonEngineLabel;
        private System.Windows.Forms.TextBox PythonExeText;
        private System.Windows.Forms.Button PythonExeButton;
        private System.Windows.Forms.Button scheduleGeneratorButton;
        private System.Windows.Forms.Label eventCodeLabel;
        private System.Windows.Forms.TextBox eventCodeText;
        private System.Windows.Forms.Label sechduleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label ImportMatchDataLabel;
        private System.Windows.Forms.TextBox devicePath;
        private System.Windows.Forms.Button ChooseDeviceButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button team_list_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

