using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public enum TransitionID {
        Automatic,
        Keyboard,

        IdCount
    };

    /// <summary>
    /// Classe base para transições de cena que os tipos de transição irão herdar.
    /// Implementa o padrão Strategy.
    /// </summary>
    public abstract class SceneTransition
    {
        protected TransitionID id;

        public ScenePart nextScene;
        public List<Point> arrowPath = new List<Point>();

        public static SceneTransition GetTransitionById(TransitionID id)
        {
            switch(id)
            {
                case TransitionID.Keyboard:
                    return new SceneTransitionKeyboard();
                default:
                    return new SceneTransitionAutomatic();
            }
        }

        public TransitionID GetTransitionID()
        {
            return id;
        }
    }

    public class SceneTransitionAutomatic : SceneTransition
    {
        public SceneTransitionAutomatic() { id = TransitionID.Automatic; }

        public override string ToString()
        {
            return "Transição automática para a cena " + nextScene.title;
        }
    }

    public class SceneTransitionKeyboard : SceneTransition
    {
        public int keycode;

        public SceneTransitionKeyboard() { id = TransitionID.Keyboard; }

        public override string ToString()
        {
            return "Pressione " + Keys.GetName(typeof(Keys), keycode) + " para a cena " + nextScene.title;
        }
    }
}
