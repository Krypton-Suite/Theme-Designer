using Krypton.Toolkit;
using Krypton.Toolkit.Suite.Extended.Base;

namespace ThemeDesigner
{
    public class PropertiesWindow : KryptonForm
    {
        private KryptonPropertyGrid kpgPalette;
        #region Design Code
        private void InitializeComponent()
        {
            this.kpgPalette = new Krypton.Toolkit.Suite.Extended.Base.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpgPalette
            // 
            this.kpgPalette.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgPalette.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgPalette.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPalette.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgPalette.Location = new System.Drawing.Point(0, 0);
            this.kpgPalette.Name = "kpgPalette";
            this.kpgPalette.Size = new System.Drawing.Size(400, 561);
            this.kpgPalette.TabIndex = 0;
            // 
            // PropertiesWindow
            // 
            this.ClientSize = new System.Drawing.Size(400, 561);
            this.Controls.Add(this.kpgPalette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PropertiesWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Palette Properties";
            this.ResumeLayout(false);

        }
        #endregion

        #region Properties
        public KryptonPropertyGrid PropertyGrid { get => kpgPalette; }
        #endregion

        #region Constructors
        public PropertiesWindow()
        {
            InitializeComponent();
        }

        public PropertiesWindow(KryptonPalette palette)
        {
            InitializeComponent();

            PropertyGrid.SelectedObject = palette;
        }
        #endregion
    }
}