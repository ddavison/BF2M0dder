/*
** 
** User: DJ
** Date: 1/1/2010
** Time: 7:20 pm
*/

namespace BF2_M0dd3r
{
	partial class BF2Modder
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BF2Modder));
            DevComponents.DotNetBar.Rendering.SuperTabPanelColorTable superTabPanelColorTable1 = new DevComponents.DotNetBar.Rendering.SuperTabPanelColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabPanelItemColorTable superTabPanelItemColorTable1 = new DevComponents.DotNetBar.Rendering.SuperTabPanelItemColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable superTabLinearGradientColorTable1 = new DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabPanelItemColorTable superTabPanelItemColorTable2 = new DevComponents.DotNetBar.Rendering.SuperTabPanelItemColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable superTabLinearGradientColorTable2 = new DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabItemColorTable superTabItemColorTable1 = new DevComponents.DotNetBar.Rendering.SuperTabItemColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabColorStates superTabColorStates1 = new DevComponents.DotNetBar.Rendering.SuperTabColorStates();
            DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable superTabItemStateColorTable1 = new DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable superTabLinearGradientColorTable3 = new DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabColorStates superTabColorStates2 = new DevComponents.DotNetBar.Rendering.SuperTabColorStates();
            DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable superTabItemStateColorTable2 = new DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable();
            DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable superTabLinearGradientColorTable4 = new DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable();
            this.cd = new System.Windows.Forms.FolderBrowserDialog();
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewModToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainContainer = new DevComponents.DotNetBar.PanelEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftBar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.svHolder = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRefreshServerSettings = new DevComponents.DotNetBar.ButtonX();
            this.btnApplyServerSettings = new DevComponents.DotNetBar.ButtonX();
            this.sv = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.fileHolder = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnCloseModHeirarchy = new DevComponents.DotNetBar.ButtonX();
            this.file = new DevComponents.AdvTree.AdvTree();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.fileContext = new DevComponents.DotNetBar.ButtonItem();
            this.editCurrentItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddNewDir = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabs = new DevComponents.DotNetBar.TabControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btnRevertToOriginal = new DevComponents.DotNetBar.ButtonX();
            this.btnRevertChanges = new DevComponents.DotNetBar.ButtonX();
            this.btnRedo = new DevComponents.DotNetBar.ButtonX();
            this.btnUndo = new DevComponents.DotNetBar.ButtonX();
            this.slider1 = new DevComponents.DotNetBar.Controls.Slider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBatchTools = new DevComponents.DotNetBar.PanelEx();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.explorerBar1 = new DevComponents.DotNetBar.ExplorerBar();
            this.explorerBarGroupItem1 = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.txtBatchReplaceFrom = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.txtBatchReplaceTo = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem9 = new DevComponents.DotNetBar.LabelItem();
            this.btnExecuteBatchReplace = new DevComponents.DotNetBar.ButtonItem();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.statusHolder = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BF2M0dd3rMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostLANBotServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playLANBotServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.applyModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.automaticLoginOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parsingMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.saveCurrentMod = new DevComponents.DotNetBar.ButtonItem();
            this.closeMod = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.saveCurFile = new DevComponents.DotNetBar.ButtonItem();
            this.closeCurFile = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.refreshButton = new DevComponents.DotNetBar.ButtonItem();
            this.btnViewCommonClient = new DevComponents.DotNetBar.ButtonItem();
            this.btnViewCommonServer = new DevComponents.DotNetBar.ButtonItem();
            this.btnViewMenuClient = new DevComponents.DotNetBar.ButtonItem();
            this.btnViewMenuServer = new DevComponents.DotNetBar.ButtonItem();
            this.btnViewObjectsClient = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.txtFind = new DevComponents.DotNetBar.TextBoxItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.searchStyle = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.selectMod = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreateNewMod = new DevComponents.DotNetBar.ButtonItem();
            this.basedOnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.networkedMods = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar10 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.txtComputerName = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnSearchNetwork = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.myNetworkedModsToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.enableNetworkingToolStripMenuItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSendBugReport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnParticipateProgram = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnMainMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreateMo = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnCloseFile = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnLoadArchive = new DevComponents.DotNetBar.ButtonItem();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.timerChanged = new System.Windows.Forms.Timer(this.components);
            this.posTimer = new System.Windows.Forms.Timer(this.components);
            this.stat = new System.Windows.Forms.Timer(this.components);
            this.editChanged = new System.Windows.Forms.Timer(this.components);
            this.tool = new System.Windows.Forms.ToolTip(this.components);
            this.modMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteM0dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsingTimer = new System.Windows.Forms.Timer(this.components);
            this.directoryCreator = new System.ComponentModel.BackgroundWorker();
            this.pluginsTimer = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.registerProductToolStripMenuItem = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.b = new DevComponents.DotNetBar.BalloonTip();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader4 = new DevComponents.AdvTree.ColumnHeader();
            this.code = new SyntaxHighlighter.SyntaxRichTextBox();
            this.contextIcon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.leftBar.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.svHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sv)).BeginInit();
            this.fileHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.file.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabs)).BeginInit();
            this.tabs.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlBatchTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
            this.statusHolder.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.BF2M0dd3rMenu.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonBar6.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.modMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cd
            // 
            this.cd.Description = "Please select the root installation directory for Battlefield 2";
            this.cd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.cd.ShowNewFolderButton = false;
            // 
            // ni
            // 
            this.ni.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni.BalloonTipText = "Extracting Archive Please Wait...";
            this.ni.BalloonTipTitle = "Extracting...";
            this.ni.ContextMenuStrip = this.contextIcon;
            this.ni.Icon = ((System.Drawing.Icon)(resources.GetObject("ni.Icon")));
            this.ni.Text = "BF2 M0dd3r";
            this.ni.Visible = true;
            this.ni.Click += new System.EventHandler(this.showBF2M0dd3r);
            // 
            // contextIcon
            // 
            this.contextIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.toolStripSeparator13,
            this.createNewModToolStripMenuItem1,
            this.toolStripSeparator14,
            this.btnLaunch,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem2});
            this.contextIcon.Name = "contextIcon";
            this.contextIcon.Size = new System.Drawing.Size(173, 110);
            // 
            // open
            // 
            this.open.Image = global::BF2_M0dd3r.Properties.Resources.appicon;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(172, 22);
            this.open.Text = "&Open BF2 M0dd3r...";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(169, 6);
            // 
            // createNewModToolStripMenuItem1
            // 
            this.createNewModToolStripMenuItem1.Image = global::BF2_M0dd3r.Properties.Resources.New;
            this.createNewModToolStripMenuItem1.Name = "createNewModToolStripMenuItem1";
            this.createNewModToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.createNewModToolStripMenuItem1.Text = "Create New Mod";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(169, 6);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Image = global::BF2_M0dd3r.Properties.Resources.bf2;
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(172, 22);
            this.btnLaunch.Text = "&Launch Battlefield 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Image = global::BF2_M0dd3r.Properties.Resources.delete;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem2.Text = "&Exit";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.mainContainer);
            this.panel1.Controls.Add(this.statusHolder);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 473);
            this.panel1.TabIndex = 2;
            // 
            // mainContainer
            // 
            this.mainContainer.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainContainer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainContainer.Controls.Add(this.splitContainer1);
            this.mainContainer.Controls.Add(this.panel4);
            this.mainContainer.Controls.Add(this.panel2);
            this.mainContainer.Controls.Add(this.panel5);
            this.mainContainer.Controls.Add(this.panel3);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 106);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(954, 343);
            this.mainContainer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainContainer.Style.BackColor1.Color = System.Drawing.SystemColors.WindowFrame;
            this.mainContainer.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.mainContainer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainContainer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainContainer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainContainer.Style.GradientAngle = 90;
            this.mainContainer.TabIndex = 6;
            this.mainContainer.Text = "BF2 M0dd3r";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(730, 323);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 19;
            // 
            // leftBar
            // 
            this.leftBar.CanvasColor = System.Drawing.SystemColors.Control;
            this.leftBar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.leftBar.Controls.Add(this.panelEx1);
            this.leftBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBar.Location = new System.Drawing.Point(0, 0);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(299, 323);
            // 
            // 
            // 
            this.leftBar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.leftBar.Style.BackColorGradientAngle = 90;
            this.leftBar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.leftBar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.leftBar.Style.BorderBottomWidth = 1;
            this.leftBar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.leftBar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.leftBar.Style.BorderLeftWidth = 1;
            this.leftBar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.leftBar.Style.BorderRightWidth = 1;
            this.leftBar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.leftBar.Style.BorderTopWidth = 1;
            this.leftBar.Style.Class = "";
            this.leftBar.Style.CornerDiameter = 4;
            this.leftBar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.leftBar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.leftBar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.leftBar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.leftBar.StyleMouseDown.Class = "";
            this.leftBar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.leftBar.StyleMouseOver.Class = "";
            this.leftBar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.leftBar.TabIndex = 20;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.svHolder);
            this.panelEx1.Controls.Add(this.fileHolder);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(293, 317);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // svHolder
            // 
            this.svHolder.CanvasColor = System.Drawing.SystemColors.Control;
            this.svHolder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.svHolder.Controls.Add(this.btnRefreshServerSettings);
            this.svHolder.Controls.Add(this.btnApplyServerSettings);
            this.svHolder.Controls.Add(this.sv);
            this.svHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.svHolder.ExpandButtonVisible = false;
            this.svHolder.Location = new System.Drawing.Point(0, 289);
            this.svHolder.Name = "svHolder";
            this.svHolder.Size = new System.Drawing.Size(293, 278);
            this.svHolder.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.svHolder.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.svHolder.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.svHolder.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.svHolder.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.svHolder.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.svHolder.Style.GradientAngle = 90;
            this.svHolder.TabIndex = 4;
            this.svHolder.TitleStyle.Alignment = System.Drawing.StringAlignment.Far;
            this.svHolder.TitleStyle.BackColor1.Color = System.Drawing.Color.Black;
            this.svHolder.TitleStyle.BackColor2.Color = System.Drawing.Color.Black;
            this.svHolder.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.svHolder.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.svHolder.TitleStyle.ForeColor.Color = System.Drawing.Color.White;
            this.svHolder.TitleStyle.GradientAngle = 90;
            this.svHolder.TitleText = "Server Settings";
            // 
            // btnRefreshServerSettings
            // 
            this.btnRefreshServerSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefreshServerSettings.BackColor = System.Drawing.Color.Black;
            this.btnRefreshServerSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRefreshServerSettings.ForeColor = System.Drawing.Color.White;
            this.btnRefreshServerSettings.Image = global::BF2_M0dd3r.Properties.Resources.RefreshDocViewHS;
            this.btnRefreshServerSettings.Location = new System.Drawing.Point(0, 3);
            this.btnRefreshServerSettings.Name = "btnRefreshServerSettings";
            this.btnRefreshServerSettings.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.helpProvider1.SetShowHelp(this.btnRefreshServerSettings, false);
            this.btnRefreshServerSettings.Size = new System.Drawing.Size(47, 20);
            this.btnRefreshServerSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefreshServerSettings.TabIndex = 3;
            this.btnRefreshServerSettings.Click += new System.EventHandler(this.btnRefreshServerSettings_Click);
            // 
            // btnApplyServerSettings
            // 
            this.btnApplyServerSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApplyServerSettings.BackColor = System.Drawing.Color.Black;
            this.btnApplyServerSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApplyServerSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnApplyServerSettings.ForeColor = System.Drawing.Color.White;
            this.btnApplyServerSettings.Image = global::BF2_M0dd3r.Properties.Resources.FormRunHS;
            this.btnApplyServerSettings.Location = new System.Drawing.Point(53, 3);
            this.btnApplyServerSettings.Name = "btnApplyServerSettings";
            this.btnApplyServerSettings.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnApplyServerSettings.Size = new System.Drawing.Size(49, 20);
            this.btnApplyServerSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnApplyServerSettings.TabIndex = 2;
            this.btnApplyServerSettings.Click += new System.EventHandler(this.btnApplyServerSettings_Click);
            // 
            // sv
            // 
            this.sv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sv.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.sv.Location = new System.Drawing.Point(0, 26);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(293, 252);
            this.sv.TabIndex = 1;
            this.sv.Text = "Server Settings";
            // 
            // fileHolder
            // 
            this.fileHolder.CanvasColor = System.Drawing.SystemColors.Control;
            this.fileHolder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.fileHolder.Controls.Add(this.btnCloseModHeirarchy);
            this.fileHolder.Controls.Add(this.file);
            this.fileHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileHolder.Location = new System.Drawing.Point(0, 0);
            this.fileHolder.Name = "fileHolder";
            this.fileHolder.Size = new System.Drawing.Size(293, 289);
            this.fileHolder.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.fileHolder.Style.BackColor1.Color = System.Drawing.Color.Black;
            this.fileHolder.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.fileHolder.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.fileHolder.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.fileHolder.Style.ForeColor.Color = System.Drawing.Color.Blue;
            this.fileHolder.Style.GradientAngle = 90;
            this.fileHolder.TabIndex = 3;
            this.fileHolder.TitleStyle.Alignment = System.Drawing.StringAlignment.Far;
            this.fileHolder.TitleStyle.BackColor1.Color = System.Drawing.Color.Black;
            this.fileHolder.TitleStyle.BackColor2.Color = System.Drawing.Color.Black;
            this.fileHolder.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.fileHolder.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.fileHolder.TitleStyle.ForeColor.Color = System.Drawing.Color.White;
            this.fileHolder.TitleStyle.GradientAngle = 90;
            this.fileHolder.TitleText = "Mod Heirarchy";
            // 
            // btnCloseModHeirarchy
            // 
            this.btnCloseModHeirarchy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseModHeirarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseModHeirarchy.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCloseModHeirarchy.ForeColor = System.Drawing.Color.White;
            this.btnCloseModHeirarchy.Image = global::BF2_M0dd3r.Properties.Resources.delete;
            this.btnCloseModHeirarchy.Location = new System.Drawing.Point(-3, 3);
            this.btnCloseModHeirarchy.Name = "btnCloseModHeirarchy";
            this.btnCloseModHeirarchy.Size = new System.Drawing.Size(44, 20);
            this.btnCloseModHeirarchy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseModHeirarchy.TabIndex = 2;
            this.btnCloseModHeirarchy.Click += new System.EventHandler(this.btnCloseModHeirarchy_Click);
            // 
            // file
            // 
            this.file.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.file.AllowDrop = true;
            this.file.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.file.BackgroundStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.file.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.ButtonFace;
            this.file.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.file.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.file.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.file.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.file.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.file.BackgroundStyle.Class = "TreeBorderKey";
            this.file.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contextMenuBar1.SetContextMenuEx(this.file, this.fileContext);
            this.file.Controls.Add(this.contextMenuBar1);
            this.file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file.ExpandBackColor = System.Drawing.Color.White;
            this.file.ExpandBorderColor = System.Drawing.Color.Blue;
            this.file.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.file.ForeColor = System.Drawing.Color.Blue;
            this.file.HotTracking = true;
            this.file.Location = new System.Drawing.Point(0, 26);
            this.file.MultiSelect = true;
            this.file.MultiSelectRule = DevComponents.AdvTree.eMultiSelectRule.AnyNode;
            this.file.Name = "file";
            this.file.NodesConnector = this.nodeConnector1;
            this.file.NodeStyle = this.elementStyle1;
            this.file.PathSeparator = ";";
            this.file.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.file.Size = new System.Drawing.Size(293, 263);
            this.file.Styles.Add(this.elementStyle1);
            this.file.TabIndex = 1;
            this.file.DoubleClick += new System.EventHandler(this.file_DoubleClick);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.fileContext});
            this.contextMenuBar1.Location = new System.Drawing.Point(9, 3);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(173, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 0;
            this.contextMenuBar1.TabStop = false;
            // 
            // fileContext
            // 
            this.fileContext.AutoExpandOnClick = true;
            this.fileContext.Image = global::BF2_M0dd3r.Properties.Resources.CommentHS;
            this.fileContext.Name = "fileContext";
            this.fileContext.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.editCurrentItem,
            this.buttonItem5});
            this.fileContext.Text = "Add New File";
            // 
            // editCurrentItem
            // 
            this.editCurrentItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.editCurrentItem.Image = global::BF2_M0dd3r.Properties.Resources.EditTableHS;
            this.editCurrentItem.Name = "editCurrentItem";
            this.editCurrentItem.Text = "Edit Item";
            // 
            // buttonItem5
            // 
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.Image = global::BF2_M0dd3r.Properties.Resources.CommentHS;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddNewDir,
            this.buttonItem9});
            this.buttonItem5.Text = "Add New Item...";
            // 
            // btnAddNewDir
            // 
            this.btnAddNewDir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAddNewDir.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewDir.Image")));
            this.btnAddNewDir.Name = "btnAddNewDir";
            this.btnAddNewDir.Text = "Add New Directory...";
            // 
            // buttonItem9
            // 
            this.buttonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem9.Image = global::BF2_M0dd3r.Properties.Resources.NewDocumentHS;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "Add New File...";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.BackColor = System.Drawing.Color.Transparent;
            this.elementStyle1.BackColor2 = System.Drawing.Color.Transparent;
            this.elementStyle1.BorderBottomWidth = 1;
            this.elementStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(162)))));
            this.elementStyle1.BorderLeftWidth = 1;
            this.elementStyle1.BorderRightWidth = 1;
            this.elementStyle1.BorderTopWidth = 1;
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelEx2);
            this.splitContainer2.Size = new System.Drawing.Size(427, 323);
            this.splitContainer2.SplitterDistance = 293;
            this.splitContainer2.TabIndex = 1;
            // 
            // tabs
            // 
            this.tabs.BackColor = System.Drawing.Color.Transparent;
            this.tabs.CanReorderTabs = true;
            this.tabs.CloseButtonOnTabsVisible = true;
            this.tabs.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabs.CloseButtonVisible = true;
            this.tabs.ColorScheme.TabBackground = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabBackground2 = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabBorder = System.Drawing.Color.Transparent;
            this.tabs.ColorScheme.TabItemBackground = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabItemBackground2 = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabItemBorder = System.Drawing.Color.Transparent;
            this.tabs.ColorScheme.TabItemBorderDark = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemHotBackground = System.Drawing.Color.Silver;
            this.tabs.ColorScheme.TabItemHotBackground2 = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabItemHotBorder = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemHotBorderDark = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemHotBorderLight = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemHotText = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemSelectedBackground = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabItemSelectedBackground2 = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabItemSelectedBorder = System.Drawing.Color.White;
            this.tabs.ColorScheme.TabItemSelectedText = System.Drawing.Color.LightGray;
            this.tabs.ColorScheme.TabItemText = System.Drawing.SystemColors.AppWorkspace;
            this.tabs.ColorScheme.TabPanelBackground = System.Drawing.SystemColors.WindowFrame;
            this.tabs.ColorScheme.TabPanelBackground2 = System.Drawing.Color.Black;
            this.tabs.ColorScheme.TabPanelBorder = System.Drawing.Color.White;
            this.tabs.Controls.Add(this.reflectionImage1);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedTabFont = new System.Drawing.Font("Verdana", 7F);
            this.tabs.SelectedTabIndex = 2;
            this.tabs.Size = new System.Drawing.Size(427, 293);
            this.tabs.TabIndex = 0;
            this.tabs.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabs.Text = "tabControl1";
            this.tabs.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabs_TabItemClose);
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = global::BF2_M0dd3r.Properties.Resources.appicon2;
            this.reflectionImage1.Location = new System.Drawing.Point(50, 3);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(353, 351);
            this.reflectionImage1.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panelEx3);
            this.panelEx2.Controls.Add(this.slider1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(427, 26);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.SystemColors.WindowFrame;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btnRevertToOriginal);
            this.panelEx3.Controls.Add(this.btnRevertChanges);
            this.panelEx3.Controls.Add(this.btnRedo);
            this.panelEx3.Controls.Add(this.btnUndo);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(200, 26);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.SystemColors.WindowFrame;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // btnRevertToOriginal
            // 
            this.btnRevertToOriginal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRevertToOriginal.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRevertToOriginal.Image = global::BF2_M0dd3r.Properties.Resources.ReverHS;
            this.btnRevertToOriginal.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnRevertToOriginal.Location = new System.Drawing.Point(123, 2);
            this.btnRevertToOriginal.Name = "btnRevertToOriginal";
            this.btnRevertToOriginal.Size = new System.Drawing.Size(28, 23);
            this.btnRevertToOriginal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRevertToOriginal.TabIndex = 3;
            this.btnRevertToOriginal.Click += new System.EventHandler(this.btnRevertToOriginal_Click);
            // 
            // btnRevertChanges
            // 
            this.btnRevertChanges.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRevertChanges.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRevertChanges.Image = global::BF2_M0dd3r.Properties.Resources.RepeatHS;
            this.btnRevertChanges.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnRevertChanges.Location = new System.Drawing.Point(71, 2);
            this.btnRevertChanges.Name = "btnRevertChanges";
            this.btnRevertChanges.Size = new System.Drawing.Size(28, 23);
            this.btnRevertChanges.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRevertChanges.TabIndex = 2;
            this.btnRevertChanges.Click += new System.EventHandler(this.btnRevertChanges_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRedo.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRedo.Image = global::BF2_M0dd3r.Properties.Resources.Edit_RedoHS;
            this.btnRedo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnRedo.Location = new System.Drawing.Point(37, 2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(28, 23);
            this.btnRedo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRedo.TabIndex = 1;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUndo.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnUndo.Image = global::BF2_M0dd3r.Properties.Resources.Edit_UndoHS;
            this.btnUndo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnUndo.Location = new System.Drawing.Point(3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(28, 23);
            this.btnUndo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // slider1
            // 
            // 
            // 
            // 
            this.slider1.BackgroundStyle.Class = "";
            this.slider1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider1.Dock = System.Windows.Forms.DockStyle.Right;
            this.slider1.Location = new System.Drawing.Point(281, 0);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(146, 26);
            this.slider1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider1.TabIndex = 0;
            this.slider1.Value = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 10);
            this.panel4.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 10);
            this.panel2.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 343);
            this.panel5.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlBatchTools);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(740, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 343);
            this.panel3.TabIndex = 13;
            // 
            // pnlBatchTools
            // 
            this.pnlBatchTools.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlBatchTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlBatchTools.Controls.Add(this.superTabControl1);
            this.pnlBatchTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBatchTools.Location = new System.Drawing.Point(0, 0);
            this.pnlBatchTools.Name = "pnlBatchTools";
            this.pnlBatchTools.Size = new System.Drawing.Size(214, 343);
            this.pnlBatchTools.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlBatchTools.Style.BackColor1.Color = System.Drawing.SystemColors.WindowFrame;
            this.pnlBatchTools.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlBatchTools.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlBatchTools.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlBatchTools.TabIndex = 0;
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.superTabControl1.CloseButtonOnTabsAlwaysDisplayed = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(214, 343);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom;
            this.superTabControl1.TabFont = new System.Drawing.Font("Verdana", 7F);
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.Text = "Weapon Batches";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.CanvasColor = System.Drawing.Color.DimGray;
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.superTabControlPanel1.Controls.Add(this.explorerBar1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            superTabLinearGradientColorTable1.Colors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.WindowFrame,
        System.Drawing.Color.Gray};
            superTabLinearGradientColorTable1.GradientAngle = 0;
            superTabPanelItemColorTable1.Background = superTabLinearGradientColorTable1;
            superTabPanelColorTable1.Default = superTabPanelItemColorTable1;
            superTabLinearGradientColorTable2.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Gray};
            superTabPanelItemColorTable2.Background = superTabLinearGradientColorTable2;
            superTabPanelColorTable1.Right = superTabPanelItemColorTable2;
            this.superTabControlPanel1.PanelColor = superTabPanelColorTable1;
            this.superTabControlPanel1.Size = new System.Drawing.Size(214, 321);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // explorerBar1
            // 
            this.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.explorerBar1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.explorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
            this.explorerBar1.BackStyle.BackColorGradientAngle = 90;
            this.explorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
            this.explorerBar1.BackStyle.Class = "";
            this.explorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBar1.GroupImages = null;
            this.explorerBar1.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.explorerBarGroupItem1});
            this.explorerBar1.Images = null;
            this.explorerBar1.Location = new System.Drawing.Point(0, 0);
            this.explorerBar1.Name = "explorerBar1";
            this.explorerBar1.Size = new System.Drawing.Size(214, 321);
            this.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.explorerBar1.TabIndex = 0;
            this.explorerBar1.Text = "explorerBar1";
            this.explorerBar1.ThemeAware = true;
            // 
            // explorerBarGroupItem1
            // 
            // 
            // 
            // 
            this.explorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.explorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderBottomWidth = 1;
            this.explorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White;
            this.explorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderLeftWidth = 1;
            this.explorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.explorerBarGroupItem1.BackStyle.BorderRightWidth = 1;
            this.explorerBarGroupItem1.BackStyle.Class = "";
            this.explorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default;
            this.explorerBarGroupItem1.Expanded = true;
            this.explorerBarGroupItem1.Name = "explorerBarGroupItem1";
            this.explorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.explorerBarGroupItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem5,
            this.txtBatchReplaceFrom,
            this.labelItem7,
            this.txtBatchReplaceTo,
            this.labelItem8,
            this.labelItem9,
            this.btnExecuteBatchReplace});
            this.explorerBarGroupItem1.Text = "Batch Replace";
            // 
            // 
            // 
            this.explorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.explorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(93)))), ((int)(((byte)(206)))));
            this.explorerBarGroupItem1.TitleHotStyle.Class = "";
            this.explorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3;
            this.explorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.explorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.explorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(93)))), ((int)(((byte)(206)))));
            this.explorerBarGroupItem1.TitleStyle.Class = "";
            this.explorerBarGroupItem1.TitleStyle.CornerDiameter = 3;
            this.explorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.explorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.explorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.White;
            this.explorerBarGroupItem1.XPSpecialGroup = true;
            // 
            // labelItem5
            // 
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Text = "Change Value From:";
            this.labelItem5.ThemeAware = true;
            // 
            // txtBatchReplaceFrom
            // 
            this.txtBatchReplaceFrom.Name = "txtBatchReplaceFrom";
            this.txtBatchReplaceFrom.ThemeAware = true;
            this.txtBatchReplaceFrom.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "To:";
            this.labelItem7.ThemeAware = true;
            // 
            // txtBatchReplaceTo
            // 
            this.txtBatchReplaceTo.Name = "txtBatchReplaceTo";
            this.txtBatchReplaceTo.ThemeAware = true;
            this.txtBatchReplaceTo.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem8
            // 
            this.labelItem8.ForeColor = System.Drawing.Color.Gray;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.Text = "(applies to currently opened files)";
            this.labelItem8.ThemeAware = true;
            // 
            // labelItem9
            // 
            this.labelItem9.Name = "labelItem9";
            this.labelItem9.Text = "_________________________________";
            this.labelItem9.ThemeAware = true;
            // 
            // btnExecuteBatchReplace
            // 
            this.btnExecuteBatchReplace.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExecuteBatchReplace.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnExecuteBatchReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteBatchReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.btnExecuteBatchReplace.HotFontUnderline = true;
            this.btnExecuteBatchReplace.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnExecuteBatchReplace.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnExecuteBatchReplace.Name = "btnExecuteBatchReplace";
            this.btnExecuteBatchReplace.Text = "Execute Batch";
            this.btnExecuteBatchReplace.Click += new System.EventHandler(this.btnExecuteBatchReplace_Click);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            superTabLinearGradientColorTable3.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Silver};
            superTabItemStateColorTable1.Background = superTabLinearGradientColorTable3;
            superTabColorStates1.Normal = superTabItemStateColorTable1;
            superTabItemColorTable1.Default = superTabColorStates1;
            superTabLinearGradientColorTable4.Colors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.WindowFrame,
        System.Drawing.Color.Empty};
            superTabItemStateColorTable2.Background = superTabLinearGradientColorTable4;
            superTabColorStates2.Normal = superTabItemStateColorTable2;
            superTabItemColorTable1.Left = superTabColorStates2;
            this.superTabItem1.TabColor = superTabItemColorTable1;
            this.superTabItem1.Text = "Batch";
            // 
            // statusHolder
            // 
            this.statusHolder.CanvasColor = System.Drawing.SystemColors.Control;
            this.statusHolder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.statusHolder.Controls.Add(this.statusStrip1);
            this.statusHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusHolder.Location = new System.Drawing.Point(0, 449);
            this.statusHolder.Name = "statusHolder";
            this.statusHolder.Size = new System.Drawing.Size(954, 24);
            // 
            // 
            // 
            this.statusHolder.Style.BackColor = System.Drawing.Color.Black;
            this.statusHolder.Style.BackColor2 = System.Drawing.SystemColors.WindowFrame;
            this.statusHolder.Style.BackColorGradientAngle = 90;
            this.statusHolder.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.statusHolder.Style.BorderBottomWidth = 1;
            this.statusHolder.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.statusHolder.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.statusHolder.Style.BorderLeftWidth = 1;
            this.statusHolder.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.statusHolder.Style.BorderRightWidth = 1;
            this.statusHolder.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.statusHolder.Style.BorderTopWidth = 1;
            this.statusHolder.Style.Class = "";
            this.statusHolder.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusHolder.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.statusHolder.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.statusHolder.StyleMouseDown.Class = "";
            this.statusHolder.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.statusHolder.StyleMouseOver.Class = "";
            this.statusHolder.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusHolder.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 7F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1,
            this.status,
            this.toolStripStatusLabel2,
            this.parsingMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(954, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDown = this.BF2M0dd3rMenu;
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = global::BF2_M0dd3r.Properties.Resources.appicon2;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(99, 20);
            this.toolStripDropDownButton1.Text = "BF2 Modder";
            // 
            // BF2M0dd3rMenu
            // 
            this.BF2M0dd3rMenu.BackColor = System.Drawing.Color.Transparent;
            this.BF2M0dd3rMenu.Font = new System.Drawing.Font("Verdana", 7F);
            this.BF2M0dd3rMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchToolStripMenuItem,
            this.toolStripSeparator19,
            this.pluginsToolStripMenuItem,
            this.toolStripSeparator21,
            this.applyModToolStripMenuItem,
            this.toolStripSeparator22,
            this.automaticLoginOnStartupToolStripMenuItem});
            this.BF2M0dd3rMenu.Name = "BF2M0dd3rMenu";
            this.BF2M0dd3rMenu.OwnerItem = this.toolStripDropDownButton1;
            this.BF2M0dd3rMenu.Size = new System.Drawing.Size(327, 110);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostLANBotServerToolStripMenuItem,
            this.playLANBotServerToolStripMenuItem});
            this.launchToolStripMenuItem.Image = global::BF2_M0dd3r.Properties.Resources.appicon2;
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.launchToolStripMenuItem.Text = "Launch Battlefield 2 (powered by BF2 Modder)";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.BtnLaunchClick);
            // 
            // hostLANBotServerToolStripMenuItem
            // 
            this.hostLANBotServerToolStripMenuItem.Image = global::BF2_M0dd3r.Properties.Resources.appicon2;
            this.hostLANBotServerToolStripMenuItem.Name = "hostLANBotServerToolStripMenuItem";
            this.hostLANBotServerToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.hostLANBotServerToolStripMenuItem.Text = "Host BF2 Modder LAN Server...";
            this.hostLANBotServerToolStripMenuItem.CheckedChanged += new System.EventHandler(this.chkd);
            this.hostLANBotServerToolStripMenuItem.Click += new System.EventHandler(this.hostLANBotServerToolStripMenuItem_Click);
            // 
            // playLANBotServerToolStripMenuItem
            // 
            this.playLANBotServerToolStripMenuItem.Image = global::BF2_M0dd3r.Properties.Resources.appicon2;
            this.playLANBotServerToolStripMenuItem.Name = "playLANBotServerToolStripMenuItem";
            this.playLANBotServerToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.playLANBotServerToolStripMenuItem.Text = "Join BF2 Modder LAN Server...";
            this.playLANBotServerToolStripMenuItem.CheckedChanged += new System.EventHandler(this.chkd);
            this.playLANBotServerToolStripMenuItem.Click += new System.EventHandler(this.playLANBotServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(323, 6);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Image = global::BF2_M0dd3r.Properties.Resources.compactflash;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins...";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(323, 6);
            // 
            // applyModToolStripMenuItem
            // 
            this.applyModToolStripMenuItem.Image = global::BF2_M0dd3r.Properties.Resources.applymod;
            this.applyModToolStripMenuItem.Name = "applyModToolStripMenuItem";
            this.applyModToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.applyModToolStripMenuItem.Text = "Apply Mod...";
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(323, 6);
            // 
            // automaticLoginOnStartupToolStripMenuItem
            // 
            this.automaticLoginOnStartupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("automaticLoginOnStartupToolStripMenuItem.Image")));
            this.automaticLoginOnStartupToolStripMenuItem.Name = "automaticLoginOnStartupToolStripMenuItem";
            this.automaticLoginOnStartupToolStripMenuItem.Size = new System.Drawing.Size(326, 22);
            this.automaticLoginOnStartupToolStripMenuItem.Text = "Auto-Login";
            this.automaticLoginOnStartupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.chkd);
            this.automaticLoginOnStartupToolStripMenuItem.Click += new System.EventHandler(this.automaticLoginOnStartupToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(73, 17);
            this.status.Text = "(Initializing)";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // parsingMessage
            // 
            this.parsingMessage.ForeColor = System.Drawing.Color.Cyan;
            this.parsingMessage.Name = "parsingMessage";
            this.parsingMessage.Size = new System.Drawing.Size(747, 17);
            this.parsingMessage.Spring = true;
            this.parsingMessage.Text = "parsing, please wait...";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.EnableQatPlacement = false;
            this.ribbonControl1.FadeEffect = false;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2,
            this.ribbonTabItem3,
            this.ribbonTabItem4});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Verdana", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMainMenu,
            this.btnSave,
            this.btnCloseFile,
            this.labelItem1,
            this.btnLoadArchive});
            this.ribbonControl1.Size = new System.Drawing.Size(954, 106);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.UseCustomizeDialog = false;
            this.ribbonControl1.UseExternalCustomization = true;
            this.ribbonControl1.DoubleClick += new System.EventHandler(this.ribbonControl1_DoubleClick);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar8);
            this.ribbonPanel1.Controls.Add(this.ribbonBar6);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(954, 48);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 4;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.Class = "";
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.saveCurrentMod,
            this.closeMod});
            this.ribbonBar7.Location = new System.Drawing.Point(768, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(160, 45);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 5;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.Class = "";
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.Class = "";
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // saveCurrentMod
            // 
            this.saveCurrentMod.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.saveCurrentMod.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.saveCurrentMod.Icon = ((System.Drawing.Icon)(resources.GetObject("saveCurrentMod.Icon")));
            this.saveCurrentMod.Name = "saveCurrentMod";
            this.saveCurrentMod.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftS);
            this.saveCurrentMod.SubItemsExpandWidth = 14;
            this.saveCurrentMod.Text = "Save Mod";
            this.saveCurrentMod.Click += new System.EventHandler(this.saveCurrentMod_Click);
            // 
            // closeMod
            // 
            this.closeMod.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.closeMod.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.closeMod.Icon = ((System.Drawing.Icon)(resources.GetObject("closeMod.Icon")));
            this.closeMod.Name = "closeMod";
            this.closeMod.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftW);
            this.closeMod.SubItemsExpandWidth = 14;
            this.closeMod.Text = "Close Mod";
            this.closeMod.Click += new System.EventHandler(this.closeMod_Click_1);
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundStyle.Class = "";
            this.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar8.ContainerControlProcessDialogKey = true;
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.saveCurFile,
            this.closeCurFile});
            this.ribbonBar8.Location = new System.Drawing.Point(542, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(226, 45);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar8.TabIndex = 4;
            // 
            // 
            // 
            this.ribbonBar8.TitleStyle.Class = "";
            this.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.TitleStyleMouseOver.Class = "";
            this.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // saveCurFile
            // 
            this.saveCurFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.saveCurFile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.saveCurFile.Image = global::BF2_M0dd3r.Properties.Resources.saveHS;
            this.saveCurFile.Name = "saveCurFile";
            this.saveCurFile.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.saveCurFile.SubItemsExpandWidth = 14;
            this.saveCurFile.Text = "Save Current File";
            this.saveCurFile.Click += new System.EventHandler(this.btnSaveFileEvent);
            // 
            // closeCurFile
            // 
            this.closeCurFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.closeCurFile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.closeCurFile.Icon = ((System.Drawing.Icon)(resources.GetObject("closeCurFile.Icon")));
            this.closeCurFile.Name = "closeCurFile";
            this.closeCurFile.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.closeCurFile.SubItemsExpandWidth = 14;
            this.closeCurFile.Text = "Close Current File";
            this.closeCurFile.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.Class = "";
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Controls.Add(this.btnClear);
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.refreshButton,
            this.labelItem6,
            this.txtFind,
            this.btnSearch,
            this.searchStyle});
            this.ribbonBar6.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(539, 45);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.Class = "";
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.Class = "";
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnClear.Location = new System.Drawing.Point(368, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(11, 20);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "X";
            this.btnClear.Click += new System.EventHandler(this.txtFindClear);
            // 
            // refreshButton
            // 
            this.refreshButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.refreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.refreshButton.Image = global::BF2_M0dd3r.Properties.Resources.refresh_new;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR);
            this.refreshButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnViewCommonClient,
            this.btnViewCommonServer,
            this.btnViewMenuClient,
            this.btnViewMenuServer,
            this.btnViewObjectsClient});
            this.refreshButton.SubItemsExpandWidth = 14;
            this.refreshButton.Text = "View <b>Objects_server.zip</b>";
            this.refreshButton.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            this.refreshButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refreshButton_MouseUp);
            // 
            // btnViewCommonClient
            // 
            this.btnViewCommonClient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnViewCommonClient.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnViewCommonClient.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCommonClient.Image")));
            this.btnViewCommonClient.Name = "btnViewCommonClient";
            this.btnViewCommonClient.Text = "View <b>Common_client.zip</b>";
            this.btnViewCommonClient.Click += new System.EventHandler(this.btnViewCommonClient_Click);
            // 
            // btnViewCommonServer
            // 
            this.btnViewCommonServer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnViewCommonServer.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnViewCommonServer.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCommonServer.Image")));
            this.btnViewCommonServer.Name = "btnViewCommonServer";
            this.btnViewCommonServer.Text = "View <b>Common_server.zip</b>";
            this.btnViewCommonServer.Click += new System.EventHandler(this.btnViewCommonServer_Click);
            // 
            // btnViewMenuClient
            // 
            this.btnViewMenuClient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnViewMenuClient.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnViewMenuClient.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMenuClient.Image")));
            this.btnViewMenuClient.Name = "btnViewMenuClient";
            this.btnViewMenuClient.Text = "View <b>Menu_Client.zip</b>";
            this.btnViewMenuClient.Click += new System.EventHandler(this.btnViewMenuClient_Click);
            // 
            // btnViewMenuServer
            // 
            this.btnViewMenuServer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnViewMenuServer.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnViewMenuServer.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMenuServer.Image")));
            this.btnViewMenuServer.Name = "btnViewMenuServer";
            this.btnViewMenuServer.Text = "View <b>Menu_server.zip</b>";
            this.btnViewMenuServer.Click += new System.EventHandler(this.btnViewMenuServer_Click);
            // 
            // btnViewObjectsClient
            // 
            this.btnViewObjectsClient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnViewObjectsClient.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnViewObjectsClient.Image = ((System.Drawing.Image)(resources.GetObject("btnViewObjectsClient.Image")));
            this.btnViewObjectsClient.Name = "btnViewObjectsClient";
            this.btnViewObjectsClient.Text = "View <b>Objects_client.zip</b>";
            this.btnViewObjectsClient.Click += new System.EventHandler(this.btnViewObjectsClient_Click);
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "|";
            // 
            // txtFind
            // 
            this.txtFind.Caption = "Type to search for something in the current file, or the archive";
            this.txtFind.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFind.Name = "txtFind";
            this.txtFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.txtFind.TextBoxWidth = 200;
            this.txtFind.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFindEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSearch.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSearch.Icon")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SubItemsExpandWidth = 14;
            this.btnSearch.Text = "Search...";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchStyle
            // 
            this.searchStyle.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.searchStyle.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.searchStyle.Icon = ((System.Drawing.Icon)(resources.GetObject("searchStyle.Icon")));
            this.searchStyle.Name = "searchStyle";
            this.searchStyle.SubItemsExpandWidth = 14;
            this.searchStyle.Text = "...in archive";
            this.searchStyle.Click += new System.EventHandler(this.searchStyle_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Controls.Add(this.ribbonBar1);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(954, 104);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.Class = "";
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.selectMod});
            this.ribbonBar4.Location = new System.Drawing.Point(155, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(121, 101);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.Class = "";
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.Class = "";
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // selectMod
            // 
            this.selectMod.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.selectMod.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.selectMod.Image = global::BF2_M0dd3r.Properties.Resources.Book_angleHS;
            this.selectMod.Name = "selectMod";
            this.selectMod.SubItemsExpandWidth = 14;
            this.selectMod.Text = "Select a Mod";
            this.selectMod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectMod_MouseUp);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem15});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(152, 101);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem15
            // 
            this.buttonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem15.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem15.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem15.Icon")));
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem15.Stretch = true;
            this.buttonItem15.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCreateNewMod,
            this.basedOnMenu});
            this.buttonItem15.SubItemsExpandWidth = 14;
            this.buttonItem15.Text = "Create New Mod...";
            this.buttonItem15.Click += new System.EventHandler(this.buttonItem15_Click);
            // 
            // btnCreateNewMod
            // 
            this.btnCreateNewMod.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCreateNewMod.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewMod.Image")));
            this.btnCreateNewMod.Name = "btnCreateNewMod";
            this.btnCreateNewMod.Text = "Create from Original";
            this.btnCreateNewMod.Click += new System.EventHandler(this.createFromOriginal);
            // 
            // basedOnMenu
            // 
            this.basedOnMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.basedOnMenu.Image = ((System.Drawing.Image)(resources.GetObject("basedOnMenu.Image")));
            this.basedOnMenu.Name = "basedOnMenu";
            this.basedOnMenu.Text = "Based On...";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.networkedMods);
            this.ribbonPanel3.Controls.Add(this.ribbonBar10);
            this.ribbonPanel3.Controls.Add(this.ribbonBar5);
            this.ribbonPanel3.Controls.Add(this.ribbonBar3);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(954, 48);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            this.ribbonPanel3.Click += new System.EventHandler(this.ribbonPanel3_Click);
            // 
            // networkedMods
            // 
            this.networkedMods.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.networkedMods.BackgroundMouseOverStyle.Class = "";
            this.networkedMods.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.networkedMods.BackgroundStyle.Class = "";
            this.networkedMods.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.networkedMods.ContainerControlProcessDialogKey = true;
            this.networkedMods.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkedMods.Location = new System.Drawing.Point(657, 0);
            this.networkedMods.Name = "networkedMods";
            this.networkedMods.Size = new System.Drawing.Size(217, 45);
            this.networkedMods.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.networkedMods.TabIndex = 4;
            this.networkedMods.Text = "Networked Mods";
            // 
            // 
            // 
            this.networkedMods.TitleStyle.Class = "";
            this.networkedMods.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.networkedMods.TitleStyleMouseOver.Class = "";
            this.networkedMods.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar10
            // 
            this.ribbonBar10.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundStyle.Class = "";
            this.ribbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar10.ContainerControlProcessDialogKey = true;
            this.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar10.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer5});
            this.ribbonBar10.Location = new System.Drawing.Point(293, 0);
            this.ribbonBar10.Name = "ribbonBar10";
            this.ribbonBar10.Size = new System.Drawing.Size(364, 45);
            this.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar10.TabIndex = 3;
            this.ribbonBar10.Text = "ribbonBar10";
            // 
            // 
            // 
            this.ribbonBar10.TitleStyle.Class = "";
            this.ribbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.TitleStyleMouseOver.Class = "";
            this.ribbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "";
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.MinimumSize = new System.Drawing.Size(200, 0);
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.txtComputerName,
            this.btnSearchNetwork});
            this.itemContainer5.Text = "LAN";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "Search Network:";
            // 
            // txtComputerName
            // 
            this.txtComputerName.ComboWidth = 200;
            this.txtComputerName.DropDownHeight = 106;
            this.txtComputerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtComputerName.ItemHeight = 13;
            this.txtComputerName.Name = "txtComputerName";
            // 
            // btnSearchNetwork
            // 
            this.btnSearchNetwork.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSearchNetwork.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSearchNetwork.Image = global::BF2_M0dd3r.Properties.Resources.search;
            this.btnSearchNetwork.Name = "btnSearchNetwork";
            this.btnSearchNetwork.Text = "Search...";
            this.btnSearchNetwork.Click += new System.EventHandler(this.btnSearchNetwork_Click);
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.Class = "";
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.myNetworkedModsToolStripMenuItem});
            this.ribbonBar5.Location = new System.Drawing.Point(131, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(162, 45);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 2;
            this.ribbonBar5.Text = "My Networked Mods";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.Class = "";
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.Class = "";
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ItemClick += new System.EventHandler(this.ribbonBar5_ItemClick);
            // 
            // myNetworkedModsToolStripMenuItem
            // 
            this.myNetworkedModsToolStripMenuItem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.myNetworkedModsToolStripMenuItem.Name = "myNetworkedModsToolStripMenuItem";
            this.myNetworkedModsToolStripMenuItem.SubItemsExpandWidth = 14;
            this.myNetworkedModsToolStripMenuItem.Text = "View My Networked Mods";
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.enableNetworkingToolStripMenuItem1});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(128, 45);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 0;
            this.ribbonBar3.Text = "Networking";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // enableNetworkingToolStripMenuItem1
            // 
            this.enableNetworkingToolStripMenuItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.enableNetworkingToolStripMenuItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.enableNetworkingToolStripMenuItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("enableNetworkingToolStripMenuItem1.Icon")));
            this.enableNetworkingToolStripMenuItem1.Name = "enableNetworkingToolStripMenuItem1";
            this.enableNetworkingToolStripMenuItem1.SubItemsExpandWidth = 14;
            this.enableNetworkingToolStripMenuItem1.Text = "Networking Enabled";
            this.enableNetworkingToolStripMenuItem1.Click += new System.EventHandler(this.enableNetworkingToolStripMenuItem1_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar9);
            this.ribbonPanel4.Controls.Add(this.ribbonBar2);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(954, 48);
            // 
            // 
            // 
            this.ribbonPanel4.Style.Class = "";
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.Class = "";
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.Class = "";
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 5;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = false;
            this.ribbonBar9.BackColor = System.Drawing.Color.Transparent;
            this.ribbonBar9.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundStyle.Class = "";
            this.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar9.ContainerControlProcessDialogKey = true;
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSendBugReport});
            this.ribbonBar9.Location = new System.Drawing.Point(281, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(114, 45);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar9.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyle.Class = "";
            this.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyleMouseOver.Class = "";
            this.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSendBugReport
            // 
            this.btnSendBugReport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSendBugReport.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSendBugReport.Icon = ((System.Drawing.Icon)(resources.GetObject("btnSendBugReport.Icon")));
            this.btnSendBugReport.Name = "btnSendBugReport";
            this.btnSendBugReport.SubItemsExpandWidth = 14;
            this.btnSendBugReport.Text = "Send Bug Report";
            this.btnSendBugReport.Click += new System.EventHandler(this.btnSendBugReport_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnParticipateProgram});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(278, 45);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnParticipateProgram
            // 
            this.btnParticipateProgram.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnParticipateProgram.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnParticipateProgram.Icon = ((System.Drawing.Icon)(resources.GetObject("btnParticipateProgram.Icon")));
            this.btnParticipateProgram.Name = "btnParticipateProgram";
            this.btnParticipateProgram.SubItemsExpandWidth = 14;
            this.btnParticipateProgram.Text = "Participate in the BF2 Modder Participation Program";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Current Mod";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Mods";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.SplitButton = true;
            this.ribbonTabItem3.Text = "Networking";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "Participation Program";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Image = global::BF2_M0dd3r.Properties.Resources.mainMenuIcon;
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.PulseSpeed = 1;
            this.btnMainMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCreateMo});
            this.btnMainMenu.Text = "   ";
            this.btnMainMenu.DoubleClick += new System.EventHandler(this.btnMainMenu_DoubleClick);
            // 
            // btnCreateMo
            // 
            this.btnCreateMo.Name = "btnCreateMo";
            this.btnCreateMo.Text = "Create New Mod...";
            // 
            // btnSave
            // 
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSave.Image = global::BF2_M0dd3r.Properties.Resources.saveHS;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Save File";
            this.btnSave.Click += new System.EventHandler(this.btnSaveFileEvent);
            // 
            // btnCloseFile
            // 
            this.btnCloseFile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnCloseFile.Icon = ((System.Drawing.Icon)(resources.GetObject("btnCloseFile.Icon")));
            this.btnCloseFile.Name = "btnCloseFile";
            this.btnCloseFile.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnCloseFile.Text = "Close File";
            this.btnCloseFile.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            // 
            // btnLoadArchive
            // 
            this.btnLoadArchive.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLoadArchive.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLoadArchive.Icon = ((System.Drawing.Icon)(resources.GetObject("btnLoadArchive.Icon")));
            this.btnLoadArchive.Name = "btnLoadArchive";
            this.btnLoadArchive.Text = "Load Archive...";
            this.btnLoadArchive.Click += new System.EventHandler(this.btnLoadArchiveClick);
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "tabItem2";
            // 
            // tabItem3
            // 
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "tabItem3";
            // 
            // timerChanged
            // 
            this.timerChanged.Enabled = true;
            this.timerChanged.Interval = 200;
            this.timerChanged.Tick += new System.EventHandler(this.TimerChangedTick);
            // 
            // posTimer
            // 
            this.posTimer.Enabled = true;
            this.posTimer.Tick += new System.EventHandler(this.PosTimerTick);
            // 
            // stat
            // 
            this.stat.Interval = 7500;
            this.stat.Tick += new System.EventHandler(this.stat_Tick);
            // 
            // editChanged
            // 
            this.editChanged.Enabled = true;
            this.editChanged.Tick += new System.EventHandler(this.editChanged_Tick_1);
            // 
            // tool
            // 
            this.tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tool.ToolTipTitle = "BF2 M0dd3r Help3r";
            // 
            // modMenu
            // 
            this.modMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.deleteM0dToolStripMenuItem});
            this.modMenu.Name = "modMenu";
            this.modMenu.Size = new System.Drawing.Size(196, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportToolStripMenuItem.Text = "&Export to Shared M0ds...";
            // 
            // deleteM0dToolStripMenuItem
            // 
            this.deleteM0dToolStripMenuItem.Name = "deleteM0dToolStripMenuItem";
            this.deleteM0dToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteM0dToolStripMenuItem.Text = "&Delete M0d";
            // 
            // parsingTimer
            // 
            this.parsingTimer.Tick += new System.EventHandler(this.parsingTimer_Tick);
            // 
            // directoryCreator
            // 
            this.directoryCreator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.copyTheDir);
            // 
            // pluginsTimer
            // 
            this.pluginsTimer.Enabled = true;
            this.pluginsTimer.Interval = 200;
            this.pluginsTimer.Tick += new System.EventHandler(this.pluginsTimer_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem1.Icon")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "About BF2 M0dd3r";
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "|";
            // 
            // registerProductToolStripMenuItem
            // 
            this.registerProductToolStripMenuItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.registerProductToolStripMenuItem.Icon = ((System.Drawing.Icon)(resources.GetObject("registerProductToolStripMenuItem.Icon")));
            this.registerProductToolStripMenuItem.Name = "registerProductToolStripMenuItem";
            this.registerProductToolStripMenuItem.SubItemsExpandWidth = 14;
            this.registerProductToolStripMenuItem.Text = "Help make BF2 M0dd3r Better";
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "|";
            // 
            // buttonItem8
            // 
            this.buttonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem8.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem8.Icon")));
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.SubItemsExpandWidth = 14;
            this.buttonItem8.Text = "Get Help";
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // b
            // 
            this.b.CaptionIcon = ((System.Drawing.Icon)(resources.GetObject("b.CaptionIcon")));
            this.b.ShowCloseButton = false;
            this.b.Style = DevComponents.DotNetBar.eBallonStyle.Alert;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Column";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Column";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Column";
            this.columnHeader3.Width.Absolute = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Column";
            this.columnHeader4.Width.Absolute = 150;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(0, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(100, 96);
            this.code.TabIndex = 0;
            this.code.Text = "";
            // 
            // BF2Modder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(954, 473);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 7F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BF2Modder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF2 Modder";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.contextIcon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.leftBar.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.svHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sv)).EndInit();
            this.fileHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            this.file.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabs)).EndInit();
            this.tabs.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlBatchTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
            this.statusHolder.ResumeLayout(false);
            this.statusHolder.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.BF2M0dd3rMenu.ResumeLayout(false);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonBar6.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.modMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnLaunch;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ContextMenuStrip contextIcon;
        private System.Windows.Forms.Timer posTimer;
        private System.Windows.Forms.Timer timerChanged;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon ni;
        private System.Windows.Forms.FolderBrowserDialog cd;
        private SyntaxHighlighter.SyntaxRichTextBox code;
        private System.Windows.Forms.Timer stat;
        private System.Windows.Forms.ToolStripMenuItem createNewModToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.Timer editChanged;
        private System.Windows.Forms.ToolTip tool;
        private System.Windows.Forms.ContextMenuStrip modMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteM0dToolStripMenuItem;
        private System.Windows.Forms.Timer parsingTimer;
        private System.ComponentModel.BackgroundWorker directoryCreator;
        private System.Windows.Forms.Timer pluginsTimer;
        private System.Windows.Forms.ContextMenuStrip BF2M0dd3rMenu;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem applyModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostLANBotServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playLANBotServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem automaticLoginOnStartupToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.ButtonItem btnSaveFile;
        private DevComponents.DotNetBar.ButtonItem btnCloseFile;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem btnLoadArchive;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnCreateNewMod;
        private DevComponents.DotNetBar.ButtonItem basedOnMenu;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.ButtonItem registerProductToolStripMenuItem;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem enableNetworkingToolStripMenuItem1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel statusHolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevComponents.DotNetBar.PanelEx mainContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem selectMod;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem myNetworkedModsToolStripMenuItem;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.ButtonItem searchStyle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel parsingMessage;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel leftBar;
        private DevComponents.DotNetBar.TabControl tabs;
        private DevComponents.DotNetBar.ButtonItem refreshButton;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem closeMod;
        private DevComponents.DotNetBar.RibbonBar ribbonBar8;
        private DevComponents.DotNetBar.ButtonItem saveCurFile;
        private DevComponents.DotNetBar.ButtonItem closeCurFile;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.ButtonItem saveCurrentMod;
        private DevComponents.DotNetBar.ButtonItem btnViewCommonClient;
        private DevComponents.DotNetBar.ButtonItem btnViewCommonServer;
        private DevComponents.DotNetBar.ButtonItem btnViewMenuClient;
        private DevComponents.DotNetBar.ButtonItem btnViewMenuServer;
        private DevComponents.DotNetBar.ButtonItem btnViewObjectsClient;
        private DevComponents.DotNetBar.BalloonTip b;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.TextBoxItem txtFind;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnParticipateProgram;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonItem btnSendBugReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBar10;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ComboBoxItem txtComputerName;
        private DevComponents.DotNetBar.ButtonItem btnSearchNetwork;
        private DevComponents.DotNetBar.RibbonBar networkedMods;
        private DevComponents.DotNetBar.ButtonItem btnMainMenu;
        private DevComponents.DotNetBar.ButtonItem btnCreateMo;
        private DevComponents.DotNetBar.PanelEx pnlBatchTools;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ExpandablePanel svHolder;
        private DevComponents.DotNetBar.ButtonX btnRefreshServerSettings;
        private DevComponents.DotNetBar.ButtonX btnApplyServerSettings;
        private DevComponents.DotNetBar.AdvPropertyGrid sv;
        private DevComponents.DotNetBar.ExpandablePanel fileHolder;
        private DevComponents.DotNetBar.ButtonX btnCloseModHeirarchy;
        private DevComponents.AdvTree.AdvTree file;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem fileContext;
        private DevComponents.DotNetBar.ButtonItem editCurrentItem;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem btnAddNewDir;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ExplorerBar explorerBar1;
        private DevComponents.DotNetBar.ExplorerBarGroupItem explorerBarGroupItem1;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.TextBoxItem txtBatchReplaceFrom;
        private DevComponents.DotNetBar.ButtonItem btnExecuteBatchReplace;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.TextBoxItem txtBatchReplaceTo;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.LabelItem labelItem9;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.Slider slider1;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.ColumnHeader columnHeader3;
        private DevComponents.AdvTree.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btnRevertToOriginal;
        private DevComponents.DotNetBar.ButtonX btnRevertChanges;
        private DevComponents.DotNetBar.ButtonX btnRedo;
        private DevComponents.DotNetBar.ButtonX btnUndo;
	}
}
