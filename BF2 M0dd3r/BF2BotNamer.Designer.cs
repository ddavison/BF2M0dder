namespace BF2_M0dd3r
{
    partial class BF2BotNamer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF2BotNamer));
            this.mainContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useDefaultBotNames = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.botNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.botNamesListBox = new System.Windows.Forms.CheckedListBox();
            this.delete0 = new System.Windows.Forms.LinkLabel();
            this.addBotGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addBotButton = new System.Windows.Forms.Button();
            this.botNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.useTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.botNamesGroupBox.SuspendLayout();
            this.addBotGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.groupBox1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(393, 424);
            this.mainContainer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useDefaultBotNames);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.botNamesGroupBox);
            this.groupBox1.Controls.Add(this.addBotGroupBox);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Names";
            // 
            // useDefaultBotNames
            // 
            this.useDefaultBotNames.AutoSize = true;
            this.useDefaultBotNames.Location = new System.Drawing.Point(12, 402);
            this.useDefaultBotNames.Name = "useDefaultBotNames";
            this.useDefaultBotNames.Size = new System.Drawing.Size(153, 16);
            this.useDefaultBotNames.TabIndex = 6;
            this.useDefaultBotNames.Text = "Use Default Bot Names";
            this.useDefaultBotNames.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botNamesGroupBox
            // 
            this.botNamesGroupBox.Controls.Add(this.botNamesListBox);
            this.botNamesGroupBox.Controls.Add(this.delete0);
            this.botNamesGroupBox.Location = new System.Drawing.Point(12, 56);
            this.botNamesGroupBox.Name = "botNamesGroupBox";
            this.botNamesGroupBox.Size = new System.Drawing.Size(369, 336);
            this.botNamesGroupBox.TabIndex = 3;
            this.botNamesGroupBox.TabStop = false;
            // 
            // botNamesListBox
            // 
            this.botNamesListBox.CheckOnClick = true;
            this.botNamesListBox.FormattingEnabled = true;
            this.botNamesListBox.Location = new System.Drawing.Point(0, 7);
            this.botNamesListBox.Name = "botNamesListBox";
            this.botNamesListBox.ScrollAlwaysVisible = true;
            this.botNamesListBox.Size = new System.Drawing.Size(369, 326);
            this.botNamesListBox.TabIndex = 2;
            this.botNamesListBox.ThreeDCheckBoxes = true;
            this.botNamesListBox.Click += new System.EventHandler(this.botNamesListBox_Click);
            // 
            // delete0
            // 
            this.delete0.AutoSize = true;
            this.delete0.Location = new System.Drawing.Point(320, 7);
            this.delete0.Name = "delete0";
            this.delete0.Size = new System.Drawing.Size(40, 12);
            this.delete0.TabIndex = 1;
            this.delete0.TabStop = true;
            this.delete0.Text = "delete";
            // 
            // addBotGroupBox
            // 
            this.addBotGroupBox.Controls.Add(this.groupBox3);
            this.addBotGroupBox.Controls.Add(this.addBotButton);
            this.addBotGroupBox.Controls.Add(this.botNameTextBox);
            this.addBotGroupBox.Controls.Add(this.label1);
            this.addBotGroupBox.Location = new System.Drawing.Point(12, 18);
            this.addBotGroupBox.Name = "addBotGroupBox";
            this.addBotGroupBox.Size = new System.Drawing.Size(369, 39);
            this.addBotGroupBox.TabIndex = 2;
            this.addBotGroupBox.TabStop = false;
            this.addBotGroupBox.Text = "Add";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 168);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // addBotButton
            // 
            this.addBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBotButton.Location = new System.Drawing.Point(315, 12);
            this.addBotButton.Name = "addBotButton";
            this.addBotButton.Size = new System.Drawing.Size(24, 19);
            this.addBotButton.TabIndex = 2;
            this.addBotButton.Text = "+";
            this.addBotButton.UseVisualStyleBackColor = true;
            this.addBotButton.Click += new System.EventHandler(this.addBotButton_Click);
            // 
            // botNameTextBox
            // 
            this.botNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.botNameTextBox.Location = new System.Drawing.Point(88, 12);
            this.botNameTextBox.MaxLength = 60;
            this.botNameTextBox.Name = "botNameTextBox";
            this.botNameTextBox.Size = new System.Drawing.Size(228, 19);
            this.botNameTextBox.TabIndex = 1;
            this.botNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.botNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bot Name:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "what is this?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // useTimer
            // 
            this.useTimer.Enabled = true;
            this.useTimer.Tick += new System.EventHandler(this.useTimer_Tick);
            // 
            // BF2BotNamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 424);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Verdana", 7F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BF2BotNamer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BF2 BotNamer";
            this.Load += new System.EventHandler(this.BF2BotNamer_Load);
            this.mainContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.botNamesGroupBox.ResumeLayout(false);
            this.botNamesGroupBox.PerformLayout();
            this.addBotGroupBox.ResumeLayout(false);
            this.addBotGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox addBotGroupBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox botNamesGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addBotButton;
        private System.Windows.Forms.TextBox botNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel delete0;
        private System.Windows.Forms.CheckedListBox botNamesListBox;
        private System.Windows.Forms.CheckBox useDefaultBotNames;
        private System.Windows.Forms.Timer useTimer;
    }
}