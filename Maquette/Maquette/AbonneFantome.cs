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
    public partial class AbonneFantome : UserControl
    {

        public ABONNÉS abonne;

        public AbonneFantome(ABONNÉS abonne)
        {
            InitializeComponent();
            this.abonne = abonne;
            Admin_Name.Text = abonne.NOM_ABONNÉ.Trim();
            Admin_Prenom.Text = abonne.PRÉNOM_ABONNÉ.Trim();

        }

        public void setAbonne(ABONNÉS abonneFantome)
        {
            this.abonne = abonneFantome;
        }

        private void abonneFantome()

        {
            AbonneFantome aboss = new AbonneFantome(abonne);
            aboss.Show();
        }




    }
}

