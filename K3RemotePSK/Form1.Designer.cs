namespace K3RemotePSK
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
            this.vfoALabel = new System.Windows.Forms.Label();
            this.vfoATextBox = new System.Windows.Forms.TextBox();
            this.txButton = new System.Windows.Forms.Button();
            this.decodedText = new System.Windows.Forms.TextBox();
            this.decodedLabel = new System.Windows.Forms.Label();
            this.comPortName = new System.Windows.Forms.TextBox();
            this.comConnectButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txLabel = new System.Windows.Forms.Label();
            this.txTextBox = new System.Windows.Forms.TextBox();
            this.cqButton = new System.Windows.Forms.Button();
            this.callLabel = new System.Windows.Forms.Label();
            this.callsignTextBox = new System.Windows.Forms.TextBox();
            this.rstLabel = new System.Windows.Forms.Label();
            this.rstTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.over1Button = new System.Windows.Forms.Button();
            this.lastOverButton = new System.Windows.Forms.Button();
            this.freqUpButton = new System.Windows.Forms.Button();
            this.freqDownButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vfoALabel
            // 
            this.vfoALabel.AutoSize = true;
            this.vfoALabel.Location = new System.Drawing.Point(20, 47);
            this.vfoALabel.Name = "vfoALabel";
            this.vfoALabel.Size = new System.Drawing.Size(41, 13);
            this.vfoALabel.TabIndex = 0;
            this.vfoALabel.Text = "VFO A:";
            // 
            // vfoATextBox
            // 
            this.vfoATextBox.Font = new System.Drawing.Font("Digital Readout Upright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vfoATextBox.Location = new System.Drawing.Point(79, 36);
            this.vfoATextBox.Name = "vfoATextBox";
            this.vfoATextBox.Size = new System.Drawing.Size(131, 31);
            this.vfoATextBox.TabIndex = 1;
            this.vfoATextBox.Text = "00.000.000";
            this.vfoATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txButton
            // 
            this.txButton.BackColor = System.Drawing.Color.YellowGreen;
            this.txButton.Location = new System.Drawing.Point(216, 12);
            this.txButton.Name = "txButton";
            this.txButton.Size = new System.Drawing.Size(50, 23);
            this.txButton.TabIndex = 2;
            this.txButton.Text = "RX";
            this.txButton.UseVisualStyleBackColor = false;
            // 
            // decodedText
            // 
            this.decodedText.Location = new System.Drawing.Point(79, 139);
            this.decodedText.Multiline = true;
            this.decodedText.Name = "decodedText";
            this.decodedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodedText.Size = new System.Drawing.Size(431, 92);
            this.decodedText.TabIndex = 3;
            // 
            // decodedLabel
            // 
            this.decodedLabel.AutoSize = true;
            this.decodedLabel.Location = new System.Drawing.Point(13, 142);
            this.decodedLabel.Name = "decodedLabel";
            this.decodedLabel.Size = new System.Drawing.Size(48, 13);
            this.decodedLabel.TabIndex = 4;
            this.decodedLabel.Text = "Decode:";
            // 
            // comPortName
            // 
            this.comPortName.Location = new System.Drawing.Point(381, 44);
            this.comPortName.Name = "comPortName";
            this.comPortName.Size = new System.Drawing.Size(51, 20);
            this.comPortName.TabIndex = 5;
            this.comPortName.Text = "COM8";
            // 
            // comConnectButton
            // 
            this.comConnectButton.Location = new System.Drawing.Point(438, 44);
            this.comConnectButton.Name = "comConnectButton";
            this.comConnectButton.Size = new System.Drawing.Size(72, 19);
            this.comConnectButton.TabIndex = 6;
            this.comConnectButton.Text = "Connect";
            this.comConnectButton.UseVisualStyleBackColor = true;
            this.comConnectButton.Click += new System.EventHandler(this.comConnectButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(86, 17);
            this.statusLabel.Text = "Not connected";
            // 
            // txLabel
            // 
            this.txLabel.AutoSize = true;
            this.txLabel.Location = new System.Drawing.Point(13, 252);
            this.txLabel.Name = "txLabel";
            this.txLabel.Size = new System.Drawing.Size(24, 13);
            this.txLabel.TabIndex = 8;
            this.txLabel.Text = "TX:";
            this.txLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txTextBox
            // 
            this.txTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txTextBox.Location = new System.Drawing.Point(79, 249);
            this.txTextBox.Multiline = true;
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txTextBox.Size = new System.Drawing.Size(431, 92);
            this.txTextBox.TabIndex = 9;
            // 
            // cqButton
            // 
            this.cqButton.Location = new System.Drawing.Point(79, 353);
            this.cqButton.Name = "cqButton";
            this.cqButton.Size = new System.Drawing.Size(75, 23);
            this.cqButton.TabIndex = 10;
            this.cqButton.Text = "CQ";
            this.cqButton.UseVisualStyleBackColor = true;
            this.cqButton.Click += new System.EventHandler(this.cqButton_Click);
            // 
            // callLabel
            // 
            this.callLabel.AutoSize = true;
            this.callLabel.Location = new System.Drawing.Point(15, 89);
            this.callLabel.Name = "callLabel";
            this.callLabel.Size = new System.Drawing.Size(46, 13);
            this.callLabel.TabIndex = 11;
            this.callLabel.Text = "Callsign:";
            // 
            // callsignTextBox
            // 
            this.callsignTextBox.Location = new System.Drawing.Point(79, 86);
            this.callsignTextBox.Name = "callsignTextBox";
            this.callsignTextBox.Size = new System.Drawing.Size(100, 20);
            this.callsignTextBox.TabIndex = 12;
            // 
            // rstLabel
            // 
            this.rstLabel.AutoSize = true;
            this.rstLabel.Location = new System.Drawing.Point(400, 89);
            this.rstLabel.Name = "rstLabel";
            this.rstLabel.Size = new System.Drawing.Size(32, 13);
            this.rstLabel.TabIndex = 13;
            this.rstLabel.Text = "RST:";
            // 
            // rstTextBox
            // 
            this.rstTextBox.Location = new System.Drawing.Point(438, 86);
            this.rstTextBox.Name = "rstTextBox";
            this.rstTextBox.Size = new System.Drawing.Size(72, 20);
            this.rstTextBox.TabIndex = 14;
            this.rstTextBox.Text = "599";
            this.rstTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(207, 89);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(262, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // over1Button
            // 
            this.over1Button.Location = new System.Drawing.Point(160, 353);
            this.over1Button.Name = "over1Button";
            this.over1Button.Size = new System.Drawing.Size(75, 23);
            this.over1Button.TabIndex = 17;
            this.over1Button.Text = "Over 1";
            this.over1Button.UseVisualStyleBackColor = true;
            this.over1Button.Click += new System.EventHandler(this.over1Button_Click);
            // 
            // lastOverButton
            // 
            this.lastOverButton.Location = new System.Drawing.Point(241, 353);
            this.lastOverButton.Name = "lastOverButton";
            this.lastOverButton.Size = new System.Drawing.Size(60, 23);
            this.lastOverButton.TabIndex = 18;
            this.lastOverButton.Text = "73";
            this.lastOverButton.UseVisualStyleBackColor = true;
            this.lastOverButton.Click += new System.EventHandler(this.lastOverButton_Click);
            // 
            // freqUpButton
            // 
            this.freqUpButton.Location = new System.Drawing.Point(216, 36);
            this.freqUpButton.Name = "freqUpButton";
            this.freqUpButton.Size = new System.Drawing.Size(25, 31);
            this.freqUpButton.TabIndex = 19;
            this.freqUpButton.Text = "+";
            this.freqUpButton.UseVisualStyleBackColor = true;
            this.freqUpButton.Click += new System.EventHandler(this.freqUpButton_Click);
            // 
            // freqDownButton
            // 
            this.freqDownButton.Location = new System.Drawing.Point(241, 36);
            this.freqDownButton.Name = "freqDownButton";
            this.freqDownButton.Size = new System.Drawing.Size(25, 31);
            this.freqDownButton.TabIndex = 20;
            this.freqDownButton.Text = "-";
            this.freqDownButton.UseVisualStyleBackColor = true;
            this.freqDownButton.Click += new System.EventHandler(this.freqDownButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 441);
            this.Controls.Add(this.freqDownButton);
            this.Controls.Add(this.freqUpButton);
            this.Controls.Add(this.lastOverButton);
            this.Controls.Add(this.over1Button);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rstTextBox);
            this.Controls.Add(this.rstLabel);
            this.Controls.Add(this.callsignTextBox);
            this.Controls.Add(this.callLabel);
            this.Controls.Add(this.cqButton);
            this.Controls.Add(this.txTextBox);
            this.Controls.Add(this.txLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comConnectButton);
            this.Controls.Add(this.comPortName);
            this.Controls.Add(this.decodedLabel);
            this.Controls.Add(this.decodedText);
            this.Controls.Add(this.txButton);
            this.Controls.Add(this.vfoATextBox);
            this.Controls.Add(this.vfoALabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vfoALabel;
        public System.Windows.Forms.TextBox vfoATextBox;
        private System.Windows.Forms.Button txButton;
        private System.Windows.Forms.TextBox decodedText;
        private System.Windows.Forms.Label decodedLabel;
        private System.Windows.Forms.TextBox comPortName;
        private System.Windows.Forms.Button comConnectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label txLabel;
        private System.Windows.Forms.TextBox txTextBox;
        private System.Windows.Forms.Button cqButton;
        private System.Windows.Forms.Label callLabel;
        private System.Windows.Forms.TextBox callsignTextBox;
        private System.Windows.Forms.Label rstLabel;
        private System.Windows.Forms.TextBox rstTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button over1Button;
        private System.Windows.Forms.Button lastOverButton;
        private System.Windows.Forms.Button freqUpButton;
        private System.Windows.Forms.Button freqDownButton;
    }
}

