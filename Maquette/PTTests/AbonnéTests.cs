using Maquette;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static Maquette.Outil;
namespace PTTests
{
    [TestClass]
    public class AbonnéTests
    {
        [TestMethod]
        public void testInscription()
        {
            chargerMusiqueEntities();
            string nom, prenom, login, mdp;
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont";
            mdp = "belmont123";
            ABONNÉS abonnéTrue = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonnéTrue != null);
            System.Console.WriteLine(abonnéTrue.ToString());
            nom = "Belmont";
            prenom = "Simon";
            login = "Belmont";
            mdp = "draculakiller";
            ABONNÉS abonnéFalse = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonnéFalse == null);
            System.Console.WriteLine("L'utilisateur Belmont Simon ne peut pas être créé (login Belmont déjà utilisé)");
            nom = "Belmondo";
            prenom = "Jean-Paul";
            login = "Belmont2";
            mdp = "belmont123";
            ABONNÉS abonnéTrue2 = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonnéTrue2 != null);
            System.Console.WriteLine(abonnéTrue2.ToString());
            removeAbonné(abonnéTrue);
            removeAbonné(abonnéTrue2);
        }

        [TestMethod]
        public void testConnexion()
        {
            chargerMusiqueEntities();
            ABONNÉS abonnéTrue = connexion("lp", "lp");
            Assert.IsTrue(abonnéTrue != null);
            System.Console.WriteLine(abonnéTrue.ToString());
            ABONNÉS abonnéFalse = connexion("random1645551", "random165455");
            Assert.IsTrue(abonnéFalse == null);
            System.Console.WriteLine("Aucun utilisateur s'appelant : random1645551");
        }

        [TestMethod]
        public void testEmprunt()
        {
            chargerMusiqueEntities();
            //Emprunt numéro 1 pour lp
            ABONNÉS ab = connexion("lp", "lp");
            Console.WriteLine(ab.ToString());
            ALBUMS a = getALBUMSs()[0];
            Console.WriteLine(a.ToString());
            EMPRUNTER e = nouvelEmprunt(ab, a);
            Assert.IsTrue(e != null);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " numéro 1");

            //Test d'emprunt de l'album par le même utilisateur sans l'avoir rendu
            EMPRUNTER e1 = nouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " numéro 2");

            //Rendu de l'emprunt
            rendreEmprunt(e);

            //Emprunt numéro 2 du même album pour lp après l'avoir rendu
            e = nouvelEmprunt(ab, a);
            Assert.IsTrue(e != null);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " numéro 2");

            //Emprunt du même album par un utilisateur
            ab = inscription("Fernand", "Constandin", "Fernaldin", "ferni");
            e1 = nouvelEmprunt(ab, a);
            Assert.IsTrue(e1 == null);
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " impossible, album déjà pris");
            rendreEmprunt(e);
            removeAbonné(ab);
        }

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
    }
}
