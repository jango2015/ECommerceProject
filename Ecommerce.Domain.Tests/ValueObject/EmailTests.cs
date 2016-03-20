using System;
using Ecoomerce.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ecommerce.Domain.Tests.ValueObject
{
    [TestClass]
    public class EmailTests
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Novo_Em_Branco()
        {
            var Email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Novo_Nulo()
        {
            var Email = new Email(null);
        }

        [TestMethod]
        public void Email_Novo_EmailValido()
        {
            var address = "emailvalido@mail.com";
            var email = new Email(address);
            Assert.AreEqual(address, email.Address);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Novo_EmailInvalido()
        {
            var address = "hauhuseuhuuashuh";
            var email = new Email(address);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_Novo_Erro_MaxLenght()
        {
            var address = "emailtestenovo@servidordeemail.com";
            while (address.Length< Email.AdressMaxLength+1)
            {
                address = address + address;
            }
            new Email(address);
        }

    }
}
