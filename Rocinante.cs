using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Rocinante : Spaceship
    {
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public Rocinante(Weapon weapon)
        {
            Rocinante rocinante = new Rocinante() { Name = "Rocinante", Structure = 3, Shield = 5 };
        }
    }
}
