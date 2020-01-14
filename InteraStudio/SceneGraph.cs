using System.Collections.Generic;

namespace InteraStudio
{
    public sealed class SceneNode
    {
        /// <summary>
        /// ID auto-incrementado
        /// </summary>
        public static int id_inc = 0;
        
        public int id;
        public ScenePart value;
        public HashSet<int> adjacent;
        public HashSet<int> parents;

        // TODO: remover retroativamente as cenas deletadas da lista de adjacência

        public SceneNode()
        {
            id = ++id_inc;
            value = new ScenePart();
            value.id = id;
            adjacent = new HashSet<int>();
            parents = new HashSet<int>();
        }
    }

    public class SceneGraph
    {
        /// <summary>
        /// Raiz da cena. A primeira cena que será exibida pelo player
        /// e também que será usada pelo storyboard para desenhar o grafo.
        /// </summary>
        public int root;

        /// <summary>
        /// Os nós são indexados pelos seus ids, e podem ser facilmente
        /// inseridos e removidos.
        /// </summary>
        public Dictionary<int, SceneNode> nodes;

        public SceneGraph()
        {
            nodes = new Dictionary<int, SceneNode>();
            root = -1;
        }

        public void AddScene(SceneNode n)
        {
            nodes[n.id] = n;
            if (root == -1) root = n.id;
        }

        public SceneNode CreateScene()
        {
            SceneNode n = new SceneNode();
            AddScene(n);
            return n;
        }

        public void RemoveScene(int id)
        {
            // TODO: clean up and update root
            nodes.Remove(id);
        }

        public ScenePart GetScene(int id)
        {
            return nodes[id].value;
        }
    }
}
