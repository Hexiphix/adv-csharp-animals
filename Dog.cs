using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class Dog : Pet
    {
        private bool _friendly;

        public Dog(bool friendly, string name) : base(name) => _friendly = friendly;

        public bool IsFriendly() => _friendly;

        public override string Talk() => "Bark";

        public override string ToString() => $"Dog: name={_name} friendly={_friendly}";
    }
}
