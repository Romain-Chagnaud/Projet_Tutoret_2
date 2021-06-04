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
    public partial class Admin : Form
    {
        MusiqueEntities musique;

        public Admin(MusiqueEntities musique)
        {
            InitializeComponent();
            this.musique = musique;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            var emprunts = (from em in musique.EMPRUNTER
                            select em);

            foreach (EMPRUNTER em in emprunts)
            {
                DateTime dateTime = new DateTime(em.DATE_EMPRUNT.Year, em.DATE_EMPRUNT.Month, em.DATE_EMPRUNT.Day);
                if (dateTime.AddDays(em.ALBUMS.GENRES.DÉLAI).Date.CompareTo(em.DATE_RETOUR_ATTENDUE.Date) != 0)
                {
                    listBox1.Items.Add(em);
                }
            }


        }
    }
}
