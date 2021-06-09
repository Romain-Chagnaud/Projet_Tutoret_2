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
            chargerMusiqueEntities();

            //Cas 1 : nouvel abonné avec login original, Résultat : abonné créé
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS abonnéTrue = inscription(prenom, nom, login, mdp);
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : nouvel abonné avec login existant, Résultat : abonné non créé
            nom = "Belmont";
            prenom = "Simon";
            login = "Belmont";
            mdp = "draculakiller";
            ABONNÉS abonnéFalse = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonnéFalse == null);

            //Cas 3 : nouvel abonné avec nom et prénom existant, Résultat : abonné créé
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont2";
            mdp = "belmont123";
            ABONNÉS abonnéTrue2 = inscription(prenom, nom, login, mdp);
            Assert.IsFalse(abonnéTrue2 == null);

            //Restoration
            removeAbonné(abonnéTrue);
            removeAbonné(abonnéTrue2);
        }

        //US 1
        [TestMethod]
        public void testConnexion()
        {
            chargerMusiqueEntities();

            //Cas 1 : connexion d'un abonné existant, résultat : connexion réussi
            ABONNÉS abonnéTrue = connexion("lp", "lp");
            Assert.IsFalse(abonnéTrue == null);

            //Cas 2 : connexion d'un abonné non-existant, résultat : connexion échoué
            ABONNÉS abonnéFalse = connexion("random1645551", "random165455");
            Assert.IsTrue(abonnéFalse == null);

        }

        //US 1
        [TestMethod]
        public void testEmprunt()
        {
            chargerMusiqueEntities();
            //Emprunt numéro 1 pour lp
            ABONNÉS ab = connexion("lp", "lp");
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            EMPRUNTER e = nouvelEmprunt(ab, a);
            Assert.IsFalse(e == null);

            //Test d'emprunt du même album par le même utilisateur sans l'avoir rendu
            EMPRUNTER e1 = nouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);

            //Rendu de l'emprunt
            rendreEmprunt(e);

            //Emprunt numéro 2 du même album pour lp après l'avoir rendu
            e = nouvelEmprunt(ab, a);
            Assert.IsFalse(e == null);

            //Emprunt du même album par un autre utilisateur
            ab = inscription("Fernand", "Constandin", "Fernaldin", "ferni");
            e1 = nouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);
            
            //Restoration
            rendreEmprunt(e);
            removeAbonné(ab);
        }

        //US 2
        [TestMethod]
        public void testEmpruntésEnCours()
        {
            chargerMusiqueEntities();
            //Vérification que les emprunts sont tous liés à l'utilisateurs et qu'ils ne sont tous pas rendus
            ABONNÉS ab = connexion("lp", "lp");

            var liste = getEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            foreach (EMPRUNTER em in liste)
            {
                Assert.IsTrue(em.CODE_ABONNÉ == ab.CODE_ABONNÉ && em.DATE_RETOUR == null);
            }

            //Ajout d'un emprunt
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            EMPRUNTER e = nouvelEmprunt(ab, a);
            liste = getEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            Assert.IsTrue(liste.Contains(e));

            //Rendu d'un emprunt
            rendreEmprunt(e);
            liste = getEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);
            Assert.IsTrue(!liste.Contains(e));
        }

        //US 3 + 9
        [TestMethod]
        public void testProlongation()
        {
            chargerMusiqueEntities();
            ABONNÉS ab = connexion("lp", "lp");

            //Nouvel emprunt
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            EMPRUNTER e = nouvelEmprunt(ab, a);
            var liste = getEmpruntsEnCoursAbonné(ab.CODE_ABONNÉ);

            //Prolongement d'un nouvel emprunt
            Assert.IsTrue(estProlongeable(e));
            DateTime ancienne = e.DATE_RETOUR_ATTENDUE;
            prolongation(e);
            Assert.IsFalse(e.DATE_RETOUR_ATTENDUE == ancienne);

            //Tentative de re-prolongement
            ancienne = e.DATE_RETOUR_ATTENDUE;
            Assert.IsFalse(estProlongeable(e));
            prolongation(e);
            Assert.IsTrue(e.DATE_RETOUR_ATTENDUE == ancienne);

            //Vérification prolongement de tout les emprunts
            foreach (EMPRUNTER emprunt in liste)
            {
                prolongation(emprunt);
            }
            foreach (EMPRUNTER emprunt in liste)
            {
                Assert.IsFalse(estProlongeable(emprunt));
            }

            rendreEmprunt(e);

        }

        //US 10
        [TestMethod]
        public void testSuggestions()
        {
            chargerMusiqueEntities();
            ABONNÉS ab = connexion("lp", "lp");

            //On récupère la liste de tous les emprunts déjà réalisés de l'abonné, et des suggestions qui lui sont proposés
            var liste = getEmpruntsAbonné(ab.CODE_ABONNÉ);
            var suggestion = getSuggestions(ab.CODE_ABONNÉ);

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
            ALBUMS al = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            EMPRUNTER em = nouvelEmprunt(ab, al);
            liste = getEmpruntsAbonné(ab.CODE_ABONNÉ);
            suggestion = getSuggestions(ab.CODE_ABONNÉ);

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
