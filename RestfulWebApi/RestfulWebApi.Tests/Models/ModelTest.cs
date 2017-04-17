using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfulWebApi;
using RestfulWebApi.Controllers;
using RestfulWebApi.Models;

namespace RestfulWebApi.Tests.Models
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        public void ContactModelTest()
        {
            Contact contact = new Contact() { Id=1,Name="Test" };

            Assert.AreEqual(contact.Id, 1);
            Assert.AreEqual(contact.Name, "Test");
        }
    }
}
