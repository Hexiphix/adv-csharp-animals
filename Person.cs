using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public abstract class Person : Talkable
    {
        private string _name;

        public Person(string name) => _name = name;

        public string GetName() => _name;

        public void SetName(string name) => _name = name;

        public abstract string Talk();
    }
}
