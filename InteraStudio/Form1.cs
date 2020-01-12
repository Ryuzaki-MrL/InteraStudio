using System;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public partial class Form1 : Form
    {
        private InteraFile project = new InteraFile();
        private Point mouse;
        private Control ctxSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StoryboardAddScene(string videoFile)
        {
            SceneNode n = project.scene.CreateScene();
            n.value.videoFile = videoFile;

            PictureBox p = new PictureBox();
            p.Visible = true;
            p.Size = new Size(150, 96);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.MouseDown += thumbnail_MouseDown;
            p.MouseMove += thumbnail_MouseMove;
            p.MouseDoubleClick += thumbnail_DoubleClick;
            p.ContextMenuStrip = contextMenuCena;

            Label l = new Label();
            n.value.title = l.Text = "Cena " + n.id;
            p.Controls.Add(l);

            p.Tag = n.id; // for convenience
            storyboardBox.Controls.Add(p);
            n.value.thumbnail = p;
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

        private void thumbnail_DoubleClick(object sender, EventArgs e)
        {
            Control thumbnail = (Control)sender;
            FormSceneProperties p = new FormSceneProperties(project.scene.nodes[(int)thumbnail.Tag].value);
            p.ShowDialog();
        }

        private void carregarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileProject.ShowDialog() == DialogResult.OK)
            {
                storyboardBox.Controls.Clear();
                project = new InteraFile(openFileProject.FileName);
            }
        }

        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: GroupBox do storyboard pode ser gerenciada por outra classe
            storyboardBox.Controls.Clear();
            project = new InteraFile();
        }

        private void importarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileVideo.ShowDialog() == DialogResult.OK)
            {
                StoryboardAddScene(openFileVideo.FileName);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: ask for confirmation
            Close();
        }

        private void contextMenuCena_Opened(object sender, EventArgs e)
        {
            ctxSource = contextMenuCena.SourceControl;
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSceneProperties p = new FormSceneProperties(project.scene.nodes[(int)ctxSource.Tag].value);
            p.ShowDialog();
        }

        private void novaCenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoryboardAddScene("");
        }
    }
}
