using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public abstract class Pet : Talkable
    {
        protected private string _name;

        public Pet(string name) => _name = name;

        public string GetName() => _name;

        public abstract string Talk();
    }
}
