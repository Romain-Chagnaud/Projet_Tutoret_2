﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static List<String> GetPays()
        {
            var pays = (from p in musique.PAYS
                        select p.NOM_PAYS).ToList();
            return pays;
        }

        public static ABONNÉS connexion(string login, string mdp)
        {
            string crypted = Crypter(mdp);
            var abo = (from a in musique.ABONNÉS
                       where a.LOGIN_ABONNÉ == login && a.PASSWORD_ABONNÉ == crypted
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

        private static Boolean LoginContientCaractèresSpéciaux(String chaine)
        {
            String liste = "_ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > * + = % µ € $ ¤ £";
            String[] listeTab = liste.Split(' ');
            Boolean contient = false;
            for (int i = 0; i < listeTab.Length; i++)
            {
                if (chaine.Contains(listeTab[i]))
                {
                    contient = true;
                }
            }
            return contient;
        }

        public static ABONNÉS inscription(string prenom, string nom, string login, string mdp, string pays)
        {
            ABONNÉS abo = null;
            string prenomTrim = prenom.Trim();
            string nomTrim = nom.Trim();
            if (prenom == prenomTrim && nomTrim == nom && !EstDansLaChaine(prenom, charSpéciaux()) && !EstDansLaChaine(nom, charSpéciaux())
                && prenomTrim.Length > 0 && prenomTrim.Length <= 32 && nomTrim.Length > 0 && nomTrim.Length <= 32 && login.Length > 0 && login.Length<=32
                && mdp.Length>0 && mdp.Length<=32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$") && Regex.IsMatch(login, "^\\S[a-zA-Z0-9]*\\S$"))
            {
                var logins = (from a in musique.ABONNÉS
                              where a.LOGIN_ABONNÉ == login
                              select a).ToList();
                if (logins.Count == 0)
                {
                    abo = new ABONNÉS();
                    abo.PRÉNOM_ABONNÉ = prenom;
                    abo.NOM_ABONNÉ = nom;
                    abo.LOGIN_ABONNÉ = login;
                    abo.PASSWORD_ABONNÉ = Crypter(mdp);
                    if (pays.Length != 0)
                    {
                        if (paysExiste(pays) != null)
                        {
                            abo.PAYS = paysExiste(pays);
                        }
                    }
                    musique.ABONNÉS.Add(abo);
                    musique.SaveChanges();

                }
            }

            return abo;
        }

        public static PAYS paysExiste(string nom)
        {
            var pays = (from p in musique.PAYS
                        where p.NOM_PAYS == nom
                        select p).ToList();
            if (pays.Count != 0)
            {
                return pays[0];
            }
            else
            {
                return null;
            }

        }

        private static String[] majMin()
        {
            String liste = "A a À à Â â Ä ä Ã ã B b C c ç D d E e é È è Ê ê Ë ë F f G g H h I i Ì ì Î î Ï ï J j K " +
                "k L l M m N n Ñ ñ O o Ò ò Ô ô Ö ö Õ õ P p Q q R r S s T t U u Ù ù Û û Ü ü V v W w X x Y y ÿ Z z -";
            return liste.Split(' ');
        }

        private static String[] charSpéciaux()
        {
            String liste = "_ ' . , ; : ! ? @ & § ~ ^ ` ¨ | ( ) { } [ ] / < > 0 1 2 3 4 5 6 7 8 9 * + = % µ € $ ¤ £";
            return liste.Split(' ');
        }

        private static Boolean EstDansLaChaine(String chaine, String[] liste)
        {
            Boolean contient = false;
            for (int i = 0; i < liste.Length; i++)
            {
                if (chaine.Contains(liste[i]))
                {
                    contient = true;
                }
            }
            return contient;
        }

        public static int getPays(String pays)
        {
            var pa = (from all in musique.PAYS
                      where all.NOM_PAYS == pays
                      select all.CODE_PAYS).ToList();
            return pa[0];
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
                if (em.DATE_EMPRUNT.Year == DateTime.Now.Year)
                {
                    empruntsList.Add(em);
                }
            }
            var albumsParEmprunt = empruntsList.GroupBy(em => em.CODE_ALBUM, (key, values) => new { ALBUMS = key, Count = values.Count() });
            var albumsTriés = albumsParEmprunt.OrderByDescending(em => em.Count).ToList<dynamic>();
            return albumsTriés;
        }

        public static List<ALBUMS> getTop10Albums()
        {
            List<ALBUMS> top10 = new List<ALBUMS>();
            var liste = getTop10();
            for (int i = 0; i < liste.Count(); i++)
            {
                top10.Add(getAlbumSelonID(liste[i].ALBUMS));
            }
            return top10;
        }

        public static List<int> getTop10Count()
        {
            List<int> top10 = new List<int>();
            var liste = getTop10();
            for (int i = 0; i < liste.Count(); i++)
            {
                top10.Add(liste[i].Count);
            }
            return top10;
        }

        public static List<ALBUMS> getSuggestions(int id)
        {
            var albumsEmpruntés = getToutAlbumsEmpruntésParAbonné(id);

            var genres = albumsEmpruntés.GroupBy(g => g.GENRES, (key, values) => new { GENRES = key, Count = values.Count() });
            var genresTriés = genres.OrderByDescending(g => g.Count).ToList();

            var albums = getALBUMSs();
            var listeAlbum = albums.Except(albumsEmpruntés).ToList();
            List<ALBUMS> albumsRecommandés = new List<ALBUMS>();
            if (genresTriés.Count >= 1)
            {
                GENRES premierGenre = genresTriés[0].GENRES;
                var albumsRecommandés1 = getAlbumsSelonGenreDansListe(premierGenre.CODE_GENRE, listeAlbum);
                albumsRecommandés.AddRange(albumsRecommandés1.GetRange(0, 3));
                if (genresTriés.Count >= 2)
                {
                    GENRES deuxiemeGenre = genresTriés[1].GENRES;
                    var albumsRecommandés2 = getAlbumsSelonGenreDansListe(deuxiemeGenre.CODE_GENRE, listeAlbum);
                    albumsRecommandés.AddRange(albumsRecommandés2.GetRange(0, 3));
                    if (genresTriés.Count >= 3)
                    {
                        GENRES troisiemeGenre = genresTriés[2].GENRES;
                        var albumsRecommandés3 = getAlbumsSelonGenreDansListe(troisiemeGenre.CODE_GENRE, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés3.GetRange(0, 3));
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

        public static EMPRUNTER getEmpruntAlbumEnCours(ALBUMS al)
        {
            var emprunts = (from e in musique.EMPRUNTER
                            where e.CODE_ALBUM == al.CODE_ALBUM
                            && e.DATE_RETOUR == null
                            select e).ToList();
            if (emprunts.Count > 0)
            {
                return emprunts[0];
            }
            else
            {
                return null;
            }
        }

        public static List<EMPRUNTER> getProlongés()
        {
            List<EMPRUNTER> liste = new List<EMPRUNTER>();
            var listeEmpruntés = getEMPRUNTERNonRendus();
            foreach (EMPRUNTER em in listeEmpruntés)
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
            var emprunts = getEMPRUNTERNonRendus();
            var liste = new List<ABONNÉS>();
            foreach (EMPRUNTER em in emprunts)
            {
                DateTime date = em.DATE_RETOUR_ATTENDUE.AddDays(10);
                if (date.CompareTo(DateTime.Now) < 0)
                {
                    liste.Add(em.ABONNÉS);
                }
            }
            return liste;
        }

        public static List<ABONNÉS> getFantomes()
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

        public static void purgerUnFantome(ABONNÉS ab)
        {
            if (getFantomes().Contains(ab))
            {
                removeAbonné(ab);
            }
        }

        public static void purgerFantomes()
        {
            foreach (ABONNÉS a in getFantomes())
            {
                purgerUnFantome(a);
            }
        }

        public static void supprimerEmprunt(EMPRUNTER e)
        {
            musique.EMPRUNTER.Remove(e);
            musique.SaveChanges();
        }

        public static List<ALBUMS> getAlbumsNonEmpruntés()
        {
            var albums = getALBUMSs();
            List<ALBUMS> albumsNonEmpruntés = new List<ALBUMS>();
            foreach (ALBUMS al in albums)
            {
                var emprunts = getEmpruntsSelonAlbum(al.CODE_ALBUM);

                if (emprunts.Count > 0)
                {
                    int compteur = 0;
                    bool aEteEmprunte = false;

                    while (compteur < emprunts.Count && !aEteEmprunte)
                    {
                        EMPRUNTER emp = emprunts[compteur];
                        DateTime date = emp.DATE_EMPRUNT.AddYears(1);

                        if (date.CompareTo(DateTime.Now) > 0)
                        {
                            aEteEmprunte = true;
                        }
                        compteur++;
                    }

                    if (!aEteEmprunte)
                    {
                        albumsNonEmpruntés.Add(al);
                    }
                }
            }
            return albumsNonEmpruntés;
        }

        public static void ajouterEmprunt(EMPRUNTER e)
        {
            musique.EMPRUNTER.Add(e);
            musique.SaveChanges();
        }

        public static string Crypter(String mdp)
        {
            char[] crypted = new char[mdp.Length];
            int i = 0;
            foreach (char c in mdp.ToCharArray())
            {
                crypted[i] = (char)((int)c + 1);
                i++;
            }
            return new string(crypted);
        }


        public static bool vérificationMDP(string mdp, ABONNÉS abo)
        {
            if (mdp.Length > 0 && mdp.Length <= 32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$"))
            {
                string crypted = Crypter(mdp);
                var mdpTest = (from a in musique.ABONNÉS
                               where a.CODE_ABONNÉ == abo.CODE_ABONNÉ
                               && a.PASSWORD_ABONNÉ == crypted
                               select a).ToList();
                if (mdpTest.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string changerMDP(string mdp, ABONNÉS abo)
        {
            if (mdp.Length > 0 && mdp.Length <= 32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$"))
            {
                abo.PASSWORD_ABONNÉ = Crypter(mdp);
                musique.SaveChanges();
                return mdp;
            }
            else
            {
                return null;
            }
        }

        public static PAYS changerPays(PAYS p, ABONNÉS abo)
        {
            if (paysExiste(p.NOM_PAYS) != null)
            {
                abo.PAYS = p;
                musique.SaveChanges();
                return p;
            } else
            {
                return null;
            }
        }
    }
}
