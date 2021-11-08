using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ViperMKII : Spaceship
    {
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public ViperMKII(Weapon weapon)
        {
            ViperMKII viperMKII = new ViperMKII() { Name = "ViperMKII", Structure = 10, Shield = 15 };
        }
    }
}
