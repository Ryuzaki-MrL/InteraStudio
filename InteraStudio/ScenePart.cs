using System.Collections.Generic;
using System.Drawing;

namespace InteraStudio
{
    public class ScenePart
    {
        public int id;
        public string title;
        public Bitmap thumbnail;
        public List<SceneTransition> transitions;
    }
}
