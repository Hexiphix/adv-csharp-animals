using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class Teacher : Person
    {
        private int _age;

        public Teacher(int age, string name) : base(name) => _age = age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public override string Talk() => "Don't forget to do the assigned reading!";
    }
}
