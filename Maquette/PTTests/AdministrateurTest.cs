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

        [TestMethod]
        public void testRetardataires()
        {
            chargerMusiqueEntities();
            ABONNÉS ab = inscription("Jean","Reno","Leon","onimusha");
            if (ab == null)
            {
                ab = connexion("Leon", "onimusha");
            }
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];

            //Cas d'un nouvel emprunt (pas de retard)
            EMPRUNTER em = nouvelEmpruntDaté(ab, a, DateTime.Now);
            var listeRetards = getRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            rendreEmprunt(em);


            //Cas d'un retard de moins de 10 jours
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

            removeAbonné(ab);
        }

    }
}
