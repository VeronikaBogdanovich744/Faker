using FakerLibrary.Interfaces;

namespace Faker.Tests
{
    [TestClass]
    public class FakerTest
    {
        IFaker faker;
        private void SetUp()
        {
            faker = new FakerLibrary.Faker();
        }
        [TestMethod]
        public void TestMethod1()
        {
            SetUp();
            var instance = faker.Create<FakerLibrary.Faker>();

           // var instance = faker.Create<int>();
        }
        [TestMethod]
        public void CreateValueTypeInstance()
        {
            SetUp();
            var instance = faker.Create<int>();
        }
        [TestMethod]
        public void CreateListTypeInstance()
        {
            SetUp();
            var instance = faker.Create<List<int>>();
        }
    }
}