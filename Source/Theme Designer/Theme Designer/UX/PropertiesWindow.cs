using Krypton.Toolkit;
using Krypton.Toolkit.Extended.Base;

namespace ThemeDesigner
{
    public class PropertiesWindow : KryptonForm
    {
        #region Design Code
        private Krypton.Toolkit.Extended.Base.KryptonPropertyGrid kpg;

        private void InitializeComponent()
        {
            this.kpg = new Krypton.Toolkit.Extended.Base.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpg
            // 
            this.kpg.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpg.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpg.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpg.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpg.Location = new System.Drawing.Point(0, 0);
            this.kpg.Name = "kpg";
            this.kpg.Size = new System.Drawing.Size(400, 561);
            this.kpg.TabIndex = 0;
            // 
            // PropertiesWindow
            // 
            this.ClientSize = new System.Drawing.Size(400, 561);
            this.Controls.Add(this.kpg);
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
        public KryptonPropertyGrid PropertyGrid { get => kpg; }
        #endregion

        #region Constructors
        public PropertiesWindow()
        {
            InitializeComponent();
        }

        public PropertiesWindow(object control)
        {
            InitializeComponent();

            PropertyGrid.SelectedObject = control;
        }
        #endregion
    }
}