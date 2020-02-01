using System;
using System.Windows.Forms;
using System.Xml;

namespace InteraStudio
{
    public class InteraFile
    {
        public string fname = "";

        public string title = "";
        public string author = "";
        public Storyboard storyboard = new Storyboard();

        public void Load(string filename)
        {
            try
            {
                fname = filename;
                int firstScene = -1;
                bool hasFirstScene = false;
                XmlReader xml = XmlReader.Create(fname);

                while (xml.Read())
                {
                    if (xml.NodeType == XmlNodeType.Element)
                    {
                        if (xml.Name == "project" && xml.HasAttributes)
                        {
                            title = xml.GetAttribute("title");
                            author = xml.GetAttribute("author");
                        }
                        else if (xml.Name == "storyboard" && xml.HasAttributes)
                        {
                            ScenePart.id_inc = int.Parse(xml.GetAttribute("lastId"));
                            hasFirstScene = int.TryParse(xml.GetAttribute("firstScene"), out firstScene);
                        }
                        else if (xml.Name == "scene" && xml.HasAttributes)
                        {
                            ScenePart p = storyboard.CreateScene(xml.GetAttribute("videoSrc"), int.Parse(xml.GetAttribute("id")));
                            p.title = xml.GetAttribute("title");
                            p.thumbnail.ImageLocation = xml.GetAttribute("thumbSrc");
                            p.timeout = int.Parse(xml.GetAttribute("timeout"));
                            int x = int.Parse(xml.GetAttribute("posX"));
                            int y = int.Parse(xml.GetAttribute("posY"));
                            p.thumbnail.Location = new System.Drawing.Point(x, y);
                        }
                        else if (xml.Name == "transition" && xml.HasAttributes)
                        {
                            ScenePart src = storyboard.GetScene(int.Parse(xml.GetAttribute("srcScene")));
                            ScenePart dest = storyboard.GetScene(int.Parse(xml.GetAttribute("nextScene")));
                            TransitionID type = (TransitionID)Enum.Parse(typeof(TransitionID), xml.GetAttribute("type"));
                            SceneTransition t = storyboard.CreateTransition(src, dest, type);
                            if (type == TransitionID.Keyboard)
                            {
                                SceneTransitionKeyboard tk = (SceneTransitionKeyboard)t;
                                tk.keycode = int.Parse(xml.GetAttribute("keycode"));
                                if (!bool.TryParse(xml.GetAttribute("showOverlay"), out tk.showOverlay))
                                    tk.showOverlay = false;
                            }
                        }
                    }
                }
                xml.Close();

                if (hasFirstScene)
                {
                    storyboard.SetAsFirstScene(firstScene);
                }
            }
            catch(Exception e)
            {
#if DEBUG
                MessageBox.Show(e.StackTrace);
#else
                MessageBox.Show("Arquivo de projeto inválido.");
#endif
                if (storyboard != null) storyboard.Clear();
            }
        }

        public void Save()
        {
            XmlWriter xml = XmlWriter.Create(fname);
            xml.WriteStartDocument();

            xml.WriteStartElement("InteraStudio");
            {
                xml.WriteStartElement("project");
                xml.WriteAttributeString("title", title);
                xml.WriteAttributeString("author", author);
                xml.WriteEndElement();

                xml.WriteStartElement("storyboard");
                {
                    xml.WriteAttributeString("lastId", ScenePart.id_inc.ToString());
                    if (storyboard.firstScene != null)
                        xml.WriteAttributeString("firstScene", storyboard.firstScene.id.ToString());

                    foreach (ScenePart n in storyboard.GetSceneList())
                    {
                        xml.WriteStartElement("scene");
                        xml.WriteAttributeString("id", n.id.ToString());
                        xml.WriteAttributeString("title", n.title);
                        xml.WriteAttributeString("videoSrc", n.videoFile);
                        xml.WriteAttributeString("thumbSrc", n.thumbnail.ImageLocation);
                        xml.WriteAttributeString("timeout", n.timeout.ToString());
                        xml.WriteAttributeString("posX", n.thumbnail.Location.X.ToString());
                        xml.WriteAttributeString("posY", n.thumbnail.Location.Y.ToString());
                        xml.WriteEndElement();
                    }

                    foreach (ScenePart n in storyboard.GetSceneList())
                    {
                        foreach (SceneTransition t in n.transitions)
                        {
                            xml.WriteStartElement("transition");
                            xml.WriteAttributeString("type", t.GetTransitionID().ToString());
                            xml.WriteAttributeString("srcScene", n.id.ToString());
                            xml.WriteAttributeString("nextScene", t.nextScene.id.ToString());
                            if (t.GetTransitionID() == TransitionID.Keyboard)
                            {
                                SceneTransitionKeyboard tk = (SceneTransitionKeyboard)t;
                                xml.WriteAttributeString("keycode", tk.keycode.ToString());
                                xml.WriteAttributeString("showOverlay", tk.showOverlay.ToString());
                            }
                            xml.WriteEndElement();
                        }
                    }
                }
                xml.WriteEndElement();
            }
            xml.WriteEndElement();

            xml.WriteEndDocument();
            xml.Close();
        }

        public InteraFile() { }

        public InteraFile(string filename)
        {
            Load(filename);
        }
    }
}
