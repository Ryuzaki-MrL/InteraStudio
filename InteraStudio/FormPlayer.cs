using Vlc.DotNet.Core;
using System.Windows.Forms;
using System.IO;

namespace InteraStudio
{
    public partial class FormPlayer : Form
    {
        public ScenePart firstScene;
        public ScenePart currentScene;
        private bool listeningInput;
        private bool waitingForEnd;

        public FormPlayer(ScenePart first)
        {
            InitializeComponent();
            currentScene = firstScene = first;
            listeningInput = false;
            waitingForEnd = false;
        }

        public void Start(ScenePart scene)
        {
            listeningInput = false;
            currentScene = scene;
            //HideOverlays();
            Stop();
            Play();
        }

        public void Play()
        {
            if (currentScene != null) {
                vlcControl1.Play(new FileInfo(currentScene.videoFile));
                waitingForEnd = true;
            } else {
                Stop();
            }
        }

        public void Stop()
        {
            waitingForEnd = false;
            vlcControl1.Stop();
        }

        public void TogglePause()
        {
            vlcControl1.Pause();
        }

        public void FullScreen()
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void Windowed()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }

        public void ToggleFullScreen()
        {
            if (FormBorderStyle == FormBorderStyle.None) {
                Windowed();
            } else {
                FullScreen();
            }
        }

        private bool CheckAutoTransition()
        {
            foreach (SceneTransition t in currentScene.transitions)
            {
                if (t.GetTransitionID() == TransitionID.Automatic)
                {
                    Start(t.nextScene);
                    return true;
                }
            }
            return false;
        }

        private bool CheckKeyboardTransition(int key)
        {
            foreach (SceneTransition t in currentScene.transitions)
            {
                if (t.GetTransitionID() == TransitionID.Keyboard)
                {
                    SceneTransitionKeyboard tk = (SceneTransitionKeyboard)t;
                    if (tk.keycode == key)
                    {
                        Start(t.nextScene);
                        return true;
                    }
                }
            }
            return false;
        }

        private void ShowOverlays()
        {
            // TODO: show transition prompts
        }

        private void HideOverlays()
        {
            vlcControl1.Controls.Clear();
        }

        private void vlcControl1_EndReached(object sender, VlcMediaPlayerEndReachedEventArgs e)
        {
            // TODO: fix automatic transition crashing the player
            if (!waitingForEnd) return;
            if (CheckAutoTransition()) return;
            ShowOverlays();
            listeningInput = true;
        }

        private void FormPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            /// Advance movie (has priority over shortcuts)
            if (listeningInput)
            {
                if (CheckKeyboardTransition(e.KeyValue)) return;
            }

            /// Shortcuts
            switch (e.KeyCode)
            {
                case Keys.F11:
                    ToggleFullScreen(); break;
                case Keys.F5:
                    Start(firstScene); break;
                case Keys.Escape:
                    Close(); break;
                case Keys.Pause:
                case Keys.F2:
                    TogglePause(); break;
            }
        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
    }
}
