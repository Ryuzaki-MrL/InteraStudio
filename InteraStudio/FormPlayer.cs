using System.Windows.Forms;
using System.IO;

namespace InteraStudio
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
            vlcControl1.VlcLibDirectory = new DirectoryInfo("libvlc");
        }

        public void Start(ScenePart first)
        {

        }

        public void FullScreen()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void Windowed()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }
    }
}
