using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette
{
    public partial class ALBUMS
    {
        public override string ToString()
        {
            return TITRE_ALBUM.Trim() + ", " + ANNÉE_ALBUM + ", édition " + EDITEURS;
        }
    }
}
