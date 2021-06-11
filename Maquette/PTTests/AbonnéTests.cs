using Maquette;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static Maquette.Outil;
namespace PTTests
{
    [TestClass]
    public class AbonnéTests
    {
        //US 1
        [TestMethod]
        public void TestInscription()
        {
            ChargerMusiqueEntities();

            //Cas 1 : nouvel abonné avec login original, Résultat : abonné créé
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS abonnéTrue = Inscription(prenom, nom, login, mdp, "France");
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : nouvel abonné avec login existant, Résultat : abonné non créé
            nom = "Belmont";
            prenom = "Simon";
            login = "Belmont";
            mdp = "draculakiller";
            ABONNÉS abonnéFalse = Inscription(prenom, nom, login, mdp, "Transylvanie");
            Assert.IsTrue(abonnéFalse == null);

            //Cas 3 : nouvel abonné avec nom et prénom existant, Résultat : abonné créé
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont2";
            mdp = "belmont123";
            ABONNÉS abonnéTrue2 = Inscription(prenom, nom, login, mdp, "");
            Assert.IsFalse(abonnéTrue2 == null);

            //Cas 4 : un nouvel abonné avec un nom et prénom composé, Résultat : abonné crée
            nom = "Lafon-Anteuil";
            prenom = "Jean-Paul";
            login = "Lafeuille";
            mdp = "azerty";
            ABONNÉS abonnéTrue3 = Inscription(prenom, nom, login, mdp, "");
            Assert.IsFalse(abonnéTrue3 == null);

            //Cas 5 : un nouvel abonné avec coordonnés vides, Résultat : abonné non-crée
            nom = "";
            prenom = "";
            login = "";
            mdp = "";
            abonnéFalse = Inscription(prenom, nom, login, mdp, "");
            Assert.IsTrue(abonnéFalse == null);

            //Cas 6 : un nouvel abonné avec espaces dans login et mot de passe : abonné non-crée
            nom = "Jean";
            prenom = "Eude";
            login = "Je suis Jean";
            mdp = "Eude Dip";
            abonnéFalse = Inscription(prenom, nom, login, mdp, "");
            Assert.IsTrue(abonnéFalse == null);

            //Cas 7 : un nouvel abonné avec des espaces en coordonnés : abonné non-crée
            nom = "   ";
            prenom = "   ";
            login = "   ";
            mdp = "   ";
            abonnéFalse = Inscription(prenom, nom, login, mdp, "");
            Assert.IsTrue(abonnéFalse == null);

            //Cas 8 : un nouvel abonné avec un pays qui n'existe pas : abonné crée
            nom = "Nedakh";
            prenom = "Kidagakash ";
            login = "Kida";
            mdp = "Milo";
            ABONNÉS abonnéTrue4 = Inscription(prenom, nom, login, mdp, "Atlantide");
            Assert.IsFalse(abonnéTrue == null);


            //Restoration
            RemoveAbonné(abonnéTrue);
            RemoveAbonné(abonnéTrue2);
            RemoveAbonné(abonnéTrue3);
            RemoveAbonné(abonnéTrue4);
        }

        //US 1
        [TestMethod]
        public void TestConnexion()
        {
            ChargerMusiqueEntities();
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS abonnéTrue = Inscription(prenom, nom, login, mdp, "France");
            //Cas 1 : connexion d'un abonné existant, résultat : connexion réussi
            abonnéTrue = Connexion("Belmont", "belmont123");
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : connexion d'un abonné non-existant, résultat : connexion échoué
            ABONNÉS abonnéFalse = Connexion("random1645551", "random165455");
            Assert.IsTrue(abonnéFalse == null);
            RemoveAbonné(abonnéTrue);
        }

        //US 1
        [TestMethod]
        public void TestEmprunt()
        {
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS ab = Inscription(prenom, nom, login, mdp, "France");
            ChargerMusiqueEntities();
            //Emprunt numéro 1 pour lp
            ab = Connexion("Belmont", "belmont123");
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            Assert.IsFalse(e == null);

            //Test d'emprunt du même album par le même utilisateur sans l'avoir rendu
            EMPRUNTER e1 = NouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);

            //Rendu de l'emprunt
            RendreEmprunt(e);

            //Emprunt numéro 2 du même album pour lp après l'avoir rendu
            e = NouvelEmprunt(ab, a);
            Assert.IsFalse(e == null);

            //Emprunt du même album par un autre utilisateur
            ab = Inscription("Fernand", "Constandin", "Fernaldin", "ferni","");
            e1 = NouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);
            
            //Restoration
            RendreEmprunt(e);
            RemoveAbonné(ab);
        }

        //US 2
        [TestMethod]
        public void TestEmpruntésEnCours()
        {
            ChargerMusiqueEntities();
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS ab = Inscription(prenom, nom, login, mdp, "France");
            //Vérification que les emprunts sont tous liés à l'utilisateurs et qu'ils ne sont tous pas rendus
            ab = Connexion("Belmont", "belmont123");

            var liste = GetEmpruntsEnCoursAbonné(ab);
            foreach (EMPRUNTER em in liste)
            {
                Assert.IsTrue(em.CODE_ABONNÉ == ab.CODE_ABONNÉ && em.DATE_RETOUR == null);
            }

            //Ajout d'un emprunt
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            liste = GetEmpruntsEnCoursAbonné(ab);
            Assert.IsTrue(liste.Contains(e));

            //Rendu d'un emprunt
            RendreEmprunt(e);
            liste = GetEmpruntsEnCoursAbonné(ab);
            Assert.IsTrue(!liste.Contains(e));
            RemoveAbonné(ab);
        }

        //US 3 + 9
        [TestMethod]
        public void TestProlongation()
        {
            ChargerMusiqueEntities();
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS ab = Inscription(prenom, nom, login, mdp, "France");
            ab = Connexion("Belmont", "belmont123");

            //Nouvel emprunt
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            var liste = GetEmpruntsEnCoursAbonné(ab);

            //Prolongement d'un nouvel emprunt
            Assert.IsTrue(EstProlongeable(e));
            DateTime ancienne = e.DATE_RETOUR_ATTENDUE;
            Prolongation(e);
            Assert.IsFalse(e.DATE_RETOUR_ATTENDUE == ancienne);

            //Tentative de re-prolongement
            ancienne = e.DATE_RETOUR_ATTENDUE;
            Assert.IsFalse(EstProlongeable(e));
            Prolongation(e);
            Assert.IsTrue(e.DATE_RETOUR_ATTENDUE == ancienne);

            //Vérification prolongement de tout les emprunts
            foreach (EMPRUNTER emprunt in liste)
            {
                Prolongation(emprunt);
            }
            foreach (EMPRUNTER emprunt in liste)
            {
                Assert.IsFalse(EstProlongeable(emprunt));
            }

            RendreEmprunt(e);
            RemoveAbonné(ab);
        }

        //US 10
        [TestMethod]
        public void TestSuggestions()
        {
            ChargerMusiqueEntities();
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS ab = Inscription(prenom, nom, login, mdp, "France");
            ab = Connexion("Belmont", "belmont123");

            //On récupère la liste de tous les emprunts déjà réalisés de l'abonné, et des suggestions qui lui sont proposés
            var liste = GetEmpruntsAbonné(ab);
            var suggestion = GetSuggestions(ab);

            //On récupère la liste des albums et de leurs genres des emprunts de l'abonné
            HashSet<GENRES> genres = new HashSet<GENRES>();
            List<ALBUMS> albumsEmpruntés = new List<ALBUMS>();
            foreach (EMPRUNTER e in liste)
            {
                genres.Add(e.ALBUMS.GENRES);
                albumsEmpruntés.Add(e.ALBUMS);
            }

            //On vérifie que les suggestions ne contient que des albums jamais empruntés et des genres déjà empruntés
            foreach (var a in suggestion)
            {
                    Assert.IsTrue(genres.Contains(a.GENRES));
                    Assert.IsFalse(albumsEmpruntés.Contains(a));
            }

            //On ajoute un nouvel emprunt
            ALBUMS al = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER em = NouvelEmprunt(ab, al);
            liste = GetEmpruntsAbonné(ab);
            suggestion = GetSuggestions(ab);

            //On vérifie que le nouvel emprunt est bien dans la liste des emprunts
            Assert.IsTrue(liste.Contains(em));

            //On ajoute le genre et l'album de l'emprunts dans les listes correspondantes
            genres.Add(em.ALBUMS.GENRES);
            albumsEmpruntés.Add(em.ALBUMS);
            //Puis on revérifie
            foreach (var a in suggestion)
            {
                    Assert.IsTrue(genres.Contains(a.GENRES));
                    Assert.IsFalse(albumsEmpruntés.Contains(a));
            }
            RemoveAbonné(ab);
        }
    }
}
