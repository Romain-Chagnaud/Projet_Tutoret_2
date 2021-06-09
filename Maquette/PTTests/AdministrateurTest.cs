﻿using Maquette;
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

        [TestMethod]
        public void testFantômes()
        {
            chargerMusiqueEntities();
            ABONNÉS ab = inscription("Jean", "Reno", "Leon", "onimusha");
            if (ab == null)
            {
                ab = connexion("Leon", "onimusha");
            }
            ALBUMS a = getALBUMSs().Except(getIndisponibles()).ToList()[0];

            //Cas nouvel abonné, n'est pas un fantôme
            var fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            //Cas l'abonné a un emprunt de plus d'un an
            DateTime d = DateTime.Now.AddDays(-366);
            EMPRUNTER em = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsTrue(fantomes.Contains(ab));

            //Cas l'abonné fantôme a un emprunt plus récent
            a = getALBUMSs().Except(getIndisponibles()).ToList()[0];
            d = DateTime.Now.AddDays(-128);
            EMPRUNTER em1 = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));

            rendreEmprunt(em);
            rendreEmprunt(em1);

            //Cas l'abonné fantôme est purgé
            d = DateTime.Now.AddDays(-366);
            em = nouvelEmpruntDaté(ab, a, d);
            fantomes = getFantomes();
            Assert.IsTrue(fantomes.Contains(ab));
            purgerFantomes();
            fantomes = getFantomes();
            Assert.IsFalse(fantomes.Contains(ab));
        }

        [TestMethod]
        public void testTop10()
        {
            chargerMusiqueEntities();
            List<ALBUMS> top10 = getTop10();

            //Vérification un album devient plus populaire
            List<ABONNÉS> abonnés = getABONNÉSs();
            List<EMPRUNTER> empruntsTempo = new List<EMPRUNTER>();
            
            ALBUMS albumTop10 = top10[9];
            //Ici on rend l'album numéro 10 dans le cas où il est emprunté
            EMPRUNTER e = getEmpruntAlbumEnCours(albumTop10);
            if (e != null)
            {
                rendreEmprunt(e);
            }
            //On le fait emprunter par tout les abonnés
            foreach (ABONNÉS ab in abonnés)
            {
                e = nouvelEmprunt(ab, albumTop10);
                empruntsTempo.Add(e);
                rendreEmprunt(e);
            }

            //Et on crée un abonné qui va l'emprunter aussi pour être sûr qu'il n'y ait pas d'égalité
            ABONNÉS abo = inscription("Changer", "Top", "topchanger", "top");
            e = nouvelEmprunt(abo, albumTop10);
            empruntsTempo.Add(e);
            rendreEmprunt(e);

            //On actualise le top 10
            top10 = getTop10();
            //On vérifie que l'album a changé de place
            Assert.IsTrue(top10[9] != albumTop10);
            //On vérifie que l'album est numéro 1
            int place = 0;
            bool albumTop10Trouvé = false;
            while(place < 10 && !albumTop10Trouvé)
            {
                if (top10[place] == albumTop10)
                {
                    albumTop10Trouvé = true;
                } else
                {
                    place++;
                }
            }
            Assert.IsTrue(place == 0);

            //On supprime l'abonné et on efface les emprunts pour la stabilité du test
           
            foreach(EMPRUNTER em in empruntsTempo)
            {
                supprimerEmprunt(em);
            }
            removeAbonné(abo);
        }
    }
}
