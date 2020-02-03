using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

            project.storyboard = new Storyboard(storyboardPanel, contextMenuCena);
            storyboardBox.AllowDrop = true;

            subTT_0.Tag = TransitionID.Automatic;
            subTT_1.Tag = TransitionID.Keyboard;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WindowText(string fname)
        {
            this.Text = fname + " - InteraStudio";
        }

        private void carregarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileProject.ShowDialog() == DialogResult.OK)
            {
                project = new InteraFile();
                project.storyboard = new Storyboard(storyboardPanel, contextMenuCena);
                project.Load(openFileProject.FileName);
                WindowText(Path.GetFileName(project.fname));
            }
        }

        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project = new InteraFile();
            project.storyboard = new Storyboard(storyboardPanel, contextMenuCena);
            WindowText("*Novo Projeto");
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
            storyboardPanel.Invalidate();
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

        private void DrawSceneBorder(Pen p, ScenePart scene, Graphics g)
        {
            if (scene != null)
            {
                g.DrawRectangle(p, new Rectangle(scene.thumbnail.Location, scene.thumbnail.Size));
            }
        }

        private void storyboardBox_Paint(object sender, PaintEventArgs e)
        {
            DrawSceneBorder(new Pen(Color.Blue, 3), project.storyboard.selected, e.Graphics);
            DrawSceneBorder(new Pen(Color.Red, 2), project.storyboard.firstScene, e.Graphics);

            Pen pen = new Pen(Color.Black, 3);

            foreach (PictureBox pbox in storyboardPanel.Controls)
            {
                foreach (SceneTransition t in project.storyboard.GetScene((int)pbox.Tag).transitions)
                {
                    PictureBox tp = t.nextScene.thumbnail;

                    if (pbox.Tag == tp.Tag)
                    {
                        e.Graphics.DrawEllipse(pen, new Rectangle(new Point(pbox.Right - 32, pbox.Top - 32), new Size(64, 64)));
                    }
                    else
                    {
                        Point p1 = new Point(
                            (pbox.Left + pbox.Right) / 2,
                            (pbox.Top + pbox.Bottom) / 2
                        );

                        Point p2 = new Point(
                            (tp.Left + tp.Right) / 2,
                            (tp.Top + tp.Bottom) / 2
                        );

                        double dir = Math.Atan2(p2.Y - p1.Y, p2.X - p1.X);

                        if (Math.Abs(Math.Cos(dir)) > Math.Abs(Math.Sin(dir)))
                        {
                            p2.X -= (Math.Sign(Math.Cos(dir)) * (8 + (tp.Size.Width / 2)));
                            p2.Y -= (int)(Math.Sin(dir) * (8 + (tp.Size.Height / 2)));
                        }
                        else
                        {
                            p2.X -= (int)(Math.Cos(dir) * (8 + (tp.Size.Width / 2)));
                            p2.Y -= (Math.Sign(Math.Sin(dir)) * (8 + (tp.Size.Height / 2)));
                        }

                        GraphicsPath capPath = new GraphicsPath();
                        capPath.AddLine(-2, 0, 2, 0);
                        capPath.AddLine(-2, 0, 0, 2);
                        capPath.AddLine(0, 2, 2, 0);

                        pen.CustomEndCap = new CustomLineCap(null, capPath);

                        e.Graphics.DrawLine(pen, p1, p2);
                    }
                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (project.fname.Equals(string.Empty))
            {
                if (saveFileProject.ShowDialog() == DialogResult.OK)
                {
                    project.fname = saveFileProject.FileName;
                    WindowText(Path.GetFileName(project.fname));
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
            storyboardPanel.Invalidate();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.storyboard.RemoveScene((int)ctxSource.Tag);
        }

        private void salvarCópiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.fname = string.Empty;
            salvarToolStripMenuItem_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Salvar as alterações antes de sair?", "InteraStudio", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
                salvarToolStripMenuItem_Click(sender, e);
        }

        private void StartVideoFrom(ScenePart scene)
        {
            FormPlayer p = new FormPlayer(scene);
            p.Play();
            p.ShowDialog();
        }

        private void doInícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartVideoFrom(project.storyboard.firstScene);
        }

        private void aPartirDaCenaSelecionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartVideoFrom(project.storyboard.selected);
        }
    }
}
