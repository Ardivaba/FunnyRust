using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyRust
{
    public class Entity
    {
        public string Name;

        public List<Entity> Children = new List<Entity>();
        public Entity Parent;
        public int Depth = 0;

        public Entity(string name, int depth, Entity parent)
        {
            Name = string.Join(" ", name.Trim().Split(' ').Reverse().Skip(1).Reverse().ToArray());
            Parent = parent;
            Depth = depth;
        }

        public List<Entity> FindAllThatContains(string pattern, Entity parent = null)
        {
            if (parent == null)
                parent = this;

            List<Entity> list = new List<Entity>();
            foreach(var entity in parent.Children)
            {
                if (entity.Name.Contains(pattern))
                {
                    list.Add(entity);
                }

                list.AddRange(FindAllThatContains(pattern, entity));
            }

            return list;
        }
    }

    public class EntityParser
    {
        private string data;

        public Entity Parse(string[] lines)
        {
            Entity world = new Entity("World", -1, null);
            Entity prev = null;

            foreach(var line in lines)
            {
                int depth = line.TakeWhile(Char.IsWhiteSpace).Count();

                if (line.Length > 2 && line[0] != ' ')
                {
                    var entity = new Entity(line, depth, world);
                    world.Children.Add(entity);
                    prev = entity;
                }
                else if(prev != null && depth > prev.Depth)
                {
                    var entity = new Entity(line, depth, prev);
                    prev.Children.Add(entity);
                    prev = entity;
                }
                else if(prev != null && depth == prev.Depth)
                {
                    var entity = new Entity(line, depth, prev.Parent);
                    prev.Parent.Children.Add(entity);
                    prev = entity;
                }
                else if(prev != null && depth < prev.Depth)
                {
                    while (depth < prev.Depth)
                    {
                        prev = prev.Parent;
                    }

                    var entity = new Entity(line, depth, prev.Parent);
                    prev.Parent.Children.Add(entity);
                    prev = entity;
                }
            }

            return world;
        }
    }
}
