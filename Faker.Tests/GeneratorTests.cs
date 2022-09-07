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
        }
    }
}
