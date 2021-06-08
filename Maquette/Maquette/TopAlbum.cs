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
    public partial class TopAlbum : Form
    {
        public TopAlbum()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            var emprunts = Outil.getEMPRUNTERs();
            List<EMPRUNTER> empruntsList = new List<EMPRUNTER>();
            foreach (EMPRUNTER em in emprunts)
            {
                if (em.DATE_EMPRUNT.AddYears(1).CompareTo(DateTime.Now) > 0)
                {
                    empruntsList.Add(em);
                }
            }
            var albumsParEmprunt = empruntsList.GroupBy(em => em.CODE_ALBUM, (key, values) => new { ALBUMS = key, Count = values.Count() });
            var albumsTriés = albumsParEmprunt.OrderByDescending(em => em.Count).ToList();
            if (albumsTriés.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    int id = albumsTriés[i].ALBUMS;
                    ALBUMS ab = Outil.getAlbumSelonID(id);
                    listBox5.Items.Add(ab);
                }
            }
            else if (albumsTriés.Count > 0)
            {
                for (int i = 0; i < albumsTriés.Count; i++)
                {
                    int id = albumsTriés[i].ALBUMS;
                    ALBUMS ab = Outil.getAlbumSelonID(id);
                    listBox5.Items.Add(ab);
                }
            }
            else
            {
                listBox5.Items.Add("Aucun emprunt");
            }
        }
    }
}

