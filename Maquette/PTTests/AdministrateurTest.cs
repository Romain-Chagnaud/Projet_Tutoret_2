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
            DateTime d = substractDay(DateTime.Now, a.GENRES.DÉLAI - 5);
            em = nouvelEmpruntDaté(ab, a, d);
            listeRetards = getRetardataires();
            Assert.IsFalse(listeRetards.Contains(ab));
            rendreEmprunt(em);

            //Cas d'un retard de 10 jours ou plus
            d = substractDay(DateTime.Now, a.GENRES.DÉLAI - 30);
            em = nouvelEmpruntDaté(ab, a, d);
            listeRetards = getRetardataires();
            Assert.IsTrue(listeRetards.Contains(ab));
            rendreEmprunt(em);

            removeAbonné(ab);
        }

        public List<int> longMois()
        {
            List<int> longMois = new List<int>();
            longMois.Add(1);
            longMois.Add(3);
            longMois.Add(5);
            longMois.Add(7);
            longMois.Add(8);
            longMois.Add(10);
            longMois.Add(12);
            return longMois;
        }

        public DateTime substractDay(DateTime d, int delay)
        {
            int year = d.Year;
            int day = d.Day - delay;
            int month = d.Month;
            bool test = false;
            while (month < 1 && !test)
            {
                if (longMois().Contains(month))
                {
                    if (day < 1)
                    {
                        day = 31 + day;
                        month--;
                    }
                }
                else if (month == 2)
                {
                    if (day < 1 && year % 4 != 0)
                    {
                        day = 28 + day;
                        month--;
                    }
                    else if (day < 1)
                    {
                        day = 29 + day;
                        month--;
                    }
                }
                else
                {
                    if (day < 1)
                    {
                        day = 30 + day;
                        month--;
                    }
                }
                if(month < 1)
                {
                    month = 12;
                    year--;
                }
                if (day >= 1)
                {
                    test = true;
                } else
                {
                    test = false;
                }
            }
            DateTime date = new DateTime(year, month, day);
            return date;
        }
    }
}
