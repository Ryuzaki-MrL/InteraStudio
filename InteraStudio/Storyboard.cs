using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public class Storyboard
    {
        private Dictionary<int, ScenePart> scenes = new Dictionary<int, ScenePart>();

        public GroupBox group;
        public ScenePart firstScene = null;
        public ScenePart selected = null;

        private bool selectNextScene = false;
        private TransitionID transitionType;
        private readonly ContextMenuStrip cms;
        private Point mouse;

        public Storyboard() { }

        public Storyboard(GroupBox g, ContextMenuStrip c)
        {
            group = g;
            cms = c;
            Clear();
        }

        public ScenePart CreateScene(string videoFile = "", int id = -1)
        {
            ScenePart n = new ScenePart(id);
            scenes[n.id] = n;
            n.videoFile = videoFile;

            PictureBox p = new PictureBox();
            p.Visible = true;
            p.Size = new Size(150, 96);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.MouseDown += thumbnail_MouseDown;
            p.MouseMove += thumbnail_MouseMove;
            p.MouseClick += thumbnail_MouseClick;
            p.MouseDoubleClick += thumbnail_DoubleClick;
            p.ContextMenuStrip = cms;

            Label l = new Label();
            n.title = l.Text = "Cena " + n.id;
            p.Controls.Add(l);

            p.Tag = n.id; // for convenience
            group.Controls.Add(p);
            n.thumbnail = p;

            if (firstScene == null) SetAsFirstScene(n.id);

            return n;
        }

        public void RemoveScene(int id)
        {
            // TODO
        }

        public ScenePart GetScene(int id)
        {
            return scenes[id];
        }

        public List<ScenePart> GetSceneList()
        {
            return new List<ScenePart>(scenes.Values);
        }

        public void SetAsFirstScene(int id)
        {
            firstScene = scenes[id];
            group.Invalidate();
        }

        public void SetNewTransition(int src, TransitionID type)
        {
            selectNextScene = true;
            selected = scenes[src];
            transitionType = type;
        }

        public SceneTransition CreateTransition(ScenePart src, ScenePart dest, TransitionID type)
        {
            SceneTransition t = SceneTransition.GetTransitionById(type);
            t.nextScene = dest;
            src.transitions.Add(t);
            dest.AddRef(src);
            group.Invalidate();
            return t;
        }

        public void Clear()
        {
            group.Controls.Clear();
            scenes.Clear();
        }

        private void thumbnail_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectNextScene) return;

            if (e.Button == MouseButtons.Left)
            {
                mouse = e.Location;
            }
        }

        private void thumbnail_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectNextScene) return;

            Control p = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                p.Left = e.X + p.Left - mouse.X;
                p.Top = e.Y + p.Top - mouse.Y;

                group.Invalidate();
            }
        }

        private void thumbnail_DoubleClick(object sender, EventArgs e)
        {
            if (selectNextScene) return;

            Control thumbnail = (Control)sender;
            FormSceneProperties p = new FormSceneProperties(scenes[(int)thumbnail.Tag]);
            p.ShowDialog();
        }

        private void thumbnail_MouseClick(object sender, MouseEventArgs e)
        {
            Control thumbnail = (Control)sender;

            if (selectNextScene)
            {
                // TODO: configure transition within a new Form (created by Strategy Pattern)
                CreateTransition(selected, scenes[(int)thumbnail.Tag], transitionType);
                selectNextScene = false;
            }
            else
            {
                // Sets the starting scene for the "start from the selected scene" option
                selected = scenes[(int)thumbnail.Tag];
            }
        }
    }
}
