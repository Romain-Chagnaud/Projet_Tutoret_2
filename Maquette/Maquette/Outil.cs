using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquette
{
    public static class Outil
    {
        public static MusiqueEntities musique { get; set; }

        public static List<ABONNÉS> getABONNÉSs()
        {
            var abonnés = (from a in musique.ABONNÉS
             select a).ToList();
            return abonnés;
        }

        public static ABONNÉS getAbonnéSelonLogin(string login)
        {
            var abo = (from a in musique.ABONNÉS
                       where a.LOGIN_ABONNÉ == login
                       select a).ToList();
            if (abo.Count > 0)
            {
                return abo[0];
            } else
            {
                return null;
            }
        }      

        public static ABONNÉS connexion(string login, string mdp)
        {
            var abo = (from a in musique.ABONNÉS
                       where a.LOGIN_ABONNÉ == login && a.PASSWORD_ABONNÉ == mdp
                       select a).ToList();
            if (abo.Count > 0)
            {
                return abo[0];
            } else
            {
                return null;
            }
        }

        public static ABONNÉS inscription(string prenom, string nom, string login, string mdp)
        {
            ABONNÉS abo = null;
            var logins = (from a in musique.ABONNÉS
                         where a.LOGIN_ABONNÉ==login
                         select a).ToList();
            if (logins.Count == 0)
            {
                abo = new ABONNÉS();
                abo.PRÉNOM_ABONNÉ = prenom;
                abo.NOM_ABONNÉ = nom;
                abo.LOGIN_ABONNÉ = login;
                abo.PASSWORD_ABONNÉ = mdp;
                musique.ABONNÉS.Add(abo);
                musique.SaveChanges();
                
            }
            return abo;
        }

        public static List<ALBUMS> getToutAlbumsEmpruntésParAbonné(int id)
        {
            var albumsEmpruntés = (from al2 in musique.ALBUMS
                                  join em1 in musique.EMPRUNTER
                                  on al2.CODE_ALBUM equals em1.CODE_ALBUM
                                  where em1.CODE_ABONNÉ == id
                                  select al2).ToList();
            return albumsEmpruntés;
        }

        public static ALBUMS getAlbumSelonTitre(string titre)
        {
            var alb = (from al in musique.ALBUMS
                       where al.TITRE_ALBUM==titre
                       select al).ToList();
            if (alb.Count > 0)
            {
                return alb[0];
            } else
            {
                return null;
            }
        }

        public static List<ALBUMS> getIndisponibles()
        {
            var empruntés = (from al in musique.ALBUMS
                             join e in musique.EMPRUNTER
                             on al.CODE_ALBUM equals e.CODE_ALBUM
                             where e.DATE_RETOUR == null
                             select al).ToList();
            return empruntés;
        }

        public static List<ALBUMS> getALBUMSs()
        {
            var albums = (from al in musique.ALBUMS
                          select al).ToList();
            return albums;
        }

        public static ALBUMS getAlbumSelonID(int id)
        {
            var album = (from al in musique.ALBUMS
                          where al.CODE_ALBUM == id
                          select al).ToList();
            if (album.Count > 0)
            {
                return album[0];
            } else
            {
                return null;
            }
        }

        public static List<ALBUMS> getAlbumsSelonGenreDansListe(int id, List<ALBUMS> listeAlbum)
        {
            var albums = (from al in listeAlbum
                                     where al.CODE_GENRE == id
                                     select al).ToList();
            return albums;
        }

        public static EMPRUNTER nouvelEmprunt(ABONNÉS ab, ALBUMS al)
        {
            DateTime date = DateTime.Now;
            DateTime newDate = date.AddDays(al.GENRES.DÉLAI);
            EMPRUNTER em = new EMPRUNTER();
            em.CODE_ABONNÉ = ab.CODE_ABONNÉ;
            em.CODE_ALBUM = al.CODE_ALBUM;
            em.DATE_EMPRUNT = date;
            em.DATE_RETOUR_ATTENDUE = newDate;
            musique.EMPRUNTER.Add(em);
            musique.SaveChanges();
            return em;
        }

        public static List<EMPRUNTER> getEMPRUNTERs()
        {
            var emprunts = (from em in musique.EMPRUNTER
                            select em).ToList();
            return emprunts;
        }

        public static List<EMPRUNTER> getEMPRUNTERNonRendus()
        {
            var emprunts = (from em in musique.EMPRUNTER
                            where em.DATE_RETOUR == null
                            select em).ToList();
            return emprunts;
        }

        public static List<EMPRUNTER> getEmpruntsAbonné(int id)
        {
            var emprunts = (from e in musique.EMPRUNTER
                            where e.CODE_ABONNÉ == id
                            select e).ToList();
            return emprunts;
        }

        public static List<EMPRUNTER> getEmpruntsEnCoursAbonné(int id)
        {
            var emprunts = (from e in musique.EMPRUNTER
                            where e.CODE_ABONNÉ == id && e.DATE_RETOUR == null
                            select e).ToList();
            return emprunts;
        }

        public static List<EMPRUNTER> getEmpruntsSelonAlbum(int id)
        {
            var emprunts = (from e in musique.EMPRUNTER
                            where e.CODE_ALBUM == id
                            select e).ToList();
            return emprunts;
        }

        public static List<ABONNÉS> getFantome()
        {
            List<ABONNÉS> fantome = new List<ABONNÉS>();
            var abos = getABONNÉSs();

            foreach (ABONNÉS abo in abos)
            {               
                var emprunts = getEmpruntsAbonné(abo.CODE_ABONNÉ);

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
                        fantome.Add(abo);
                    }
                }

            }
            return fantome;
        }

    }
}
