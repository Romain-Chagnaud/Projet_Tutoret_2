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
    public partial class Sous_Admin2cs : Form
    {
        public Sous_Admin2cs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            var emprunts = Outil.getEMPRUNTERs();

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime date = em.DATE_RETOUR_ATTENDUE.AddDays(10);
                if (date.CompareTo(DateTime.Now) < 0)
                {
                    listBox2.Items.Add(em);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var abo = Outil.getAbonnéSelonLogin("Mijel");
            var alb = Outil.getAlbumSelonTitre("Haendel: Saul");
            Outil.nouvelEmprunt(abo, alb);
        }
    }
}
