using System;
using System.Windows.Forms;

namespace InteraStudio
{
    public partial class Form1 : Form
    {
        private InteraFile project = new InteraFile();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
