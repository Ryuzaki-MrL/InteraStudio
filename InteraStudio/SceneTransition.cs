using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InteraStudio
{
    public enum TransitionID {
        Automatic,
        Keyboard,
        Timed,

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

        public static SceneTransition Create(TransitionID id)
        {
            switch(id)
            {
                case TransitionID.Keyboard:
                    return new SceneTransitionKeyboard();
                default:
                    return new SceneTransitionAutomatic();
            }
        }

        public void Configure()
        {
            Form config;

            switch(id)
            {
                case TransitionID.Keyboard:
                    config = new FormTransitionKeyboard(this);
                    break;
                default:
                    return;
            }

            config.ShowDialog();
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
        public bool showOverlay;
        public string caption;

        public SceneTransitionKeyboard() { id = TransitionID.Keyboard; }

        public override string ToString()
        {
            return "Pressione " + GetKeyName() + " para a cena " + nextScene.title;
        }

        public string GetKeyName()
        {
            return Keys.GetName(typeof(Keys), keycode);
        }
    }
}
