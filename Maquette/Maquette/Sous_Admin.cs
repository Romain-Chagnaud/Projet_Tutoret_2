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
    public partial class Sous_Admin : Form
    {
        private ABONNÉS abonne;

        public Sous_Admin()
        {
            InitializeComponent();
        }

        private void SousAdmin(object sender, EventArgs e)
        {
            populateItems();

            var abos = Outil.getFantome();

            foreach (ABONNÉS abo in abos)
            {
                /*var emprunts = (from em in musique.EMPRUNTER
                                join a in musique.ABONNÉS
                                on em.CODE_ABONNÉ equals a.CODE_ABONNÉ
                                select em).ToList();*/
                button1.Enabled = true;
                var emprunts = Outil.getEmpruntsAbonné(abo.CODE_ABONNÉ);

                if (emprunts.Count > 0)
                {
                    int compteur = 0;
                    bool estActif = false;

                    while (compteur < emprunts.Count && !estActif)
                    {
                        EMPRUNTER emp = emprunts[compteur];
                        DateTime date = emp.DATE_EMPRUNT.AddYears(1);

                        if (date.CompareTo(DateTime.Now) > 0)
                        {
                            estActif = true;
                        }
                        compteur++;
                    }

                    if (!estActif)
                    {
                        flowLayoutPanel1.Controls.Clear();
                        flowLayoutPanel1.Controls.Add(new AbonneFantome(abonne));
                    }
                }

            }
        }

        private void populateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AbonneFantome(abonne));


        }



    }

    }


