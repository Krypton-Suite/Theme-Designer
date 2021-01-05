using Krypton.Toolkit;
using System;

namespace ThemeDesigner.UX
{
    public class MainWindow : KryptonForm
    {
        #region Design Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.StatusStrip ss;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private KryptonPanel kryptonPanel2;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton1;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton2;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton3;
        private Krypton.Ribbon.KryptonRibbonTab krtHome;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbNew;
        private Krypton.Ribbon.KryptonRibbonGroupButton kgbtnSave;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbtnOpen;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbCut;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbCopy;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbPaste;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbUndo;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbRedo;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private Krypton.Ribbon.KryptonRibbonGroupLabel kryptonRibbonGroupLabel1;
        private Krypton.Ribbon.KryptonRibbonGroupComboBox kryptonRibbonGroupComboBox1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbColours;
        private System.Windows.Forms.ContextMenuStrip cmsColours;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem getColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateContrastColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem invertColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem resetColoursToolStripMenuItem;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgViewPaletteFile;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator3;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbShowColourInformation;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator4;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private Krypton.Ribbon.KryptonRibbonGroupButton krgbShowPaletteProperties;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup6;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton8;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton9;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton10;
        private System.Windows.Forms.ToolStripMenuItem automaticUpdateToolStripMenuItem;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonQATButton1 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonRibbonQATButton2 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonRibbonQATButton3 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.krtHome = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbNew = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kgbtnSave = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbtnOpen = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCut = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbCopy = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbPaste = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUndo = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbRedo = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupLabel1 = new Krypton.Ribbon.KryptonRibbonGroupLabel();
            this.kryptonRibbonGroupComboBox1 = new Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.kryptonRibbonGroup4 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines2 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup5 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbColours = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.cmsColours = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.generateContrastColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.invertColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.updateColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.resetColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonRibbonGroupSeparator2 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgViewPaletteFile = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator3 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple6 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowColourInformation = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab3 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            this.kryptonRibbonGroupSeparator4 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple7 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowPaletteProperties = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup6 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple8 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton8 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton9 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton10 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.automaticUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.cmsColours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 711);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1373, 22);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1373, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.kryptonRibbonQATButton1,
            this.kryptonRibbonQATButton2,
            this.kryptonRibbonQATButton3});
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.krtHome,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab2;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1373, 115);
            this.kryptonRibbon1.TabIndex = 1;
            // 
            // krtHome
            // 
            this.krtHome.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup4});
            this.krtHome.Text = "Home";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbNew,
            this.kgbtnSave,
            this.krgbtnOpen});
            // 
            // krgbNew
            // 
            this.krgbNew.ImageLarge = global::ThemeDesigner.Properties.Resources.New_File_32_x_32;
            this.krgbNew.TextLine1 = "New";
            this.krgbNew.Click += new System.EventHandler(this.krgbNew_Click);
            // 
            // kgbtnSave
            // 
            this.kgbtnSave.ImageLarge = global::ThemeDesigner.Properties.Resources.Hard_Drive_v1_32_x_32;
            this.kgbtnSave.TextLine1 = "Save";
            this.kgbtnSave.Click += new System.EventHandler(this.kgbtnSave_Click);
            // 
            // krgbtnOpen
            // 
            this.krgbtnOpen.ImageLarge = global::ThemeDesigner.Properties.Resources.Open_File_32_x_32;
            this.krgbtnOpen.TextLine1 = "Open";
            this.krgbtnOpen.Click += new System.EventHandler(this.krgbtnOpen_Click);
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple3});
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCut,
            this.krgbCopy,
            this.krgbPaste});
            // 
            // krgbCut
            // 
            this.krgbCut.ImageLarge = global::ThemeDesigner.Properties.Resources.Cut_32_x_32;
            this.krgbCut.TextLine1 = "Cut";
            this.krgbCut.Click += new System.EventHandler(this.krgbPaletteProperties_Click);
            // 
            // krgbCopy
            // 
            this.krgbCopy.ImageLarge = global::ThemeDesigner.Properties.Resources.Copy_32_x_32;
            this.krgbCopy.TextLine1 = "Copy";
            // 
            // krgbPaste
            // 
            this.krgbPaste.ImageLarge = global::ThemeDesigner.Properties.Resources.Paste_32_x_32;
            this.krgbPaste.TextLine1 = "Paste";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbUndo,
            this.krgbRedo});
            // 
            // krgbUndo
            // 
            this.krgbUndo.Enabled = false;
            this.krgbUndo.ImageLarge = global::ThemeDesigner.Properties.Resources.Paste_16_x_16;
            this.krgbUndo.TextLine1 = "Undo";
            // 
            // krgbRedo
            // 
            this.krgbRedo.Enabled = false;
            this.krgbRedo.TextLine1 = "Redo";
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupLabel1,
            this.kryptonRibbonGroupComboBox1});
            // 
            // kryptonRibbonGroupComboBox1
            // 
            this.kryptonRibbonGroupComboBox1.DropDownWidth = 121;
            this.kryptonRibbonGroupComboBox1.FormattingEnabled = false;
            this.kryptonRibbonGroupComboBox1.ItemHeight = 15;
            this.kryptonRibbonGroupComboBox1.Text = "";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines2});
            // 
            // kryptonRibbonGroupLines2
            // 
            this.kryptonRibbonGroupLines2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2});
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup5,
            this.kryptonRibbonGroup6});
            this.kryptonRibbonTab2.Text = "&Options";
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4,
            this.kryptonRibbonGroupSeparator2,
            this.kryptonRibbonGroupTriple5,
            this.kryptonRibbonGroupSeparator3,
            this.kryptonRibbonGroupTriple6,
            this.kryptonRibbonGroupSeparator4,
            this.kryptonRibbonGroupTriple7});
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbColours});
            // 
            // krgbColours
            // 
            this.krgbColours.ButtonType = Krypton.Ribbon.GroupButtonType.Split;
            this.krgbColours.ContextMenuStrip = this.cmsColours;
            this.krgbColours.ImageLarge = global::ThemeDesigner.Properties.Resources.Generate_Colours_32_x_32;
            this.krgbColours.ImageSmall = global::ThemeDesigner.Properties.Resources.Generate_Colours_16_x_16;
            this.krgbColours.TextLine1 = "Generate";
            this.krgbColours.TextLine2 = "Colours";
            this.krgbColours.Click += new System.EventHandler(this.krgbColours_Click);
            // 
            // cmsColours
            // 
            this.cmsColours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsColours.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getColoursToolStripMenuItem,
            this.toolStripMenuItem1,
            this.generateContrastColoursToolStripMenuItem,
            this.toolStripMenuItem2,
            this.invertColoursToolStripMenuItem,
            this.toolStripMenuItem3,
            this.updateColoursToolStripMenuItem,
            this.toolStripMenuItem4,
            this.resetColoursToolStripMenuItem});
            this.cmsColours.Name = "cmsColours";
            this.cmsColours.Size = new System.Drawing.Size(214, 160);
            // 
            // getColoursToolStripMenuItem
            // 
            this.getColoursToolStripMenuItem.Image = global::ThemeDesigner.Properties.Resources.Colour_Wheel_32_x_32;
            this.getColoursToolStripMenuItem.Name = "getColoursToolStripMenuItem";
            this.getColoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.getColoursToolStripMenuItem.Text = "Get &Colours";
            this.getColoursToolStripMenuItem.Click += new System.EventHandler(this.getColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // generateContrastColoursToolStripMenuItem
            // 
            this.generateContrastColoursToolStripMenuItem.Image = global::ThemeDesigner.Properties.Resources.Generic_Colour_Icon_32_x_32;
            this.generateContrastColoursToolStripMenuItem.Name = "generateContrastColoursToolStripMenuItem";
            this.generateContrastColoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.generateContrastColoursToolStripMenuItem.Text = "Generate Contrast C&olours";
            this.generateContrastColoursToolStripMenuItem.Click += new System.EventHandler(this.generateContrastColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // invertColoursToolStripMenuItem
            // 
            this.invertColoursToolStripMenuItem.Image = global::ThemeDesigner.Properties.Resources.Invert_Colours_v1_32_x_32;
            this.invertColoursToolStripMenuItem.Name = "invertColoursToolStripMenuItem";
            this.invertColoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.invertColoursToolStripMenuItem.Text = "&Invert Colours";
            this.invertColoursToolStripMenuItem.Click += new System.EventHandler(this.invertColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
            // 
            // updateColoursToolStripMenuItem
            // 
            this.updateColoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticUpdateToolStripMenuItem});
            this.updateColoursToolStripMenuItem.Image = global::ThemeDesigner.Properties.Resources.Refresh_32_x_32;
            this.updateColoursToolStripMenuItem.Name = "updateColoursToolStripMenuItem";
            this.updateColoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.updateColoursToolStripMenuItem.Text = "&Update Colours";
            this.updateColoursToolStripMenuItem.Click += new System.EventHandler(this.updateColoursToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 6);
            // 
            // resetColoursToolStripMenuItem
            // 
            this.resetColoursToolStripMenuItem.Image = global::ThemeDesigner.Properties.Resources.Reset_32_x_32;
            this.resetColoursToolStripMenuItem.Name = "resetColoursToolStripMenuItem";
            this.resetColoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.resetColoursToolStripMenuItem.Text = "Re&set Colours";
            this.resetColoursToolStripMenuItem.Click += new System.EventHandler(this.resetColoursToolStripMenuItem_Click);
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgViewPaletteFile});
            // 
            // krgViewPaletteFile
            // 
            this.krgViewPaletteFile.TextLine1 = "View Palette";
            this.krgViewPaletteFile.TextLine2 = "File";
            this.krgViewPaletteFile.Click += new System.EventHandler(this.krgViewPaletteFile_Click);
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbShowColourInformation});
            // 
            // krgbShowColourInformation
            // 
            this.krgbShowColourInformation.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowColourInformation.TextLine1 = "Show Colour";
            this.krgbShowColourInformation.TextLine2 = "Information";
            this.krgbShowColourInformation.Click += new System.EventHandler(this.krgbShowColourInformation_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1373, 596);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(1373, 596);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1371, 569);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "7f5a8dda66c24a1d914bce139e43d9f0";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "8072fbe739e3448c8b5a59acde911744";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbShowPaletteProperties});
            // 
            // krgbShowPaletteProperties
            // 
            this.krgbShowPaletteProperties.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowPaletteProperties.ImageLarge = global::ThemeDesigner.Properties.Resources.Property_32_x_32;
            this.krgbShowPaletteProperties.ImageSmall = global::ThemeDesigner.Properties.Resources.Property_16_x_16;
            this.krgbShowPaletteProperties.TextLine1 = "Show Palette";
            this.krgbShowPaletteProperties.TextLine2 = "Properties";
            this.krgbShowPaletteProperties.Click += new System.EventHandler(this.krgbShowPaletteProperties_Click);
            // 
            // kryptonRibbonGroup6
            // 
            this.kryptonRibbonGroup6.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple8});
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton8,
            this.kryptonRibbonGroupButton9,
            this.kryptonRibbonGroupButton10});
            // 
            // automaticUpdateToolStripMenuItem
            // 
            this.automaticUpdateToolStripMenuItem.CheckOnClick = true;
            this.automaticUpdateToolStripMenuItem.Name = "automaticUpdateToolStripMenuItem";
            this.automaticUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.automaticUpdateToolStripMenuItem.Text = "&Automatic Update";
            this.automaticUpdateToolStripMenuItem.Click += new System.EventHandler(this.automaticUpdateToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1373, 733);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonRibbon1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Theme Designer";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.cmsColours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        private static KryptonPalette _palette = null;
        #endregion

        #region Properties
        public static KryptonPalette Palette { get => _palette; set => _palette = value; }
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            // Test
            Palette = new KryptonPalette();
        }
        #endregion

        private void krgbPaletteProperties_Click(object sender, EventArgs e)
        {
            PropertiesWindow propertiesWindow = new PropertiesWindow(Palette);

            propertiesWindow.Show();
        }

        private void krgViewPaletteFile_Click(object sender, EventArgs e)
        {
            XMLFileViewerWindow viewerWindow = new XMLFileViewerWindow(Palette.GetCustomisedKryptonPaletteFilePath());

            viewerWindow.Show();
        }

        private void kgbtnSave_Click(object sender, EventArgs e)
        {

        }

        private void krgbNew_Click(object sender, EventArgs e)
        {

        }

        private void krgbtnOpen_Click(object sender, EventArgs e)
        {

        }

        private void krgbColours_Click(object sender, EventArgs e)
        {

        }

        private void krgbShowPaletteProperties_Click(object sender, EventArgs e)
        {

        }

        private void krgbShowColourInformation_Click(object sender, EventArgs e)
        {

        }

        private void getColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateContrastColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invertColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void automaticUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}