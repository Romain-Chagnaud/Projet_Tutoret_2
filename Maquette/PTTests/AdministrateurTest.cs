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
    }
}
