using System;
using System.Collections.Generic;
using System.Linq;

namespace Maquette
{
    public static class Outil
    {
        public static MusiqueEntities musique { get; set; }

        public static void chargerMusiqueEntities()
        {
            musique = new MusiqueEntities();
        }

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
            }
            else
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
            }
            else
            {
                return null;
            }
        }

        public static ABONNÉS inscription(string prenom, string nom, string login, string mdp)
        {
            ABONNÉS abo = null;
            var logins = (from a in musique.ABONNÉS
                          where a.LOGIN_ABONNÉ == login
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

        public static void removeAbonné(ABONNÉS a)
        {
            musique.ABONNÉS.Remove(a);
            musique.SaveChanges();
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
                       where al.TITRE_ALBUM == titre
                       select al).ToList();
            if (alb.Count > 0)
            {
                return alb[0];
            }
            else
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
            }
            else
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
            EMPRUNTER em = null;
            if (!getIndisponibles().Contains(al))
            {
                DateTime date = DateTime.Now;
                DateTime newDate = date.AddDays(al.GENRES.DÉLAI);
                em = new EMPRUNTER();
                em.CODE_ABONNÉ = ab.CODE_ABONNÉ;
                em.CODE_ALBUM = al.CODE_ALBUM;
                em.DATE_EMPRUNT = date;
                em.DATE_RETOUR_ATTENDUE = newDate;
                EMPRUNTER existant = null;
                foreach (EMPRUNTER e in musique.EMPRUNTER)
                {
                    if (e.Equals(em))
                    {
                        existant = e;
                    }
                }
                if (existant != null)
                {
                    musique.EMPRUNTER.Remove(existant);
                    musique.SaveChanges();
                }
                musique.EMPRUNTER.Add(em);
                musique.SaveChanges();
            }
            return em;
        }

        public static EMPRUNTER nouvelEmpruntDaté(ABONNÉS ab, ALBUMS al, DateTime dt)
        {
            EMPRUNTER em = null;
            if (!getIndisponibles().Contains(al))
            {
                DateTime newDate = dt.AddDays(al.GENRES.DÉLAI);
                em = new EMPRUNTER();
                em.CODE_ABONNÉ = ab.CODE_ABONNÉ;
                em.CODE_ALBUM = al.CODE_ALBUM;
                em.DATE_EMPRUNT = dt;
                em.DATE_RETOUR_ATTENDUE = newDate;
                EMPRUNTER existant = null;
                foreach (EMPRUNTER e in musique.EMPRUNTER)
                {
                    if (e.Equals(em))
                    {
                        existant = e;
                    }
                }
                if (existant != null)
                {
                    musique.EMPRUNTER.Remove(existant);
                    musique.SaveChanges();
                }
                musique.EMPRUNTER.Add(em);
                musique.SaveChanges();
            }
            return em;
        }

        public static void rendreEmprunt(EMPRUNTER em)
        {
            DateTime date = DateTime.Now;
            em.DATE_RETOUR = date;
            musique.SaveChanges();
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

        public static List<dynamic> getTop10()
        {
            var emprunts = getEMPRUNTERs();
            List<EMPRUNTER> empruntsList = new List<EMPRUNTER>();
            foreach (EMPRUNTER em in emprunts)
            {
                if (em.DATE_EMPRUNT.AddYears(1).CompareTo(DateTime.Now) > 0)
                {
                    empruntsList.Add(em);
                }
            }
            var albumsParEmprunt = empruntsList.GroupBy(em => em.CODE_ALBUM, (key, values) => new { ALBUMS = key, Count = values.Count() });
            var albumsTriés = albumsParEmprunt.OrderByDescending(em => em.Count).ToList<dynamic>();
            return albumsTriés;
        }

        public static List<List<ALBUMS>> getSuggestions(int id)
        {
            var albumsEmpruntés = getToutAlbumsEmpruntésParAbonné(id);

            var genres = albumsEmpruntés.GroupBy(g => g.GENRES, (key, values) => new { GENRES = key, Count = values.Count() });
            var genresTriés = genres.OrderByDescending(g => g.Count).ToList();

            var albums = getALBUMSs();
            var listeAlbum = albums.Except(albumsEmpruntés).ToList();
            List<List<ALBUMS>> albumsRecommandés = new List<List<ALBUMS>>();
            if (genresTriés.Count >= 1)
            {
                GENRES premierGenre = genresTriés[0].GENRES;
                var albumsRecommandés1 = getAlbumsSelonGenreDansListe(premierGenre.CODE_GENRE, listeAlbum);
                albumsRecommandés.Add(albumsRecommandés1);
                if (genresTriés.Count >= 2)
                {
                    GENRES deuxiemeGenre = genresTriés[1].GENRES;
                    var albumsRecommandés2 = getAlbumsSelonGenreDansListe(deuxiemeGenre.CODE_GENRE, listeAlbum);
                    albumsRecommandés.Add(albumsRecommandés2);
                    if (genresTriés.Count >= 3)
                    {
                        GENRES troisiemeGenre = genresTriés[2].GENRES;
                        var albumsRecommandés3 = getAlbumsSelonGenreDansListe(troisiemeGenre.CODE_GENRE, listeAlbum);
                        albumsRecommandés.Add(albumsRecommandés3);
                    }
                }

            }
            return albumsRecommandés;
        }

        public static bool estProlongeable(EMPRUNTER emprunt)
        {
            DateTime dateTime = new DateTime(emprunt.DATE_EMPRUNT.Year, emprunt.DATE_EMPRUNT.Month, emprunt.DATE_EMPRUNT.Day);
            if (dateTime.AddDays(emprunt.ALBUMS.GENRES.DÉLAI).Date.CompareTo(emprunt.DATE_RETOUR_ATTENDUE.Date) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static EMPRUNTER prolongation(EMPRUNTER emprunt)
        {
            if (estProlongeable(emprunt))
            {
                emprunt.DATE_RETOUR_ATTENDUE = emprunt.DATE_RETOUR_ATTENDUE.AddMonths(1);
                musique.SaveChanges();
            }
            return emprunt;
        }

        public static List<EMPRUNTER> getProlongés()
        {
            List<EMPRUNTER> liste = new List<EMPRUNTER>();
            var listeEmpruntés = getEMPRUNTERNonRendus();
            foreach(EMPRUNTER em in listeEmpruntés)
            {
                if (!estProlongeable(em))
                {
                    liste.Add(em);
                }
            }
            return liste;
        }

        public static List<ABONNÉS> getRetardataires()
        {
            var emprunts = getEMPRUNTERs();
            var liste = new List<ABONNÉS>();
            foreach (EMPRUNTER em in emprunts)
            {
                DateTime date = em.DATE_RETOUR_ATTENDUE.AddDays(10);
                if (date.CompareTo(DateTime.Now) <= 0)
                {
                    liste.Add(em.ABONNÉS);
                }
            }
            return liste;
        }
    }
}
