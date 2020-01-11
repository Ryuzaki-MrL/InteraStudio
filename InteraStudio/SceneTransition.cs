using System.Windows.Input;

namespace InteraStudio
{
    /// <summary>
    /// Classe base para transições de cena que os tipos de transição irão herdar.
    /// </summary>
    public abstract class SceneTransition
    {
        public int nextScene;

        public abstract bool check();
    }

    public class SceneTransitionKeyboard : SceneTransition
    {
        public int keycode;

        public override bool check()
        {
            return true;
        }
    }
}