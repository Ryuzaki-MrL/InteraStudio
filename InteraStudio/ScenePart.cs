using System.Collections.Generic;
using System.Windows.Forms;

namespace InteraStudio
{
    public class ScenePart
    {
        public string title;
        public string videoFile;
        public PictureBox thumbnail;
        public int timeout;
        public List<SceneTransition> transitions;

        public ScenePart()
        {
            transitions = new List<SceneTransition>();
        }
    }
}
