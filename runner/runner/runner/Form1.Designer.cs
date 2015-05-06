namespace runner
{
    partial class frmRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRunner));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnRun = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.isUsingCustomDimensions = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.addPara = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.resy = new DevComponents.Editors.IntegerInput();
            this.resx = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.chkWindowed = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resx)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Controls.Add(this.btnRun);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(399, 202);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(321, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // btnRun
            // 
            this.btnRun.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRun.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRun.Location = new System.Drawing.Point(240, 174);
            this.btnRun.Name = "btnRun";
            this.btnRun.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.runButton_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.chkWindowed);
            this.panelEx3.Controls.Add(this.isUsingCustomDimensions);
            this.panelEx3.Controls.Add(this.addPara);
            this.panelEx3.Controls.Add(this.labelX2);
            this.panelEx3.Controls.Add(this.buttonX1);
            this.panelEx3.Controls.Add(this.resy);
            this.panelEx3.Controls.Add(this.resx);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.Location = new System.Drawing.Point(3, 33);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(393, 135);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.White;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // isUsingCustomDimensions
            // 
            // 
            // 
            // 
            this.isUsingCustomDimensions.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.isUsingCustomDimensions.BackgroundStyle.BackColor2 = System.Drawing.Color.Black;
            this.isUsingCustomDimensions.BackgroundStyle.Class = "";
            this.isUsingCustomDimensions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isUsingCustomDimensions.Location = new System.Drawing.Point(9, 30);
            this.isUsingCustomDimensions.Name = "isUsingCustomDimensions";
            this.isUsingCustomDimensions.Size = new System.Drawing.Size(384, 23);
            this.isUsingCustomDimensions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.isUsingCustomDimensions.TabIndex = 6;
            this.isUsingCustomDimensions.Text = "I am using a custom resolution to launch BF2";
            this.isUsingCustomDimensions.TextColor = System.Drawing.Color.Silver;
            this.isUsingCustomDimensions.CheckedChanged += new System.EventHandler(this.isUsingCustomDimensions_CheckedChanged);
            // 
            // addPara
            // 
            this.addPara.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.addPara.Border.Class = "TextBoxBorder";
            this.addPara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addPara.ForeColor = System.Drawing.Color.White;
            this.addPara.Location = new System.Drawing.Point(9, 107);
            this.addPara.Name = "addPara";
            this.addPara.Size = new System.Drawing.Size(375, 19);
            this.addPara.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(9, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.White;
            this.labelX2.Size = new System.Drawing.Size(118, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Additional Parameters:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.ForeColor = System.Drawing.Color.White;
            this.buttonX1.Location = new System.Drawing.Point(155, 61);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(116, 17);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Fill With my Resolution";
            this.buttonX1.Click += new System.EventHandler(this.fillMaxRes_Click);
            // 
            // resy
            // 
            this.resy.AntiAlias = true;
            // 
            // 
            // 
            this.resy.BackgroundStyle.BackColor = System.Drawing.Color.Black;
            this.resy.BackgroundStyle.BackColor2 = System.Drawing.Color.Gray;
            this.resy.BackgroundStyle.BorderColor = System.Drawing.Color.White;
            this.resy.BackgroundStyle.Class = "DateTimeInputBackground";
            this.resy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.resy.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.resy.ForeColor = System.Drawing.Color.White;
            this.resy.Location = new System.Drawing.Point(82, 59);
            this.resy.Name = "resy";
            this.resy.ShowUpDown = true;
            this.resy.Size = new System.Drawing.Size(67, 19);
            this.resy.TabIndex = 2;
            // 
            // resx
            // 
            this.resx.AntiAlias = true;
            // 
            // 
            // 
            this.resx.BackgroundStyle.BackColor = System.Drawing.Color.Black;
            this.resx.BackgroundStyle.BackColor2 = System.Drawing.Color.Gray;
            this.resx.BackgroundStyle.BorderColor = System.Drawing.Color.White;
            this.resx.BackgroundStyle.Class = "DateTimeInputBackground";
            this.resx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.resx.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.resx.ForeColor = System.Drawing.Color.White;
            this.resx.Location = new System.Drawing.Point(9, 59);
            this.resx.Name = "resx";
            this.resx.ShowUpDown = true;
            this.resx.Size = new System.Drawing.Size(67, 19);
            this.resx.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(9, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.White;
            this.labelX1.Size = new System.Drawing.Size(102, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Custom Resolution:";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Location = new System.Drawing.Point(3, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(393, 33);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Silver;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.Color = System.Drawing.Color.White;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            this.panelEx2.Text = "BF2 Modder Runner Configuration";
            this.panelEx2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEx2_MouseMove);
            // 
            // chkWindowed
            // 
            // 
            // 
            // 
            this.chkWindowed.BackgroundStyle.Class = "";
            this.chkWindowed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkWindowed.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Right;
            this.chkWindowed.Location = new System.Drawing.Point(237, 92);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(149, 15);
            this.chkWindowed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkWindowed.TabIndex = 7;
            this.chkWindowed.Text = "Run in Windowed Mode";
            this.chkWindowed.TextColor = System.Drawing.Color.White;
            this.chkWindowed.CheckedChanged += new System.EventHandler(this.chkWindowed_CheckedChanged);
            // 
            // frmRunner
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(399, 202);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF2 Modder Runner";
            this.Load += new System.EventHandler(this.frmRunner_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.Editors.IntegerInput resy;
        private DevComponents.Editors.IntegerInput resx;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnRun;
        private DevComponents.DotNetBar.Controls.TextBoxX addPara;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX isUsingCustomDimensions;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkWindowed;

    }
}

