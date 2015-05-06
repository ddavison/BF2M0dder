namespace BF2_M0dd3r
{
    partial class BF2TickIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF2TickIT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ed = new System.Windows.Forms.RichTextBox();
            this.levelGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numTicketsTeam2 = new System.Windows.Forms.NumericUpDown();
            this.numTicketsTeam1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lvlSelect = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applyChanges = new System.Windows.Forms.ToolStripButton();
            this.loadedTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.levelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketsTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketsTeam1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ed);
            this.panel1.Controls.Add(this.levelGroup);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 212);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "acceptButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ed
            // 
            this.ed.Location = new System.Drawing.Point(320, 28);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(394, 263);
            this.ed.TabIndex = 2;
            this.ed.Text = "";
            // 
            // levelGroup
            // 
            this.levelGroup.BackColor = System.Drawing.Color.Transparent;
            this.levelGroup.Controls.Add(this.button1);
            this.levelGroup.Controls.Add(this.numTicketsTeam2);
            this.levelGroup.Controls.Add(this.numTicketsTeam1);
            this.levelGroup.Controls.Add(this.label2);
            this.levelGroup.Controls.Add(this.label1);
            this.levelGroup.ForeColor = System.Drawing.Color.Black;
            this.levelGroup.Location = new System.Drawing.Point(14, 28);
            this.levelGroup.Name = "levelGroup";
            this.levelGroup.Size = new System.Drawing.Size(229, 176);
            this.levelGroup.TabIndex = 1;
            this.levelGroup.TabStop = false;
            this.levelGroup.Text = "Level Properties";
            this.levelGroup.Enter += new System.EventHandler(this.levelGroup_Enter);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numTicketsTeam2
            // 
            this.numTicketsTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTicketsTeam2.Enabled = false;
            this.numTicketsTeam2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTicketsTeam2.Location = new System.Drawing.Point(45, 71);
            this.numTicketsTeam2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTicketsTeam2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTicketsTeam2.Name = "numTicketsTeam2";
            this.numTicketsTeam2.Size = new System.Drawing.Size(56, 21);
            this.numTicketsTeam2.TabIndex = 3;
            this.numTicketsTeam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTicketsTeam2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numTicketsTeam1
            // 
            this.numTicketsTeam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTicketsTeam1.Enabled = false;
            this.numTicketsTeam1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTicketsTeam1.Location = new System.Drawing.Point(45, 32);
            this.numTicketsTeam1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTicketsTeam1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTicketsTeam1.Name = "numTicketsTeam1";
            this.numTicketsTeam1.Size = new System.Drawing.Size(56, 21);
            this.numTicketsTeam1.TabIndex = 1;
            this.numTicketsTeam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTicketsTeam1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team 2 # Tickets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team 1 # Tickets:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lvlSelect,
            this.toolStripSeparator1,
            this.applyChanges});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // lvlSelect
            // 
            this.lvlSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lvlSelect.Font = new System.Drawing.Font("Verdana", 7F);
            this.lvlSelect.ForeColor = System.Drawing.Color.Black;
            this.lvlSelect.Image = ((System.Drawing.Image)(resources.GetObject("lvlSelect.Image")));
            this.lvlSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lvlSelect.Name = "lvlSelect";
            this.lvlSelect.Size = new System.Drawing.Size(104, 22);
            this.lvlSelect.Text = "Select a level...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // applyChanges
            // 
            this.applyChanges.Font = new System.Drawing.Font("Verdana", 7F);
            this.applyChanges.ForeColor = System.Drawing.Color.Black;
            this.applyChanges.Image = global::BF2_M0dd3r.Properties.Resources.check;
            this.applyChanges.ImageTransparentColor = System.Drawing.Color.White;
            this.applyChanges.Name = "applyChanges";
            this.applyChanges.Size = new System.Drawing.Size(108, 22);
            this.applyChanges.Text = "Apply Changes";
            this.applyChanges.Click += new System.EventHandler(this.applyChanges_Click);
            // 
            // loadedTimer
            // 
            this.loadedTimer.Enabled = true;
            this.loadedTimer.Tick += new System.EventHandler(this.loadedTimer_Tick);
            // 
            // BF2TickIT
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(255, 212);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BF2TickIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BF2 TickIT";
            this.Load += new System.EventHandler(this.BF2TickIT_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.levelGroup.ResumeLayout(false);
            this.levelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketsTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketsTeam1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton lvlSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton applyChanges;
        private System.Windows.Forms.GroupBox levelGroup;
        private System.Windows.Forms.NumericUpDown numTicketsTeam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTicketsTeam2;
        private System.Windows.Forms.RichTextBox ed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer loadedTimer;
        private System.Windows.Forms.Button button2;
    }
}