using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class Cat : Pet
    {
        private int _miceKilled;

        public Cat(int miceKilled, string name) : base(name) => _miceKilled = miceKilled;

        public int GetMiceKilled() => _miceKilled;

        public void AddMouse() => _miceKilled++;

        public override string Talk() => "Meow";

        public override string ToString() => $"Dog: name={_name} miceKilled={_miceKilled}";
    }
}
