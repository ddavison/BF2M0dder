namespace BF2_M0dd3r
{
    partial class BF2BotSwap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF2BotSwap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.difExpert = new System.Windows.Forms.RadioButton();
            this.difVet = new System.Windows.Forms.RadioButton();
            this.difEasy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numBots = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBots)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.difExpert);
            this.groupBox1.Controls.Add(this.difVet);
            this.groupBox1.Controls.Add(this.difEasy);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Difficulty";
            // 
            // difExpert
            // 
            this.difExpert.AutoSize = true;
            this.difExpert.Location = new System.Drawing.Point(7, 65);
            this.difExpert.Name = "difExpert";
            this.difExpert.Size = new System.Drawing.Size(62, 17);
            this.difExpert.TabIndex = 2;
            this.difExpert.Text = "Expert";
            this.difExpert.UseVisualStyleBackColor = true;
            // 
            // difVet
            // 
            this.difVet.AutoSize = true;
            this.difVet.Checked = true;
            this.difVet.Location = new System.Drawing.Point(7, 42);
            this.difVet.Name = "difVet";
            this.difVet.Size = new System.Drawing.Size(70, 17);
            this.difVet.TabIndex = 1;
            this.difVet.TabStop = true;
            this.difVet.Text = "Veteran";
            this.difVet.UseVisualStyleBackColor = true;
            // 
            // difEasy
            // 
            this.difEasy.AutoSize = true;
            this.difEasy.Location = new System.Drawing.Point(7, 20);
            this.difEasy.Name = "difEasy";
            this.difEasy.Size = new System.Drawing.Size(52, 17);
            this.difEasy.TabIndex = 0;
            this.difEasy.Text = "Easy";
            this.difEasy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numBots);
            this.groupBox2.Location = new System.Drawing.Point(120, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Bots";
            // 
            // numBots
            // 
            this.numBots.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBots.Location = new System.Drawing.Point(7, 20);
            this.numBots.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBots.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBots.Name = "numBots";
            this.numBots.Size = new System.Drawing.Size(114, 21);
            this.numBots.TabIndex = 0;
            this.numBots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBots.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numBots.Click += new System.EventHandler(this.numBots_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(121, 60);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(126, 24);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 128);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(678, 436);
            this.txt.TabIndex = 3;
            this.txt.Text = resources.GetString("txt.Text");
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(121, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BF2BotSwap
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(249, 112);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BF2BotSwap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BF2 BotSwap";
            this.Load += new System.EventHandler(this.BF2BotSwap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton difExpert;
        private System.Windows.Forms.RadioButton difVet;
        private System.Windows.Forms.RadioButton difEasy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numBots;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Button button1;
    }
}