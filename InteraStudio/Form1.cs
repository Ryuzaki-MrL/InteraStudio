using System;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public partial class Form1 : Form
    {
        private InteraFile project = new InteraFile();
        private Point mouse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thumbnail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse = e.Location;
            }
        }

        private void thumbnail_MouseMove(object sender, MouseEventArgs e)
        {
            Control p = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                p.Left = e.X + p.Left - mouse.X;
                p.Top = e.Y + p.Top - mouse.Y;
            }
        }

        private void carregarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileProject.ShowDialog() == DialogResult.OK)
            {
                project = new InteraFile(openFileProject.FileName);
            }
        }

        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project = new InteraFile();
            storyboardBox.Controls.Clear();
            // TODO: GroupBox do storyboard pode ser gerenciada por outra classe
        }

        private void importarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileVideo.ShowDialog() == DialogResult.OK)
            {
                SceneNode n = project.scene.CreateScene();
                n.value.videoFile = openFileVideo.FileName;

                PictureBox p = new PictureBox();
                p.Visible = true;
                p.Size = new Size(160, 96);
                p.BorderStyle = BorderStyle.FixedSingle;
                p.MouseDown += thumbnail_MouseDown;
                p.MouseMove += thumbnail_MouseMove;

                Label l = new Label();
                l.Text = "Cena " + n.id;
                p.Controls.Add(l);

                p.Tag = n.id; // for convenience
                storyboardBox.Controls.Add(p);
                n.value.thumbnail = p;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: ask for confirmation
            Close();
        }
    }
}
