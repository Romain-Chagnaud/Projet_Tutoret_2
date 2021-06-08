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
            return ALBUMS.TITRE_ALBUM.Trim() +": emprunté le " + DATE_EMPRUNT +"\n À remettre le " + DATE_RETOUR_ATTENDUE;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            EMPRUNTER other = (EMPRUNTER)obj;
            if(this.CODE_ABONNÉ==other.CODE_ABONNÉ && this.CODE_ALBUM == other.CODE_ABONNÉ)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
