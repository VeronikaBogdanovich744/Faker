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
        public void CheckBaseValues()
        {
            SetUp(new BaseValueGenerator());
            Assert.IsTrue(generator.CanGenerate(typeof(int)));
            Assert.IsTrue(generator.CanGenerate(typeof(double)));
            Assert.IsTrue(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(ClassGenerator)));
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
            SetUp(new ListGenerator());
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(int[])));
            Assert.IsTrue(generator.CanGenerate(typeof(List<int>)));
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
