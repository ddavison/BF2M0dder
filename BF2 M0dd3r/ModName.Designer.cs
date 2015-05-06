namespace BF2_M0dd3r
{
    partial class ModName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModName));
            this.txtModName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.createNew = new System.Windows.Forms.CheckBox();
            this.modList = new System.Windows.Forms.ListBox();
            this.modTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtModName
            // 
            this.txtModName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModName.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtModName.Location = new System.Drawing.Point(2, 10);
            this.txtModName.MaxLength = 50;
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(184, 22);
            this.txtModName.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(186, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 19);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // createNew
            // 
            this.createNew.AutoSize = true;
            this.createNew.Checked = true;
            this.createNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createNew.Location = new System.Drawing.Point(206, 13);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(86, 16);
            this.createNew.TabIndex = 4;
            this.createNew.Text = "Create New";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.CheckedChanged += new System.EventHandler(this.createNew_CheckedChanged);
            // 
            // modList
            // 
            this.modList.FormattingEnabled = true;
            this.modList.ItemHeight = 12;
            this.modList.Location = new System.Drawing.Point(8, 59);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(304, 220);
            this.modList.TabIndex = 5;
            this.modList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.modList_MouseDoubleClick);
            this.modList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // modTimer
            // 
            this.modTimer.Enabled = true;
            this.modTimer.Tick += new System.EventHandler(this.modTimer_Tick);
            // 
            // ModName
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(322, 54);
            this.Controls.Add(this.modList);
            this.Controls.Add(this.createNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtModName);
            this.Font = new System.Drawing.Font("Verdana", 7F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Name Your Mod";
            this.Load += new System.EventHandler(this.ModName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox createNew;
        private System.Windows.Forms.ListBox modList;
        private System.Windows.Forms.Timer modTimer;
    }
}