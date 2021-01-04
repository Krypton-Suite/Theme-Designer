using Krypton.Toolkit;
using Krypton.Toolkit.Suite.Extended.Base;

namespace ThemeDesigner
{
    public class PropertiesWindow : KryptonForm
    {
        #region Design Code
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PropertiesWindow
            // 
            this.ClientSize = new System.Drawing.Size(400, 561);
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
        //public KryptonPropertyGrid PropertyGrid { get => kpg; }
        #endregion

        #region Constructors
        public PropertiesWindow()
        {
            InitializeComponent();
        }

        public PropertiesWindow(object control)
        {
            InitializeComponent();

            //PropertyGrid.SelectedObject = control;
        }
        #endregion
    }
}