﻿namespace Toolkit
{
    partial class Toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolkit));
            this.twrpButton = new System.Windows.Forms.Button();
            this.unlockButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RootedLabel = new System.Windows.Forms.Label();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.AndroidVersionLabel = new System.Windows.Forms.Label();
            this.CodeNameLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.rebootButton = new System.Windows.Forms.Button();
            this.rebootRecoveryButton = new System.Windows.Forms.Button();
            this.rebootBootloaderButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.logcatButton = new System.Windows.Forms.Button();
            this.loadingSpinner = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // twrpButton
            // 
            this.twrpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twrpButton.Location = new System.Drawing.Point(9, 48);
            this.twrpButton.Name = "twrpButton";
            this.twrpButton.Size = new System.Drawing.Size(201, 50);
            this.twrpButton.TabIndex = 0;
            this.twrpButton.Text = "Install TWRP Recovery ";
            this.twrpButton.Click += new System.EventHandler(this.twrpButton_Click);
            // 
            // unlockButton
            // 
            this.unlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockButton.Location = new System.Drawing.Point(9, 104);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(201, 33);
            this.unlockButton.TabIndex = 5;
            this.unlockButton.Text = "Unlock bootloader";
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.customButton);
            this.groupBox1.Controls.Add(this.twrpButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flash Recovery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please only try to flash a recovery\r\nif your device is unlocked.";
            // 
            // customButton
            // 
            this.customButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton.Location = new System.Drawing.Point(9, 103);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(201, 50);
            this.customButton.TabIndex = 3;
            this.customButton.Text = "Install another recovery image";
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.unlockButton);
            this.groupBox2.Location = new System.Drawing.Point(15, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unlock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 75);
            this.label5.TabIndex = 7;
            this.label5.Text = "If the bootloader is unlocked you\r\nmay lose the manufacturer warranty.\r\nPlease en" +
    "able \"Unknown sources\"\r\nin Settings>Security before you\r\ncontinue.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RootedLabel);
            this.groupBox3.Controls.Add(this.SerialNumberLabel);
            this.groupBox3.Controls.Add(this.AndroidVersionLabel);
            this.groupBox3.Controls.Add(this.CodeNameLabel);
            this.groupBox3.Controls.Add(this.DeviceNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(236, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 149);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Info";
            // 
            // RootedLabel
            // 
            this.RootedLabel.AutoSize = true;
            this.RootedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootedLabel.Location = new System.Drawing.Point(7, 115);
            this.RootedLabel.Name = "RootedLabel";
            this.RootedLabel.Size = new System.Drawing.Size(65, 18);
            this.RootedLabel.TabIndex = 4;
            this.RootedLabel.Text = "Rooted: ";
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberLabel.Location = new System.Drawing.Point(7, 92);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(107, 18);
            this.SerialNumberLabel.TabIndex = 3;
            this.SerialNumberLabel.Text = "Serial number: ";
            // 
            // AndroidVersionLabel
            // 
            this.AndroidVersionLabel.AutoSize = true;
            this.AndroidVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AndroidVersionLabel.Location = new System.Drawing.Point(7, 67);
            this.AndroidVersionLabel.Name = "AndroidVersionLabel";
            this.AndroidVersionLabel.Size = new System.Drawing.Size(118, 18);
            this.AndroidVersionLabel.TabIndex = 2;
            this.AndroidVersionLabel.Text = "Android version: ";
            // 
            // CodeNameLabel
            // 
            this.CodeNameLabel.AutoSize = true;
            this.CodeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeNameLabel.Location = new System.Drawing.Point(7, 42);
            this.CodeNameLabel.Name = "CodeNameLabel";
            this.CodeNameLabel.Size = new System.Drawing.Size(96, 18);
            this.CodeNameLabel.TabIndex = 1;
            this.CodeNameLabel.Text = "Code Name: ";
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.AutoSize = true;
            this.DeviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceNameLabel.Location = new System.Drawing.Point(7, 18);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(105, 18);
            this.DeviceNameLabel.TabIndex = 0;
            this.DeviceNameLabel.Text = "Device Name: ";
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(15, 332);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(547, 100);
            this.logBox.TabIndex = 17;
            this.logBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.modeBox);
            this.groupBox5.Controls.Add(this.rebootButton);
            this.groupBox5.Controls.Add(this.rebootRecoveryButton);
            this.groupBox5.Controls.Add(this.rebootBootloaderButton);
            this.groupBox5.Location = new System.Drawing.Point(236, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 167);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reboot commands";
            // 
            // modeBox
            // 
            this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Items.AddRange(new object[] {
            "ADB",
            "Fastboot"});
            this.modeBox.Location = new System.Drawing.Point(7, 17);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(131, 21);
            this.modeBox.TabIndex = 3;
            this.modeBox.SelectedIndexChanged += new System.EventHandler(this.modeBox_SelectedIndexChanged);
            // 
            // rebootButton
            // 
            this.rebootButton.Enabled = false;
            this.rebootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebootButton.Location = new System.Drawing.Point(7, 44);
            this.rebootButton.Name = "rebootButton";
            this.rebootButton.Size = new System.Drawing.Size(132, 31);
            this.rebootButton.TabIndex = 0;
            this.rebootButton.Text = "Reboot";
            this.rebootButton.Click += new System.EventHandler(this.rebootButton_Click);
            // 
            // rebootRecoveryButton
            // 
            this.rebootRecoveryButton.Enabled = false;
            this.rebootRecoveryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebootRecoveryButton.Location = new System.Drawing.Point(7, 81);
            this.rebootRecoveryButton.Name = "rebootRecoveryButton";
            this.rebootRecoveryButton.Size = new System.Drawing.Size(132, 34);
            this.rebootRecoveryButton.TabIndex = 1;
            this.rebootRecoveryButton.Text = "Reboot recovery";
            this.rebootRecoveryButton.Click += new System.EventHandler(this.rebootRecoveryButton_Click);
            // 
            // rebootBootloaderButton
            // 
            this.rebootBootloaderButton.Enabled = false;
            this.rebootBootloaderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebootBootloaderButton.Location = new System.Drawing.Point(7, 121);
            this.rebootBootloaderButton.Name = "rebootBootloaderButton";
            this.rebootBootloaderButton.Size = new System.Drawing.Size(132, 34);
            this.rebootBootloaderButton.TabIndex = 2;
            this.rebootBootloaderButton.Text = "Reboot bootloader";
            this.rebootBootloaderButton.Click += new System.EventHandler(this.rebootBootloaderButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.screenshotButton);
            this.groupBox4.Controls.Add(this.logcatButton);
            this.groupBox4.Location = new System.Drawing.Point(388, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 167);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // screenshotButton
            // 
            this.screenshotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotButton.Location = new System.Drawing.Point(9, 96);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(159, 55);
            this.screenshotButton.TabIndex = 6;
            this.screenshotButton.Text = "Take screenshot";
            this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
            // 
            // logcatButton
            // 
            this.logcatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logcatButton.Location = new System.Drawing.Point(9, 22);
            this.logcatButton.Name = "logcatButton";
            this.logcatButton.Size = new System.Drawing.Size(159, 55);
            this.logcatButton.TabIndex = 5;
            this.logcatButton.Text = "Save logcat";
            this.logcatButton.Click += new System.EventHandler(this.logcatButton_Click);
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Image = ((System.Drawing.Image)(resources.GetObject("loadingSpinner.Image")));
            this.loadingSpinner.Location = new System.Drawing.Point(193, 436);
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(225, 21);
            this.loadingSpinner.TabIndex = 20;
            this.loadingSpinner.TabStop = false;
            this.loadingSpinner.Visible = false;
            // 
            // Toolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 460);
            this.Controls.Add(this.loadingSpinner);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Toolkit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformer Toolkit ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Toolkit_FormClosing);
            this.Load += new System.EventHandler(this.Toolkit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button twrpButton;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label AndroidVersionLabel;
        private System.Windows.Forms.Label CodeNameLabel;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label RootedLabel;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button rebootButton;
        private System.Windows.Forms.Button rebootRecoveryButton;
        private System.Windows.Forms.Button rebootBootloaderButton;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.Button logcatButton;
        private System.Windows.Forms.PictureBox loadingSpinner;
    }
}

