using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Dart : Spaceship
    {
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public  Dart (Weapon weapon)
        {
            Dart dart = new Dart() { Name = "Dart", Structure = 10, Shield = 3 };
        }
        
        
    }
}
