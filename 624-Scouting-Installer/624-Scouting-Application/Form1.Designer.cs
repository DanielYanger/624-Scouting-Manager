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
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyText = new System.Windows.Forms.TextBox();
            this.eventCodeLabel = new System.Windows.Forms.Label();
            this.eventCodeText = new System.Windows.Forms.TextBox();
            this.sechduleLabel = new System.Windows.Forms.Label();
            this.ImportMatchDataLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.devicePath = new System.Windows.Forms.TextBox();
            this.ChooseDeviceButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PythonExeText.Location = new System.Drawing.Point(177, 179);
            this.PythonExeText.Name = "PythonExeText";
            this.PythonExeText.Size = new System.Drawing.Size(268, 20);
            this.PythonExeText.TabIndex = 30;
            this.PythonExeText.TextChanged += new System.EventHandler(this.PythonExeText_TextChanged);
            // 
            // PythonExeButton
            // 
            this.PythonExeButton.BackColor = System.Drawing.Color.Transparent;
            this.PythonExeButton.ForeColor = System.Drawing.Color.Black;
            this.PythonExeButton.Location = new System.Drawing.Point(37, 179);
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
            this.scheduleGeneratorButton.Location = new System.Drawing.Point(200, 417);
            this.scheduleGeneratorButton.Name = "scheduleGeneratorButton";
            this.scheduleGeneratorButton.Size = new System.Drawing.Size(100, 23);
            this.scheduleGeneratorButton.TabIndex = 28;
            this.scheduleGeneratorButton.Text = "Generate";
            this.scheduleGeneratorButton.UseVisualStyleBackColor = true;
            this.scheduleGeneratorButton.Click += new System.EventHandler(this.scheduleGeneratorButton_Click);
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.apiKeyLabel.Location = new System.Drawing.Point(94, 382);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(63, 18);
            this.apiKeyLabel.TabIndex = 27;
            this.apiKeyLabel.Text = "API Key:";
            this.apiKeyLabel.Click += new System.EventHandler(this.apiKeyLabel_Click);
            // 
            // apiKeyText
            // 
            this.apiKeyText.Location = new System.Drawing.Point(177, 382);
            this.apiKeyText.Name = "apiKeyText";
            this.apiKeyText.Size = new System.Drawing.Size(268, 20);
            this.apiKeyText.TabIndex = 26;
            // 
            // eventCodeLabel
            // 
            this.eventCodeLabel.AutoSize = true;
            this.eventCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.eventCodeLabel.Location = new System.Drawing.Point(68, 348);
            this.eventCodeLabel.Name = "eventCodeLabel";
            this.eventCodeLabel.Size = new System.Drawing.Size(89, 18);
            this.eventCodeLabel.TabIndex = 25;
            this.eventCodeLabel.Text = "Event Code:";
            this.eventCodeLabel.Click += new System.EventHandler(this.eventCodeLabel_Click);
            // 
            // eventCodeText
            // 
            this.eventCodeText.Location = new System.Drawing.Point(177, 348);
            this.eventCodeText.Name = "eventCodeText";
            this.eventCodeText.Size = new System.Drawing.Size(268, 20);
            this.eventCodeText.TabIndex = 24;
            // 
            // sechduleLabel
            // 
            this.sechduleLabel.AutoSize = true;
            this.sechduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sechduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.sechduleLabel.Location = new System.Drawing.Point(17, 315);
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
            this.ImportMatchDataLabel.Location = new System.Drawing.Point(17, 223);
            this.ImportMatchDataLabel.Name = "ImportMatchDataLabel";
            this.ImportMatchDataLabel.Size = new System.Drawing.Size(142, 20);
            this.ImportMatchDataLabel.TabIndex = 22;
            this.ImportMatchDataLabel.Text = "Import Match Data";
            // 
            // importButton
            // 
            this.importButton.ForeColor = System.Drawing.Color.Black;
            this.importButton.Location = new System.Drawing.Point(200, 289);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(100, 23);
            this.importButton.TabIndex = 20;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // devicePath
            // 
            this.devicePath.Location = new System.Drawing.Point(177, 258);
            this.devicePath.Name = "devicePath";
            this.devicePath.Size = new System.Drawing.Size(268, 20);
            this.devicePath.TabIndex = 19;
            // 
            // ChooseDeviceButton
            // 
            this.ChooseDeviceButton.ForeColor = System.Drawing.Color.Black;
            this.ChooseDeviceButton.Location = new System.Drawing.Point(37, 258);
            this.ChooseDeviceButton.Name = "ChooseDeviceButton";
            this.ChooseDeviceButton.Size = new System.Drawing.Size(120, 20);
            this.ChooseDeviceButton.TabIndex = 18;
            this.ChooseDeviceButton.Text = "Choose Device";
            this.ChooseDeviceButton.UseVisualStyleBackColor = true;
            this.ChooseDeviceButton.Click += new System.EventHandler(this.ChooseDeviceButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_624_Scouting_Application.Properties.Resources.text_green;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 105);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PythonEngineLabel);
            this.Controls.Add(this.PythonExeText);
            this.Controls.Add(this.PythonExeButton);
            this.Controls.Add(this.scheduleGeneratorButton);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.apiKeyText);
            this.Controls.Add(this.eventCodeLabel);
            this.Controls.Add(this.eventCodeText);
            this.Controls.Add(this.sechduleLabel);
            this.Controls.Add(this.ImportMatchDataLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.devicePath);
            this.Controls.Add(this.ChooseDeviceButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 519);
            this.MinimumSize = new System.Drawing.Size(500, 519);
            this.Name = "Form1";
            this.Text = "624 Scouting Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PythonEngineLabel;
        private System.Windows.Forms.TextBox PythonExeText;
        private System.Windows.Forms.Button PythonExeButton;
        private System.Windows.Forms.Button scheduleGeneratorButton;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyText;
        private System.Windows.Forms.Label eventCodeLabel;
        private System.Windows.Forms.TextBox eventCodeText;
        private System.Windows.Forms.Label sechduleLabel;
        private System.Windows.Forms.Label ImportMatchDataLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.TextBox devicePath;
        private System.Windows.Forms.Button ChooseDeviceButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

