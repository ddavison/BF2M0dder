namespace BF2_M0dd3r
{
    partial class BF2Weaponizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF2Weaponizer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbFaction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.apply = new System.Windows.Forms.Button();
            this.u1 = new System.Windows.Forms.RadioButton();
            this.u2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.cmbFaction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "AntiTank",
            "Engineer",
            "Medic",
            "Special Forces",
            "Sniper"});
            this.cmbClass.Location = new System.Drawing.Point(12, 72);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(143, 21);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // cmbFaction
            // 
            this.cmbFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Items.AddRange(new object[] {
            "US",
            "MEC",
            "Chinese"});
            this.cmbFaction.Location = new System.Drawing.Point(12, 31);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Size = new System.Drawing.Size(143, 21);
            this.cmbFaction.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a Faction";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.u2);
            this.groupBox2.Controls.Add(this.u1);
            this.groupBox2.Controls.Add(this.apply);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(24, 60);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(113, 23);
            this.apply.TabIndex = 2;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            // 
            // u1
            // 
            this.u1.AutoSize = true;
            this.u1.Checked = true;
            this.u1.Location = new System.Drawing.Point(24, 9);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(119, 17);
            this.u1.TabIndex = 3;
            this.u1.TabStop = true;
            this.u1.Text = "Unlock Weapon #1";
            this.u1.UseVisualStyleBackColor = true;
            // 
            // u2
            // 
            this.u2.AutoSize = true;
            this.u2.Location = new System.Drawing.Point(24, 32);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(119, 17);
            this.u2.TabIndex = 4;
            this.u2.Text = "Unlock Weapon #2";
            this.u2.UseVisualStyleBackColor = true;
            // 
            // BF2Weaponizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 234);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BF2Weaponizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BF2 Weaponizer";
            this.Load += new System.EventHandler(this.BF2Weaponizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbFaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.RadioButton u2;
        private System.Windows.Forms.RadioButton u1;

    }
}