using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class B_Wings : Spaceship
    {
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public B_Wings(Weapon weapon)
        {
                B_Wings _Wings = new B_Wings() { Name = "B-Wings", Structure = 30, Shield = 0 };
        }
    }
}
