using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette
{
    partial class EMPRUNTER
    {
        public override string ToString()
        {
            return ALBUMS.TITRE_ALBUM.Trim()+"   "+DATE_EMPRUNT.Date.ToString()+"     "+DATE_RETOUR_ATTENDUE.Date.ToString();
        }
    }
}
