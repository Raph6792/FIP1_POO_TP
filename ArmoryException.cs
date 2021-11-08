using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class ArmoryException : Exception
    {
        public ArmoryException():base("This weapon does not come from the armory!") { }
    }
}
