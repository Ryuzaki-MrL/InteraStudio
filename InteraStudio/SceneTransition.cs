using System.Windows.Input;

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
        public int nextScene;

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
    }

    public class SceneTransitionAutomatic : SceneTransition
    {
        public override string ToString()
        {
            return "Automática";
        }
    }

    public class SceneTransitionKeyboard : SceneTransition
    {
        public int keycode;

        public override string ToString()
        {
            return "Pressionamento de tecla";
        }
    }
}