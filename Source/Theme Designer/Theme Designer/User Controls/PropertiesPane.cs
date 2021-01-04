using System.Windows.Forms;

namespace ThemeDesigner
{
    public class PropertiesPane : UserControl
    {
        private Krypton.Toolkit.Suite.Extended.Base.KryptonPropertyGrid kpgPaletteProperties;

        private void InitializeComponent()
        {
            this.kpgPaletteProperties = new Krypton.Toolkit.Suite.Extended.Base.KryptonPropertyGrid();
            this.SuspendLayout();
            // 
            // kpgPaletteProperties
            // 
            this.kpgPaletteProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPaletteProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgPaletteProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgPaletteProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgPaletteProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgPaletteProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgPaletteProperties.Name = "kpgPaletteProperties";
            this.kpgPaletteProperties.Size = new System.Drawing.Size(341, 1000);
            this.kpgPaletteProperties.TabIndex = 0;
            // 
            // PropertiesPane
            // 
            this.Controls.Add(this.kpgPaletteProperties);
            this.Name = "PropertiesPane";
            this.Size = new System.Drawing.Size(341, 1000);
            this.ResumeLayout(false);

        }
    }
}