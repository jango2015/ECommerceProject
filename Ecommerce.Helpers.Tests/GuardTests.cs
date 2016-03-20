using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ecommerce.Helpers.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Guard.ForNullOrEmpty("","Valor Não pode Ser Vazio");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Nulo()
        {
            Guard.ForNullOrEmpty(null, "Valor Não pode Ser Nulo");
        }

    }
}
