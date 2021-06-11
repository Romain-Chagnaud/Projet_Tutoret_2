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
        public void TestProlongés()
        {
            ChargerMusiqueEntities();
            //On vérifie que la méthode nous retourne que des emprunts non-prolongeables
            var liste = GetProlongés();
            foreach (EMPRUNTER em in liste)
            {
                Assert.IsFalse(EstProlongeable(em));
            }
            
            //On rajoute un nouvel emprunt
            ABONNÉS ab = Connexion("lp", "lp");
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            
            //On vérifie que l'emprunt n'est pas dans la liste
            liste = GetProlongés();
            Assert.IsFalse(liste.Contains(e));

            //On vérifie que l'emprunt, maintenant prolongé, est dans la liste
            Prolongation(e);
            liste = GetProlongés();
            Assert.IsTrue(liste.Contains(e));
        }

        //US 5
        [TestMethod]
        public void TestRetardataires()
        {
            ChargerMusiqueEntities();
            //On créé un nouvel utilisateur qui n'aura donc pas de retard
            ABONNÉS ab = Inscription("Jean","Reno","Leon","onimusha","");
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];

            //Cas d'un nouvel emprunt (pas de retard)
            EMPRUNTER em = NouvelEmpruntDaté(ab, a, DateTime.Now);
            var listeRetards = GetRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            RendreEmprunt(em);


            //Cas d'un retard de moins de 10 jours ( 5 jours )
            DateTime d = DateTime.Now.AddDays(-(a.GENRES.DÉLAI+5));
            em = NouvelEmpruntDaté(ab, a, d);
            listeRetards = GetRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            RendreEmprunt(em);

            //Cas d'un retard de 10 jours ou plus
            d = DateTime.Now.AddDays(-(a.GENRES.DÉLAI + 10));
            em = NouvelEmpruntDaté(ab, a, d);
            listeRetards = GetRetardataires();
            Assert.IsTrue(listeRetards.Contains(ab));
            RendreEmprunt(em);

            //Restoration
            RemoveAbonné(ab);
        }

        //US 6
        [TestMethod]
        public void TestFantômes()
        {
            ChargerMusiqueEntities();

            //On créé un nouvel abonné
            ABONNÉS ab = Inscription("Jean", "Reno", "Leon", "onimusha","");
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];

            //Cas nouvel abonné, n'est pas un fantôme
            var fantomes = GetFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            //Cas l'abonné a un emprunt de plus d'un an
            DateTime d = DateTime.Now.AddDays(-366);
            EMPRUNTER em = NouvelEmpruntDaté(ab, a, d);
            fantomes = GetFantomes();
            Assert.IsTrue(fantomes.Contains(ab));

            //Cas l'abonné fantôme a un emprunt plus récent
            a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            d = DateTime.Now.AddDays(-128);
            EMPRUNTER em1 = NouvelEmpruntDaté(ab, a, d);
            fantomes = GetFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            //Restoration des emprunts
            RendreEmprunt(em);


            //Cas l'abonné fantôme est purgé
            fantomes = GetFantomes();
            Assert.IsFalse(fantomes.Contains(ab));
            PurgerFantomes();
            fantomes = GetFantomes();
            Assert.IsFalse(fantomes.Contains(ab));
        }

        //US 7
        [TestMethod]
        public void TestTop10()
        {
            ChargerMusiqueEntities();
            List<ALBUMS> top10 = GetTop10Albums();

            //Vérification un album devient plus populaire
            List<ABONNÉS> abonnés = GetABONNÉSs();
            List<EMPRUNTER> empruntsTempo = new List<EMPRUNTER>();
            
            ALBUMS albumTop10 = top10[9];
            //Ici on rend l'album numéro 10 dans le cas où il est emprunté
            EMPRUNTER e = GetEmpruntAlbumEnCours(albumTop10);
            if (e != null)
            {
                RendreEmprunt(e);
            }
            //On le fait emprunter par tout les abonnés
            foreach (ABONNÉS ab in abonnés)
            {
                e = NouvelEmprunt(ab, albumTop10);
                empruntsTempo.Add(e);
                RendreEmprunt(e);
            }

            //Et on crée un abonné qui va l'emprunter aussi pour être sûr qu'il n'y ait pas d'égalité
            ABONNÉS abo = Inscription("Changer", "Top", "topchanger", "top","");
            e = NouvelEmprunt(abo, albumTop10);
            empruntsTempo.Add(e);
            RendreEmprunt(e);

            //On actualise le top 10
            top10 = GetTop10Albums();
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
                SupprimerEmprunt(em);
            }
            RemoveAbonné(abo);
        }

        //US 8
        [TestMethod]
        public void TestAlbumsNonEmpruntés()
        {
            ChargerMusiqueEntities();
            
            //On efface les emprunts liés à un album
            ALBUMS a = GetALBUMSs()[0];
            var emprunts = GetEmpruntsSelonAlbum(a);
            List<EMPRUNTER> empruntsEffacés = new List<EMPRUNTER>();
            foreach(EMPRUNTER emp in emprunts)
            {
                empruntsEffacés.Add(emp);
                SupprimerEmprunt(emp);
            }

            //Cas d'un album non empruntés
            List<ALBUMS> nonEmpruntés = GetAlbumsNonEmpruntés();
            Assert.IsTrue(nonEmpruntés.Contains(a));

            //Cas l'album a un emprunt d'il y a plus d'un an;
            ABONNÉS ab = Connexion("lp", "lp");
            DateTime dateTime = DateTime.Now.AddDays(-366);
            EMPRUNTER em = NouvelEmpruntDaté(ab, a, dateTime);
            nonEmpruntés = GetAlbumsNonEmpruntés();
            Assert.IsTrue(nonEmpruntés.Contains(a));
            RendreEmprunt(em);

            //Cas l'album a un emprunt d'il y a moins d'un an
            dateTime = DateTime.Now.AddDays(-128);
            em = NouvelEmpruntDaté(ab, a, dateTime);
            nonEmpruntés = GetAlbumsNonEmpruntés();
            Assert.IsFalse(nonEmpruntés.Contains(a));
            RendreEmprunt(em);

            //Restoration
            SupprimerEmprunt(em);
            foreach(EMPRUNTER emp1 in empruntsEffacés)
            {
                AjouterEmprunt(emp1);
            }
        }

        //US 12
        [TestMethod]
        public void TestAfficherAbonnés()
        {
            ChargerMusiqueEntities();
            var abonnés = GetABONNÉSs();
            ABONNÉS ab = Inscription("Abc", "Abc", "abc", "abc","");
            //Le nouvel abonné n'est pas dans la liste pré-inscription
            Assert.IsFalse(abonnés.Contains(ab));

            //Le nouvel abonné est dans la liste
            abonnés = GetABONNÉSs();
            Assert.IsTrue(abonnés.Contains(ab));

            //Restoration
            RemoveAbonné(ab);
        }
    }
}
