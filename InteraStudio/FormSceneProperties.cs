﻿using System.Windows.Forms;

namespace InteraStudio
{
    public partial class FormSceneProperties : Form
    {
        private ScenePart scene;

        public FormSceneProperties(ScenePart scene)
        {
            InitializeComponent();
            this.scene = scene;
            groupBox1.Text = "Propriedades de " + scene.title;
            textBoxTitle.Text = scene.title;
            textBoxSource.Text = scene.videoFile;
            thumbnailBox.ImageLocation = scene.thumbnail.ImageLocation;
        }

        private void textBoxTitle_TextChanged(object sender, System.EventArgs e)
        {
            scene.thumbnail.Controls[0].Text = scene.title = textBoxTitle.Text;
        }

        private void btnFile_Click(object sender, System.EventArgs e)
        {
            if (openVideoSource.ShowDialog() == DialogResult.OK)
            {
                textBoxSource.Text = scene.videoFile = openVideoSource.FileName;
            }
        }

        private void thumbnailBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileThumbnail.ShowDialog() == DialogResult.OK)
            {
                thumbnailBox.ImageLocation = scene.thumbnail.ImageLocation = openFileThumbnail.FileName;
            }
        }
    }
}