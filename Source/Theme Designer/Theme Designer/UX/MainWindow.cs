using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeDesigner.UX
{
    public class MainWindow : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private KryptonPanel kryptonPanel2;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton1;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton2;
        private Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton3;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonQATButton1 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonRibbonQATButton2 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonRibbonQATButton3 = new Krypton.Ribbon.KryptonRibbonQATButton();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab3 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.statusStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 711);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1373, 22);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1373, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1373, 115);
            this.kryptonRibbon1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}