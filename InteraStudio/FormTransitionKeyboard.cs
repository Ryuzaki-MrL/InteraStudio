using System.Windows.Forms;

namespace InteraStudio
{
    public partial class FormTransitionKeyboard : Form
    {
        private SceneTransitionKeyboard transition;

        public FormTransitionKeyboard(SceneTransition transition)
        {
            InitializeComponent();
            this.transition = (SceneTransitionKeyboard)transition;
        }
    }
}
