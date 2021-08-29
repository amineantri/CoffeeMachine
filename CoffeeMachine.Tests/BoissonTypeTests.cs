using CoffeeMachine.API.Controllers;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.Repository;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachine.Tests
{
    [TestFixture]
    class BoissonTypeTests
    {
        private Mock<IRepositoryWrapper<BoissonType>> repo;
        private List<BoissonType> boissonTypes;

        [SetUp]
        public void Setup()
        {
            // setup mock
            repo = new Mock<IRepositoryWrapper<BoissonType>>();
            boissonTypes = new List<BoissonType>()
            {
                new BoissonType{TypeID = 1, BoissonName = "Thé"},
                new BoissonType{TypeID = 2, BoissonName = "Café"},
                new BoissonType{TypeID = 3, BoissonName = "Chocolat"}
            };
        }

        [Test]
        public void TestGetBoissonTypes()
        {
            //Act
            repo.Setup(a => a.FindAll()).Returns(boissonTypes.AsQueryable());

            //Arrange
            var boissonCtrl = new BoissonController(repo.Object);
            var actual = boissonCtrl.GetAllTypes();

            //Assert
            Assert.IsTrue(actual.Count() == 3);
            Assert.AreEqual(boissonTypes, actual);
        }

        [TestCase(1, "Thé")]
        [TestCase(2, "Café")]
        [TestCase(3, "Chocolat")]
        public void TestGivenIDReturnsType(int actual, string expected)
        {
            //Act
            repo.Setup(a => a.FindAll()).Returns(boissonTypes.AsQueryable());

            //Arrange
            var boissonCtrl = new BoissonController(repo.Object);
            var result = boissonCtrl.GetAllTypes().FirstOrDefault(x=>x.TypeID == actual);
            
            //Assert
            Assert.AreEqual(result.BoissonName, expected);
        }
    }
}
