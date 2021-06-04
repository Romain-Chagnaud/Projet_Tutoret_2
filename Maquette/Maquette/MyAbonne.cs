using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette
{
    public partial class ABONNÉS
    {
        public override string ToString()
        {
            return NOM_ABONNÉ.Trim() + " " + PRÉNOM_ABONNÉ.Trim();
        }
    }
}
