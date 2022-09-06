using FakerLibrary;

namespace Faker.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var faker = new FakerLibrary.Faker();

            var instance = faker.Create<FakerLibrary.Faker>();

           // var instance = faker.Create<int>();
        }
    }
}