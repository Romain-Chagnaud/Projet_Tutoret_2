using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maquette;
using static Maquette.Outil;


namespace MaquetteTest
{
    [TestClass]
    public class Abonné
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
            removeAbonné(abonnéTrue);
        }
    }
}
