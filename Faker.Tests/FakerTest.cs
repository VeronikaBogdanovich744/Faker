using Faker.Tests.ExampleClasses;
using FakerLibrary.Interfaces;
using System.Collections.ObjectModel;

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
        public void CreateClassTypeInstance()
        {
            SetUp();
            var instance = faker.Create<ExampleClass>();
            Assert.IsNotNull(instance);
            Assert.AreNotEqual(1,instance.Int);
        }
        [TestMethod]
        public void CreateValueTypeInstance()
        {
            SetUp();
            var instance = faker.Create<int>();
            Assert.IsInstanceOfType(instance, typeof(int));
            Assert.AreNotEqual(0, instance);
        }
        [TestMethod]
        public void CreateListTypeInstance()
        {
            SetUp();
            var instance = faker.Create<List<int>>();
            Assert.IsInstanceOfType(instance, typeof(List<int>));
            Assert.AreNotEqual(0,instance.Count);
        }


        [TestMethod]
          public void CreateArrayTypeInstance()
          {
              SetUp();
            var instance = faker.Create<byte[]>();
            Assert.IsInstanceOfType(instance, typeof(byte[]));
            Assert.AreNotEqual(0, instance.Length);
        }

        [TestMethod]
        public void CreateStringTypeInstance()
        {
            SetUp();
            var instance = faker.Create<string>();
            Assert.IsInstanceOfType(instance, typeof(string));
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CreateFakerTypeInstance()
        {
            SetUp();
            var instance = faker.Create<FakerLibrary.Faker>();
            Assert.IsInstanceOfType(instance, typeof(FakerLibrary.Faker));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void CreateClassWithException()
        {
            SetUp();
            var instance = faker.Create<ThrowExceptionClass>();
            Assert.IsInstanceOfType(instance, typeof(ThrowExceptionClass));
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CreateClassWithPrivateConstructor()
        {
            SetUp();
            ClassWithPrivateConstruction instance = faker.Create<ClassWithPrivateConstruction>();
            Assert.IsInstanceOfType(instance, typeof(ClassWithPrivateConstruction));
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CreateStruct()
        {
            SetUp();
            var instance = faker.Create<structType>();
            Assert.IsInstanceOfType(instance, typeof(structType));
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void CreateCicleClass()
        {
            SetUp();
            var instance = faker.Create<CicleClassA>();
            Assert.IsNull(instance);
        }

        [TestMethod]
        public void CreateDateTimeInstance()
        {
            SetUp();
            var instance = faker.Create<DateTime>();
            Assert.IsNull(instance);
        }

        struct structType
        {
            public int s_id;
            public String s_name;
            public structType(int id)
            {
                s_id = id;
                s_name = "structName";
            }
        }
    }
}