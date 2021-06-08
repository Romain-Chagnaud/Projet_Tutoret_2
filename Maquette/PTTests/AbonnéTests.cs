using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Maquette;
using static Maquette.Outil;
using System.Linq;
using System.Data;
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

            //Emprunt numéro 2 du même album pour lp
            e = nouvelEmprunt(ab, a);
            Assert.IsTrue(e != null);
            Console.WriteLine(e.ToString());
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " numéro 2");

            //Emprunt du même album par un utilisateur
            ab = inscription("Fernand", "Constandin", "Fernaldin", "ferni");
            e = nouvelEmprunt(ab, a);
            Assert.IsTrue(e == null);
            Console.WriteLine("Emprunt de " + a.TITRE_ALBUM.Trim() + " impossible, album déjà pris");
        }
    }
}
