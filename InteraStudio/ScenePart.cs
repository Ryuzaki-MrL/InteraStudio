using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InteraStudio
{
    public class ScenePart
    {
        /// <summary>
        /// ID auto-incrementado
        /// </summary>
        public static int id_inc = 0;

        public int id;
        public string title;
        public string videoFile;
        public PictureBox thumbnail;
        public int timeout;
        public BindingList<SceneTransition> transitions;
        public Dictionary<ScenePart, int> refcount;

        public ScenePart(int uid = -1)
        {
            id = (uid < 0) ? ++id_inc : uid;
            transitions = new BindingList<SceneTransition>();
            refcount = new Dictionary<ScenePart, int>();
        }

        public void AddRef(ScenePart to)
        {
            if (!refcount.ContainsKey(to))
                refcount[to] = 0;
            ++refcount[to];
        }

        public void DecRef(ScenePart to)
        {
            if (refcount.ContainsKey(to) && --refcount[to] <= 0)
                refcount.Remove(to);
        }

        public void SetTitle(string title)
        {
            this.title = thumbnail.Controls[0].Text = title;
        }
    }
}
