using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class Form1 : Form
    {
        MusiqueEntities musique;
        public Form1()
        {
            InitializeComponent();
            musique = new MusiqueEntities();
            var abonneSQL = from a in musique.ABONNÉS
                            where a.LOGIN_ABONNÉ == "michou"
                            select a;
            Abonné ecran = new Abonné(musique, abonneSQL.First());           
            ecran.ShowDialog();
        }
    }
}
