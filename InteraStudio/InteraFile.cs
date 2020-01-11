using System.Collections.Generic;
using System.Xml;

namespace InteraStudio
{
    public class InteraFile
    {
        private string fname;

        public string title;
        public List<string> videoSources = new List<string>();
        public SceneGraph scene = new SceneGraph();

        public void Load(string filename)
        {
            fname = filename;
            XmlReader xml = XmlReader.Create(fname);
            xml.Close();
        }

        public void Save()
        {
            XmlWriter xml = XmlWriter.Create(fname);
            xml.Close();
        }

        public InteraFile() { }

        public InteraFile(string filename)
        {
            Load(filename);
        }
    }
}
