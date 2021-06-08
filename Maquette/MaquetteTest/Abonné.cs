using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maquette;
using static Maquette.Outil;


namespace MaquetteTest
{
    [TestClass]
    public class Abonn�
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
            ABONN�S abonn�True = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonn�True != null);
            System.Console.WriteLine(abonn�True.ToString());
            nom = "Belmont";
            prenom = "Simon";
            login = "Belmont";
            mdp = "draculakiller";
            ABONN�S abonn�False = inscription(prenom, nom, login, mdp);
            Assert.IsTrue(abonn�False == null);
            System.Console.WriteLine("L'utilisateur Belmont Simon ne peut pas �tre cr�� (login Belmont d�j� utilis�)");
            removeAbonn�(abonn�True);
        }
    }
}
