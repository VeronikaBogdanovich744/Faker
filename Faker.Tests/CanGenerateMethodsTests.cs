using FakerLibrary;
using FakerLibrary.Interfaces;
using FakerLibrary.GeneratorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests
{
    [TestClass]
    public class CanGenerateMethodsTests
    {
        IValueGenerator generator;
        private void SetUp(IValueGenerator _generator)
        {
            generator = _generator;
        }
        [TestMethod]
        public void CheckInts()
        {
            SetUp(new IntGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(ClassGenerator)));
        }

        [TestMethod]
        public void CheckFloats()
        {
            SetUp(new FloatGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(double)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(ClassGenerator)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }

        [TestMethod]
        public void CheckClasses()
        {
            SetUp(new ClassGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(ClassGenerator)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }

        [TestMethod]
        public void CheckStrings()
        {
            SetUp(new StringGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }

        [TestMethod]
        public void CheckIEnumerables()
        {
            SetUp(new EnumerableGenerator());
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(int[])));
            Assert.IsTrue(generator.CanGenerate(typeof(List<int>)));
            Assert.IsTrue(generator.CanGenerate(typeof(IEnumerable<int>)));
            Assert.IsTrue(generator.CanGenerate(typeof(ICollection<int>)));
            Assert.IsTrue(generator.CanGenerate(typeof(IList<int>)));
        }

        [TestMethod]
        public void CheckArrays()
        {
            SetUp(new ArrayGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(int[])));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
        }

    }
}
