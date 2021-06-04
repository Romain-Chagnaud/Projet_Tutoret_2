using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette
{
    public partial class EMPRUNTER
    {
        public override string ToString()
        {
            return "Emprunté le " + DATE_EMPRUNT +"\n À remettre le " + DATE_RETOUR_ATTENDUE;
        }
    }
}
