using Integrations;
using Moq;
using NUnit.Framework;
using Services;

namespace TestServices
{
    public class TestBusinessService
    {
        public readonly Mock<IRedisRepository> mockRepo = new Mock<IRedisRepository>();

        [SetUp]
        public void Setup()
        {
            mockRepo.Setup(x => x.Get()).Returns(2);
        }

        [Test]
        public void Test1()
        {
            var service = new BusinessService(mockRepo.Object);
            var val = service.Get();
            Assert.IsTrue(2 == val);
        }

        [Test]
        public void Test2()
        {
            var service = new BusinessService(mockRepo.Object);
            var val = service.Get();
            Assert.IsFalse(3 == val);
        }
    }
}