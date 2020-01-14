using System;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public partial class Form1 : Form
    {
        private InteraFile project = new InteraFile();
        private Control ctxSource;

        public Form1()
        {
            InitializeComponent();

            project.storyboard = new Storyboard(storyboardBox, contextMenuCena);
            storyboardBox.AllowDrop = true;

            subTT_0.Tag = TransitionID.Automatic;
            subTT_1.Tag = TransitionID.Keyboard;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carregarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileProject.ShowDialog() == DialogResult.OK)
            {
                project = new InteraFile();
                project.storyboard = new Storyboard(storyboardBox, contextMenuCena);
                project.Load(openFileProject.FileName);
            }
        }

        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project = new InteraFile();
            project.storyboard = new Storyboard(storyboardBox, contextMenuCena);
        }

        private void importarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileVideo.ShowDialog() == DialogResult.OK)
            {
                project.storyboard.CreateScene(openFileVideo.FileName);
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
            FormSceneProperties p = new FormSceneProperties(project.storyboard.GetScene((int)ctxSource.Tag));
            p.ShowDialog();
        }

        private void novaCenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.storyboard.CreateScene();
        }

        private void storyboardBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string fname in files)
            {
                project.storyboard.CreateScene(fname);
            }
        }

        private void storyboardBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void novaTransiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem option = (ToolStripMenuItem)sender;
            project.storyboard.SetNewTransition((int)ctxSource.Tag, (TransitionID)option.Tag);
        }

        private void storyboardBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);

            ScenePart first = project.storyboard.firstScene;
            if (first != null)
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(first.thumbnail.Location, first.thumbnail.Size));
            }

            pen = new Pen(Color.Black, 3);

            foreach (PictureBox pbox in storyboardBox.Controls)
            {
                foreach (SceneTransition t in project.storyboard.GetScene((int)pbox.Tag).transitions)
                {
                    //e.Graphics.DrawLines(pen, t.arrowPath.ToArray());

                    PictureBox tp = t.nextScene.thumbnail;

                    Point p1 = new Point(
                        (pbox.Left + pbox.Right) / 2,
                        (pbox.Top + pbox.Bottom) / 2
                    );

                    Point p2 = new Point(
                        (tp.Left + tp.Right) / 2,
                        (tp.Top + tp.Bottom) / 2
                    );

                    if (pbox.Tag == tp.Tag)
                    {
                        e.Graphics.DrawEllipse(pen, new Rectangle(new Point(pbox.Left - 32, pbox.Top - 32), new Size(64, 64)));
                    }
                    else
                    {
                        e.Graphics.DrawLine(pen, p1, p2);
                    }
                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (project.fname.Equals(String.Empty))
            {
                if (saveFileProject.ShowDialog() == DialogResult.OK)
                {
                    project.fname = saveFileProject.FileName;
                    project.Save();
                }
            }
            else
            {
                project.Save();
            }
        }

        private void primeiraCenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.storyboard.SetAsFirstScene((int)ctxSource.Tag);
        }

        private void textBoxProjTitle_TextChanged(object sender, EventArgs e)
        {
            project.title = textBoxProjTitle.Text;
        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            project.author = textBoxAuthor.Text;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            storyboardBox.Invalidate();
        }
    }
}
