using Moq;
using NUnit.Framework;
using Services;
using WebApi.Controllers;

namespace TestWebApi
{
    public class TestHomeController
    {
        public readonly Mock<IBusinessService> mockRepo = new Mock<IBusinessService>();

        [SetUp]
        public void SetUp()
        {
            mockRepo.Setup(x => x.Get()).Returns(2);
        }

        [Test]
        public void Test1()
        {
            var homeController = new HomeController(mockRepo.Object);
            var val= homeController.Get();
            Assert.IsTrue(2 == val);
        }

        [Test]
        public void Test2()
        {
            var homeController = new HomeController(mockRepo.Object);
            var val = homeController.Get();
            Assert.IsFalse(3 == val);
        }
    }
}