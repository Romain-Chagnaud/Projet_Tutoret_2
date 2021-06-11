using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Maquette
{
    /// <summary>
    /// Classe Outil qui a pour rôle de gérer les communications avec la base
    /// </summary>
    public static class Outil
    {
        /// <summary>
        /// Attribut permettant de communiquer avec la database
        /// </summary>
        public static MusiqueEntities Musique { get; set; }

        /// <summary>
        /// Permet de générer le mappage objet-relationnel à la base
        /// </summary>
        public static void ChargerMusiqueEntities()
        {
            Musique = new MusiqueEntities();
        }

        /// <summary>
        /// Méthode pour récupérer tout les abonnés
        /// </summary>
        /// <returns>Retourne une liste d'ABONNÉS</returns>
        public static List<ABONNÉS> GetABONNÉSs()
        {
            var abonnés = (from a in Musique.ABONNÉS
                           select a).ToList();
            return abonnés;
        }

        /// <summary>
        /// Méthode pour récupérer tout les pays
        /// </summary>
        /// <returns>Retourne une liste de PAYS</returns>
        public static List<PAYS> GetPays()
        {
            var pays = (from p in Musique.PAYS
                        select p).ToList();
            return pays;
        }

        /// <summary>
        /// Méthode permettant de se connecter, à partir d'un login et d'un mot de passe
        /// </summary>
        /// <param name="login">Identifiant de l'utilisateur</param>
        /// <param name="mdp">Mot de passe de l'utilisateur</param>
        /// <returns>Retourne un ABONNÉS si la connexion est réussi, null sinon</returns>
        public static ABONNÉS Connexion(string login, string mdp)
        {
            string crypted = Crypter(mdp);
            var abo = (from a in Musique.ABONNÉS
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

        /// <summary>
        /// Méthode pour inscrire un utilisateur.
        /// Chaque attribut "texte" ne doit pas dépasser 32 caractères et respecter des conditions.
        /// Le prénom, et le nom peuvent contenir des espaces et des tirets pour séparer différents différents éléments( commençant par des majuscules).
        /// Le login est libre mais ne doit pas contenir de caractères spéciaux ou d'espace.
        /// Le mot de passe est libre mais ne peut pas contenir d'espace.
        /// Le pays peut-être vide, on vérifiera qu'il s'agit d'un pays appartenant à la base.
        /// </summary>
        /// <param name="prenom">Le prénom</param>
        /// <param name="nom">Le nom</param>
        /// <param name="login">L'identifiant</param>
        /// <param name="mdp">Le mot de passe</param>
        /// <param name="pays">Le pays</param>
        /// <returns>Retourne un ABONNÉS s'il a été créé, null sinon</returns>
        public static ABONNÉS Inscription(string prenom, string nom, string login, string mdp, string pays)
        {
            ABONNÉS abo = null;
            if (Regex.IsMatch(prenom, "^([A-Z][a-z]*( |-)?)*$") && Regex.IsMatch(nom, "^([A-Z][a-z]*( |-)?)*$")
                && prenom.Length > 0 && prenom.Length <= 32 && nom.Length > 0 && nom.Length <= 32 && login.Length > 0 && login.Length<=32
                && mdp.Length>0 && mdp.Length<=32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$") && Regex.IsMatch(login, "^\\S[a-zA-Z0-9]*\\S$"))
            {
                var logins = (from a in Musique.ABONNÉS
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
                        if (PaysExiste(pays) != null)
                        {
                            abo.PAYS = PaysExiste(pays);
                        }
                    }
                    Musique.ABONNÉS.Add(abo);
                    Musique.SaveChanges();

                }
            }

            return abo;
        }

        /// <summary>
        /// Méthode qui retourne un PAYS à partir d'un nom si celui-ci correspond à un pays dans la base.
        /// </summary>
        /// <param name="nom">Le nom du pays</param>
        /// <returns>Retourne un pays s'il existe dans la base, null sinon</returns>
        public static PAYS PaysExiste(string nom)
        {
            var pays = (from p in Musique.PAYS
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

        /// <summary>
        /// Méthode pour retirer un abonné de la base
        /// </summary>
        /// <param name="a">L'abonné que l'on veut supprimer</param>
        public static void RemoveAbonné(ABONNÉS a)
        {
                Musique.ABONNÉS.Remove(a);
                Musique.SaveChanges();
        }

        /// <summary>
        /// Méthode pour récupérer tout les albums déjà empruntés par un abonné.
        /// </summary>
        /// <param name="id">L'id de l'abonné</param>
        /// <returns>Retourne une liste d'ALBUMS</returns>
        public static List<ALBUMS> GetToutAlbumsEmpruntésParAbonné(ABONNÉS abo)
        {
            var albumsEmpruntés = (from al2 in Musique.ALBUMS
                                   join em1 in Musique.EMPRUNTER
                                   on al2.CODE_ALBUM equals em1.CODE_ALBUM
                                   where em1.CODE_ABONNÉ == abo.CODE_ABONNÉ
                                   select al2).ToList();
            return albumsEmpruntés;
        }

        /// <summary>
        /// Méthode pour récupérer tout les albums en cours d'emprunts.
        /// </summary>
        /// <returns>Retourne une liste d'ALBUMS empruntés</returns>
        public static List<ALBUMS> GetIndisponibles()
        {
            var empruntés = (from al in Musique.ALBUMS
                             join e in Musique.EMPRUNTER
                             on al.CODE_ALBUM equals e.CODE_ALBUM
                             where e.DATE_RETOUR == null
                             select al).ToList();
            return empruntés;
        }

        /// <summary>
        /// Méthode pour récupérer tout les albums.
        /// </summary>
        /// <returns>Retourne la liste de tout les ALBUMS</returns>
        public static List<ALBUMS> GetALBUMSs()
        {
            var albums = (from al in Musique.ALBUMS
                          select al).ToList();
            return albums;
        }

        /// <summary>
        /// Méthode pour récupérer un album selon son id dans la base.
        /// </summary>
        /// <param name="id">L'id de l'album</param>
        /// <returns>Retourne un ALBUMS si l'id trouve une correspondance dans la base, null sinon</returns>
        public static ALBUMS GetAlbumSelonID(int id)
        {
            var album = (from al in Musique.ALBUMS
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

        /// <summary>
        /// Récupère les albums correspondant à un genre (selon son id) dans une liste.
        /// </summary>
        /// <param name="id">L'id du genre</param>
        /// <param name="listeAlbum">La liste d'albums</param>
        /// <returns>Retourne une liste d'ALBUMS correspondant au genre voulu</returns>
        public static List<ALBUMS> GetAlbumsSelonGenreDansListe(GENRES genre, List<ALBUMS> listeAlbum)
        {
            var albums = (from al in listeAlbum
                          where al.CODE_GENRE == genre.CODE_GENRE
                          select al).ToList();
            return albums;
        }

        /// <summary>
        /// Permet de créer un nouvel emprunt à partir d'un album et d'un abonné.
        /// Si l'album a déjà été emprunté par l'abonné, la ligne de l'ancien emprunt dans la base sera supprimée.
        /// </summary>
        /// <param name="ab">L'abonné</param>
        /// <param name="al">L'album</param>
        /// <returns>Retourne une instance d'EMPRUNTER si l'emprunt a été réussi</returns>
        public static EMPRUNTER NouvelEmprunt(ABONNÉS ab, ALBUMS al)
        {
            EMPRUNTER em = null;
            if (!GetIndisponibles().Contains(al))
            {
                DateTime date = DateTime.Now;
                DateTime newDate = date.AddDays(al.GENRES.DÉLAI);
                em = new EMPRUNTER();
                em.CODE_ABONNÉ = ab.CODE_ABONNÉ;
                em.CODE_ALBUM = al.CODE_ALBUM;
                em.DATE_EMPRUNT = date;
                em.DATE_RETOUR_ATTENDUE = newDate;
                EMPRUNTER existant = null;
                foreach (EMPRUNTER e in Musique.EMPRUNTER)
                {
                    if (e.Equals(em))
                    {
                        existant = e;
                    }
                }
                if (existant != null)
                {
                    Musique.EMPRUNTER.Remove(existant);
                    Musique.SaveChanges();
                }
                Musique.EMPRUNTER.Add(em);
                Musique.SaveChanges();
            }
            return em;
        }

        /// <summary>
        /// Même méthode que NouvelEmprunt(ABONNÉS,ALBUMS) sauf qu'ici on peut daté l'emprunt.
        /// Méthode utilisée uniquement dans les tests, pour créer des retards et des abonnés inactifs.
        /// </summary>
        /// <param name="ab">L'abonné</param>
        /// <param name="al">L'album</param>
        /// <param name="dt">La date</param>
        /// <returns></returns>
        public static EMPRUNTER NouvelEmpruntDaté(ABONNÉS ab, ALBUMS al, DateTime dt)
        {
            EMPRUNTER em = null;
            if (!GetIndisponibles().Contains(al))
            {
                DateTime newDate = dt.AddDays(al.GENRES.DÉLAI);
                em = new EMPRUNTER();
                em.CODE_ABONNÉ = ab.CODE_ABONNÉ;
                em.CODE_ALBUM = al.CODE_ALBUM;
                em.DATE_EMPRUNT = dt;
                em.DATE_RETOUR_ATTENDUE = newDate;
                EMPRUNTER existant = null;
                foreach (EMPRUNTER e in Musique.EMPRUNTER)
                {
                    if (e.Equals(em))
                    {
                        existant = e;
                    }
                }
                if (existant != null)
                {
                    Musique.EMPRUNTER.Remove(existant);
                    Musique.SaveChanges();
                }
                Musique.EMPRUNTER.Add(em);
                Musique.SaveChanges();
            }
            return em;
        }

        /// <summary>
        /// Méthode pour rendre un emprunt.
        /// </summary>
        /// <param name="em">L'emprunt à rendre</param>
        public static void RendreEmprunt(EMPRUNTER em)
        {
                DateTime date = DateTime.Now;
                em.DATE_RETOUR = date;
                Musique.SaveChanges();
        }

        /// <summary>
        /// Méthode pour récupérer tout les emprunts de la base.
        /// </summary>
        /// <returns>Retourne la liste des EMPRUNTER</returns>
        public static List<EMPRUNTER> GetEMPRUNTERs()
        {
            var emprunts = (from em in Musique.EMPRUNTER
                            select em).ToList();
            return emprunts;
        }

        /// <summary>
        /// Même méthode que GetEMPRUNTERs() mais cela ne retourne que les emprunts non rendus.
        /// </summary>
        /// <returns>Retourne une liste d'EMPRUNTER</returns>
        public static List<EMPRUNTER> GetEMPRUNTERNonRendus()
        {
            var emprunts = (from em in Musique.EMPRUNTER
                            where em.DATE_RETOUR == null
                            select em).ToList();
            return emprunts;
        }


        /// <summary>
        /// Méthode pour récupérer tout les emprunts d'un abonné
        /// </summary>
        /// <param name="id">L'id de l'abonné</param>
        /// <returns>Retourne une liste d'EMPRUNTER</returns>
        public static List<EMPRUNTER> GetEmpruntsAbonné(ABONNÉS abo)
        {
            var emprunts = (from e in Musique.EMPRUNTER
                            where e.CODE_ABONNÉ == abo.CODE_ABONNÉ
                            select e).ToList();
            return emprunts;
        }

        /// <summary>
        /// Même méthode que GetEmpruntsAbonné(int), mais ne retourne que les emprunts en cours.
        /// </summary>
        /// <param name="id">L'id de l'abonné</param>
        /// <returns>Retourne une liste d'EMPRUNTER</returns>
        public static List<EMPRUNTER> GetEmpruntsEnCoursAbonné(ABONNÉS ab)
        {
            var emprunts = (from e in Musique.EMPRUNTER
                            where e.CODE_ABONNÉ == ab.CODE_ABONNÉ && e.DATE_RETOUR == null
                            select e).ToList();
            return emprunts;
        }

        /// <summary>
        /// Retourne tout les emprunts associés à un album.
        /// </summary>
        /// <param name="id">L'id de l'album</param>
        /// <returns>Retourne une liste d'EMPRUNTER</returns>
        public static List<EMPRUNTER> GetEmpruntsSelonAlbum(ALBUMS al)
        {
            var emprunts = (from e in Musique.EMPRUNTER
                            where e.CODE_ALBUM == al.CODE_ALBUM
                            select e).ToList();
            return emprunts;
        }

        /// <summary>
        /// Méthode qui permet de récupérer le top 10 des albums les plus empruntés depuis le début de l'année dans l'ordre.
        /// Cette méthode n'est utilisée que pour les méthodes GetTop10Albums() et GetTop10Count().
        /// </summary>
        /// <returns>Retourne une liste dynamique, ayant un type anonyme int,int; le premier étant l'id d'un album et le deuxième son nombre d'apparition</returns>
        public static List<dynamic> GetTop10()
        {
            var emprunts = GetEMPRUNTERs();
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

        /// <summary>
        /// Méthode dépendante de GetTop10(), qui extrait les albums de cette dernière.
        /// </summary>
        /// <returns>Retourne une liste d'ALBUMS</returns>
        public static List<ALBUMS> GetTop10Albums()
        {
            List<ALBUMS> top10 = new List<ALBUMS>();
            var liste = GetTop10();
            for (int i = 0; i < liste.Count(); i++)
            {
                top10.Add(GetAlbumSelonID(liste[i].ALBUMS));
            }
            return top10;
        }

        /// <summary>
        /// Méthode dépendante de GetTop10(), qui extrait le nombre d'appartition de chaque album de cette dernière.
        /// </summary>
        /// <returns>Retourne une liste d'entiers</returns>
        public static List<int> GetTop10Count()
        {
            List<int> top10 = new List<int>();
            var liste = GetTop10();
            for (int i = 0; i < liste.Count(); i++)
            {
                top10.Add(liste[i].Count);
            }
            return top10;
        }

        /// <summary>
        /// Méthode pour retourner des suggestions à un abonnés.
        /// Les suggestions consistent en une liste de 9 albums, ayant le/les genres (jusqu'au 3 premiers) le/les plus emprunté/s par l'abonné.
        /// </summary>
        /// <param name="id">L'id de l'abonné</param>
        /// <returns>Retourne une liste d'ALBUMS</returns>
        public static List<ALBUMS> GetSuggestions(ABONNÉS abo)
        {
            var albumsEmpruntés = GetToutAlbumsEmpruntésParAbonné(abo);

            var genres = albumsEmpruntés.GroupBy(g => g.GENRES, (key, values) => new { GENRES = key, Count = values.Count() });
            var genresTriés = genres.OrderByDescending(g => g.Count).ToList();

            var albums = GetALBUMSs();
            var listeAlbum = albums.Except(albumsEmpruntés).ToList();
            List<ALBUMS> albumsRecommandés = new List<ALBUMS>();
            if (genresTriés.Count >= 1)
            {
                GENRES premierGenre = genresTriés[0].GENRES;
                
                if (genresTriés.Count >= 2)
                {
                    GENRES deuxiemeGenre = genresTriés[1].GENRES;
                    
                    if (genresTriés.Count >= 3)
                    {
                        GENRES troisiemeGenre = genresTriés[2].GENRES;
                        var albumsRecommandés1 = GetAlbumsSelonGenreDansListe(premierGenre, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés1.GetRange(0, 3));
                        var albumsRecommandés2 = GetAlbumsSelonGenreDansListe(deuxiemeGenre, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés2.GetRange(0, 3));
                        var albumsRecommandés3 = GetAlbumsSelonGenreDansListe(troisiemeGenre, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés3.GetRange(0, 3));
                    } else
                    {
                        var albumsRecommandés1 = GetAlbumsSelonGenreDansListe(premierGenre, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés1.GetRange(0, 5));
                        var albumsRecommandés2 = GetAlbumsSelonGenreDansListe(deuxiemeGenre, listeAlbum);
                        albumsRecommandés.AddRange(albumsRecommandés2.GetRange(0, 4));
                    }
                } else
                {
                    var albumsRecommandés1 = GetAlbumsSelonGenreDansListe(premierGenre, listeAlbum);
                    albumsRecommandés.AddRange(albumsRecommandés1.GetRange(0, 9));
                }

            }
            return albumsRecommandés;
        }

        /// <summary>
        /// Vérifie qu'un emprunt n'est pas déjà été prolongé
        /// </summary>
        /// <param name="emprunt">L'emprunt à vérifier</param>
        /// <returns>Retourne true s'il n'a pas été prolongé, false sinon </returns>
        public static bool EstProlongeable(EMPRUNTER emprunt)
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

        /// <summary>
        /// Prolonge un emprunt s'il est prolongeable.
        /// </summary>
        /// <param name="emprunt">L'emprunt à prolonger</param>
        /// <returns>Retourne l'EMPRUNTER passé en argument</returns>
        public static EMPRUNTER Prolongation(EMPRUNTER emprunt)
        {
            if (EstProlongeable(emprunt))
            {
                emprunt.DATE_RETOUR_ATTENDUE = emprunt.DATE_RETOUR_ATTENDUE.AddMonths(1);
                Musique.SaveChanges();
            }
            return emprunt;
        }

        /// <summary>
        /// Récupère l'emprunt en cours associé à un album s'il y en a un.
        /// </summary>
        /// <param name="al">L'album dont on veut récupérer l'emprunt</param>
        /// <returns>Retourne l'EMPRUNTER en cours lié à l'album s'il existe, null sinon</returns>
        public static EMPRUNTER GetEmpruntAlbumEnCours(ALBUMS al)
        {
            var emprunts = (from e in Musique.EMPRUNTER
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

        /// <summary>
        /// Méthode pour récupérer la liste des emprunts en cours prolongés.
        /// </summary>
        /// <returns>Retourne une liste d'EMPRUNTER</returns>
        public static List<EMPRUNTER> GetProlongés()
        {
            List<EMPRUNTER> liste = new List<EMPRUNTER>();
            var listeEmpruntés = GetEMPRUNTERNonRendus();
            foreach (EMPRUNTER em in listeEmpruntés)
            {
                if (!EstProlongeable(em))
                {
                    liste.Add(em);
                }
            }
            return liste.OrderBy(em => em.DATE_EMPRUNT).ToList();
        }

        /// <summary>
        /// Méthode pour récupérer les abonnés ayant un retarde d'au moins 10 jours sur le rendu d'un emprunt.
        /// </summary>
        /// <returns>Retourne une liste d'ABONNÉS</returns>
        public static List<ABONNÉS> GetRetardataires()
        {
            var emprunts = GetEMPRUNTERNonRendus();
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

        /// <summary>
        /// Méthode pour récupérer la liste des abonnés n'ayant pas fait d'emprunts depuis au moins un an.
        /// </summary>
        /// <returns>Retourne une liste d'ABONNÉS inactifs</returns>
        public static List<ABONNÉS> GetFantomes()
        {
            List<ABONNÉS> fantome = new List<ABONNÉS>();
            var abos = GetABONNÉSs();

            foreach (ABONNÉS abo in abos)
            {
                var emprunts = GetEmpruntsAbonné(abo);

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

        /// <summary>
        /// Méthode pour supprimer un abonné inactif.
        /// </summary>
        /// <param name="ab">L'abonné à supprimer</param>
        public static void PurgerUnFantome(ABONNÉS ab)
        {
            if (GetFantomes().Contains(ab))
            {
                RemoveAbonné(ab);
            }
        }

        /// <summary>
        /// Méthode pour supprimer tout les inactifs.
        /// </summary>
        public static void PurgerFantomes()
        {
            foreach (ABONNÉS a in GetFantomes())
            {
                PurgerUnFantome(a);
            }
        }

        /// <summary>
        /// Méthode pour supprimer un emprunt de la base.
        /// </summary>
        /// <param name="e">L'emprunt à supprimer</param>
        public static void SupprimerEmprunt(EMPRUNTER e)
        {
                Musique.EMPRUNTER.Remove(e);
                Musique.SaveChanges();
        }

        /// <summary>
        /// Méthode pour récupérer la liste des albums n'ayant pas été empruntés depuis un an ou plus.
        /// </summary>
        /// <returns>Une liste d'ALBUMS non-empruntés récemment</returns>
        public static List<ALBUMS> GetAlbumsNonEmpruntés()
        {
            var albums = GetALBUMSs();
            List<ALBUMS> albumsNonEmpruntés = new List<ALBUMS>();
            foreach (ALBUMS al in albums)
            {
                var emprunts = GetEmpruntsSelonAlbum(al);

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

        /// <summary>
        /// Ajoute un emprunt dans la base
        /// </summary>
        /// <param name="e">L'emprunt à ajouter</param>
        public static void AjouterEmprunt(EMPRUNTER e)
        {
            Musique.EMPRUNTER.Add(e);
            Musique.SaveChanges();
        }

        /// <summary>
        /// Crypte un mot de passe avec un code césar de 1.
        /// </summary>
        /// <param name="mdp">Le mot de passe à crypter</param>
        /// <returns>Le mot de passe crypté</returns>
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

        /// <summary>
        /// Méthode vérifiant qu'un mot de passe est bien celui d'un abonné.
        /// </summary>
        /// <param name="mdp">Le mot de passe</param>
        /// <param name="abo">L'abonné</param>
        /// <returns>Retourne true si le mot de passe est celui de l'abonné, false sinon</returns>
        public static bool VerificationMDP(string mdp, ABONNÉS abo)
        {
            if (mdp.Length > 0 && mdp.Length <= 32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$"))
            {
                string crypted = Crypter(mdp);
                var mdpTest = (from a in Musique.ABONNÉS
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

        /// <summary>
        /// Méthode pour changer le mot de passe d'un abonné.
        /// </summary>
        /// <param name="mdp">Le nouveau mot de passe</param>
        /// <param name="abo">L'abonné</param>
        /// <returns>Retourne le nouveau mot de passe s'il a été changé, null sinon</returns>
        public static string ChangerMDP(string mdp, ABONNÉS abo)
        {
            if (mdp.Length > 0 && mdp.Length <= 32 && Regex.IsMatch(mdp, "^\\S\\w*\\S$"))
            {
                abo.PASSWORD_ABONNÉ = Crypter(mdp);
                Musique.SaveChanges();
                return mdp;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Changer le pays d'un abonné
        /// </summary>
        /// <param name="p">Le pays</param>
        /// <param name="abo">L'abonné</param>
        /// <returns>Retourne le PAYS s'il a été changé, null sinon</returns>
        public static PAYS ChangerPays(PAYS p, ABONNÉS abo)
        {
            if (PaysExiste(p.NOM_PAYS) != null)
            {
                abo.PAYS = p;
                Musique.SaveChanges();
                return p;
            } else
            {
                return null;
            }
        }

        /// <summary>
        /// Récupère la liste des albums manquant à un casier dans une allée.
        /// </summary>
        /// <param name="allee">L'allée</param>
        /// <param name="casier">Le casier</param>
        /// <returns>La liste des ALBUMS manquants</returns>
        public static List<ALBUMS> GetAlbumManquantCasier(string allee, int casier)
        {          

            var empruntés = (from al in Musique.ALBUMS
                             join e in Musique.EMPRUNTER
                             on al.CODE_ALBUM equals e.CODE_ALBUM
                             where al.ALLÉE_ALBUM == allee && al.CASIER_ALBUM == casier 
                             && e.DATE_RETOUR == null 
                             select al).ToList();
            return empruntés;
        }

        /// <summary>
        /// Méthode pour décrypter un mot de passe selon un code césar 1.
        /// </summary>
        /// <param name="mdp">Le mot de passe à décrypter</param>
        /// <returns>Le mot de passe décrypté</returns>
        public static string Decrypter(String mdp)
        {
            char[] crypted = new char[mdp.Length];
            int i = 0;
            foreach (char c in mdp.ToCharArray())
            {
                crypted[i] = (char)((int)c - 1);
                i++;
            }
            return new string(crypted);
        }
    }
}
