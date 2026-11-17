using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompteBanqueNS;
using System;

namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        public void VérifierDébitCompteCorrect()
        {
            // Organiser (Arrange)
            double soldeInitial = 500000;
            double montantDébit = 400000;
            double soldeAttendu = 100000;
            var cb = new CompteBancaire("Pr Doudou Fall", soldeInitial);

            // Agir (Act)
            cb.Débiter(montantDébit);

            // Auditer (Assert)
            double soldeObtenu = cb.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte débité incorrectement");
        }

        [TestMethod]
        public void Débiter_MontantSuperieurAuSolde_LanceArgumentOutOfRangeException()
        {
            // Organiser
            double soldeInitial = 500000;
            double montantDébit = 600000; // Supérieur au solde
            var cb = new CompteBancaire("Pr Doudou Fall", soldeInitial);

            try
            {
                // Agir
                cb.Débiter(montantDébit);
                Assert.Fail("L'exception ArgumentOutOfRangeException attendue n'a pas été levée.");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Succès : l'exception a bien été levée
            }
        }

        [TestMethod]
        public void Débiter_MontantInferieurAZero_LanceArgumentOutOfRangeException()
        {
            // Organiser
            double soldeInitial = 500000;
            double montantDébit = -100; // Négatif
            var cb = new CompteBancaire("Pr Doudou Fall", soldeInitial);

            try
            {
                // Agir
                cb.Débiter(montantDébit);
                Assert.Fail("L'exception ArgumentOutOfRangeException attendue n'a pas été levée.");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Succès : l'exception a bien été levée
            }
        }
    }
}