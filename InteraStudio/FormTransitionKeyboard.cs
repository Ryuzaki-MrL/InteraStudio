using System.Windows.Forms;

namespace InteraStudio
{
    public partial class FormTransitionKeyboard : Form
    {
        private SceneTransitionKeyboard transition;

        public FormTransitionKeyboard(SceneTransition t)
        {
            InitializeComponent();
            transition = (SceneTransitionKeyboard)t;
            checkBox1.Checked = transition.showOverlay;
            textBoxCaption.Text = transition.caption;
            textBoxKey.Text = transition.GetKeyName();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            transition.showOverlay = checkBox1.Checked;
        }

        private void FormTransitionKeyboard_KeyPress(object sender, KeyEventArgs e)
        {
            transition.keycode = e.KeyValue;
            textBoxKey.Text = transition.GetKeyName();
        }

        private void textBoxCaption_TextChanged(object sender, System.EventArgs e)
        {
            transition.caption = textBoxCaption.Text;
        }
    }
}
