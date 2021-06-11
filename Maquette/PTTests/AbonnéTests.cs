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
        public void testInscription()
        {
            ChargerMusiqueEntities();

            //Cas 1 : nouvel abonné avec login original, Résultat : abonné créé
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS abonnéTrue = Inscription(prenom, nom, login, mdp, "");
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : nouvel abonné avec login existant, Résultat : abonné non créé
            nom = "Belmont";
            prenom = "Simon";
            login = "Belmont";
            mdp = "draculakiller";
            ABONNÉS abonnéFalse = Inscription(prenom, nom, login, mdp, "");
            Assert.IsTrue(abonnéFalse == null);

            //Cas 3 : nouvel abonné avec nom et prénom existant, Résultat : abonné créé
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont2";
            mdp = "belmont123";
            ABONNÉS abonnéTrue2 = Inscription(prenom, nom, login, mdp, "");
            Assert.IsFalse(abonnéTrue2 == null);

            //Restoration
            RemoveAbonné(abonnéTrue);
            RemoveAbonné(abonnéTrue2);
        }

        //US 1
        [TestMethod]
        public void testConnexion()
        {
            ChargerMusiqueEntities();

            //Cas 1 : connexion d'un abonné existant, résultat : connexion réussi
            ABONNÉS abonnéTrue = Connexion("lp", "lp");
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : connexion d'un abonné non-existant, résultat : connexion échoué
            ABONNÉS abonnéFalse = Connexion("random1645551", "random165455");
            Assert.IsTrue(abonnéFalse == null);

        }

        //US 1
        [TestMethod]
        public void testEmprunt()
        {
            ChargerMusiqueEntities();
            //Emprunt numéro 1 pour lp
            ABONNÉS ab = Connexion("lp", "lp");
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
        public void testEmpruntésEnCours()
        {
            ChargerMusiqueEntities();
            //Vérification que les emprunts sont tous liés à l'utilisateurs et qu'ils ne sont tous pas rendus
            ABONNÉS ab = Connexion("lp", "lp");

            var liste = GetEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            foreach (EMPRUNTER em in liste)
            {
                Assert.IsTrue(em.CODE_ABONNÉ == ab.CODE_ABONNÉ && em.DATE_RETOUR == null);
            }

            //Ajout d'un emprunt
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            liste = GetEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            Assert.IsTrue(liste.Contains(e));

            //Rendu d'un emprunt
            RendreEmprunt(e);
            liste = GetEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            Assert.IsTrue(!liste.Contains(e));
        }

        //US 3 + 9
        [TestMethod]
        public void testProlongation()
        {
            ChargerMusiqueEntities();
            ABONNÉS ab = Connexion("lp", "lp");

            //Nouvel emprunt
            ALBUMS a = GetALBUMSs().Except(GetIndisponibles()).ToList()[0];
            EMPRUNTER e = NouvelEmprunt(ab, a);
            var liste = GetEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);

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

        }

        //US 10
        [TestMethod]
        public void testSuggestions()
        {
            ChargerMusiqueEntities();
            ABONNÉS ab = Connexion("lp", "lp");

            //On récupère la liste de tous les emprunts déjà réalisés de l'abonné, et des suggestions qui lui sont proposés
            var liste = GetEmpruntsAbonné(ab.CODE_ABONNÉ);
            var suggestion = GetSuggestions(ab.CODE_ABONNÉ);

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
            liste = GetEmpruntsAbonné(ab.CODE_ABONNÉ);
            suggestion = GetSuggestions(ab.CODE_ABONNÉ);

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
        }
    }
}
