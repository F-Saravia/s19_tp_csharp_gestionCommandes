using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class Employe
    {
        private int id;
        private string name;
        private string mdp;
        private string type;

        public Employe(int id, string name, string mdp, string type)
        {
            this.id = id;
            this.name = name;
            this.mdp = mdp;
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Type { get => type; set => type = value; }
    }
}
