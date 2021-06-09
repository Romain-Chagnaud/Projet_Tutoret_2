using Maquette;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static Maquette.Outil;

namespace PTTests
{
    [TestClass]
    public class AdministrateurTest
    {
        //US 4
        [TestMethod]
        public void testProlongés()
        {
            chargerMusiqueEntities();
            //On vérifie que la méthode nous retourne que des emprunts non-prolongeables
            var liste = getProlongés();
            foreach (EMPRUNTER em in liste)
            {
                Assert.IsFalse(estProlongeable(em));
            }
            
            //On rajoute un nouvel emprunt
            ABONNÉS ab = connexion("lp", "lp");
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            EMPRUNTER e = nouvelEmprunt(ab, a);
            
            //On vérifie que l'emprunt n'est pas dans la liste
            liste = getProlongés();
            Assert.IsFalse(liste.Contains(e));

            //On vérifie que l'emprunt, maintenant prolongé, est dans la liste
            prolongation(e);
            liste = getProlongés();
            Assert.IsTrue(liste.Contains(e));
        }

        //US 5
        [TestMethod]
        public void testRetardataires()
        {
            chargerMusiqueEntities();
            //On créé un nouvel utilisateur qui n'aura donc pas de retard
            ABONNÉS ab = inscription("Jean","Reno","Leon","onimusha");
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];

            //Cas d'un nouvel emprunt (pas de retard)
            EMPRUNTER em = nouvelEmpruntDaté(ab, a, DateTime.Now);
            var listeRetards = getRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            rendreEmprunt(em);


            //Cas d'un retard de moins de 10 jours ( 5 jours )
            DateTime d = DateTime.Now.AddDays(-(a.GENRES.DÉLAI+5));
            em = nouvelEmpruntDaté(ab, a, d);
            listeRetards = getRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            rendreEmprunt(em);

            //Cas d'un retard de 10 jours ou plus
            d = DateTime.Now.AddDays(-(a.GENRES.DÉLAI + 10));
            em = nouvelEmpruntDaté(ab, a, d);
            listeRetards = getRetardataires();
            Assert.IsTrue(listeRetards.Contains(ab));
            rendreEmprunt(em);

            //Restoration
            removeAbonné(ab);
        }

        //US 6
        [TestMethod]
        public void testFantômes()
        {
            chargerMusiqueEntities();

            //On créé un nouvel abonné
            ABONNÉS ab = inscription("Jean", "Reno", "Leon", "onimusha");
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];

            //Cas nouvel abonné, n'est pas un fantôme
            var fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            //Cas l'abonné a un emprunt de plus d'un an
            DateTime d = DateTime.Now.AddDays(-366);
            EMPRUNTER em = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsTrue(fantomes.Contains(ab));

            //Cas l'abonné fantôme a un emprunt plus récent
            a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            d = DateTime.Now.AddDays(-128);
            EMPRUNTER em1 = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            //Restoration des emprunts
            rendreEmprunt(em);
            rendreEmprunt(em1);

            //Cas l'abonné fantôme est purgé
            d = DateTime.Now.AddDays(-366);
            em = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsTrue(fantomes.Contains(ab));
            purgerFantomes();
            fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));
        }

        //US 7
        [TestMethod]
        public void testTop10()
        {
            chargerMusiqueEntities();
            List<ALBUMS> top10 = getTop10();

            //Vérification un album devient plus populaire
            List<ABONNÉS> abonnés = getABONNÉSs();
            List<EMPRUNTER> empruntsTempo = new List<EMPRUNTER>();
            
            ALBUMS albumTop10 = top10[9];
            //Ici on rend l'album numéro 10 dans le cas où il est emprunté
            EMPRUNTER e = getEmpruntAlbumEnCours(albumTop10);
            if (e != null)
            {
                rendreEmprunt(e);
            }
            //On le fait emprunter par tout les abonnés
            foreach (ABONNÉS ab in abonnés)
            {
                e = nouvelEmprunt(ab, albumTop10);
                empruntsTempo.Add(e);
                rendreEmprunt(e);
            }

            //Et on crée un abonné qui va l'emprunter aussi pour être sûr qu'il n'y ait pas d'égalité
            ABONNÉS abo = inscription("Changer", "Top", "topchanger", "top");
            e = nouvelEmprunt(abo, albumTop10);
            empruntsTempo.Add(e);
            rendreEmprunt(e);

            //On actualise le top 10
            top10 = getTop10();
            //On vérifie que l'album a changé de place
            Assert.IsTrue(top10[9] != albumTop10);
            //On vérifie que l'album est numéro 1
            int place = 0;
            bool albumTop10Trouvé = false;
            while(place < 10 && !albumTop10Trouvé)
            {
                if (top10[place] == albumTop10)
                {
                    albumTop10Trouvé = true;
                } else
                {
                    place++;
                }
            }
            Assert.IsTrue(place == 0);

            //On supprime l'abonné et on efface les emprunts pour la stabilité du test
           
            foreach(EMPRUNTER em in empruntsTempo)
            {
                supprimerEmprunt(em);
            }
            removeAbonné(abo);
        }

        //US 8
        [TestMethod]
        public void testAlbumsNonEmpruntés()
        {
            chargerMusiqueEntities();
            
            //On efface les emprunts liés à un album
            ALBUMS a = getALBUMSs()[0];
            var emprunts = getEmpruntsSelonAlbum(a.CODE_ALBUM);
            List<EMPRUNTER> empruntsEffacés = new List<EMPRUNTER>();
            foreach(EMPRUNTER emp in emprunts)
            {
                empruntsEffacés.Add(emp);
                supprimerEmprunt(emp);
            }

            //Cas d'un album non empruntés
            List<ALBUMS> nonEmpruntés = getAlbumsNonEmpruntés();
            Assert.IsFalse(nonEmpruntés.Contains(a));

            //Cas l'album a un emprunt d'il y a plus d'un an;
            ABONNÉS ab = connexion("lp", "lp");
            DateTime dateTime = DateTime.Now.AddDays(-366);
            EMPRUNTER em = nouvelEmpruntDaté(ab, a, dateTime);
            nonEmpruntés = getAlbumsNonEmpruntés();
            Assert.IsTrue(nonEmpruntés.Contains(a));
            rendreEmprunt(em);

            //Cas l'album a un emprunt d'il y a moins d'un an
            dateTime = DateTime.Now.AddDays(-128);
            em = nouvelEmpruntDaté(ab, a, dateTime);
            nonEmpruntés = getAlbumsNonEmpruntés();
            Assert.IsFalse(nonEmpruntés.Contains(a));
            rendreEmprunt(em);

            //Restoration
            supprimerEmprunt(em);
            foreach(EMPRUNTER emp1 in empruntsEffacés)
            {
                ajouterEmprunt(emp1);
            }
        }

        //US 12
        [TestMethod]
        public void testAfficherAbonnés()
        {
            chargerMusiqueEntities();
            var abonnés = getABONNÉSs();
            ABONNÉS ab = inscription("abc", "abc", "abc", "abc");
            //Le nouvel abonné n'est pas dans la liste pré-inscription
            Assert.IsFalse(abonnés.Contains(ab));

            //Le nouvel abonné est dans la liste
            abonnés = getABONNÉSs();
            Assert.IsTrue(abonnés.Contains(ab));

            //Restoration
            removeAbonné(ab);
        }
    }
}
