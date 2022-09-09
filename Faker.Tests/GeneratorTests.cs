using FakerLibrary;
using FakerLibrary.GeneratorClasses;
using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        Generator generator;
        private void SetUp()
        {
            generator = new Generator();
        }
        [TestMethod]
        public void CheckInts()
        {
           SetUp();
          //  generator.createRandomValuesObject(typeof(int));
          //var gen= generator.getGenerator(typeof(int));
         // Assert.AreEqual(typeof(BaseValueGenerator), gen);
        }

        [TestMethod]
        public void CheckArrays()
        {
            SetUp();
            //generator
            //  generator.createRandomValuesObject(typeof(int));
            //var gen= generator.getGenerator(typeof(int));
            // Assert.AreEqual(typeof(BaseValueGenerator), gen);
        }
    }
}
