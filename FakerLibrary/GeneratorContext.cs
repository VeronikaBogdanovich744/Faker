using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class GeneratorContext
    {
        public object[] parameters { get; }
        public ConstructorInfo constructorInfo { get; }
        // Для сохранения состояния генератора псевдослучайных чисел
        // и получения различных значений при нескольких последовательных вызовах.
        public Random Random { get; }

        // Даем возможность генератору использовать все возможности Faker.
        // Необходимо для создания коллекций произвольных объектов,
        // но может быть удобно и в некоторых других случаях.
        public IFaker Faker { get; }

       /* public GeneratorContext(Random random, IFaker faker)
        {
            Random = random;
            Faker = faker;
        }*/

        public GeneratorContext(ConstructorInfo _constructorInfo, object[] _parameters, IFaker faker)
        {
            constructorInfo = _constructorInfo;
            parameters = _parameters;
            Faker = faker;
            Random = new Random();
        }

        public GeneratorContext(IFaker faker)
        {
            Faker = faker;
            Random = new Random();
        }
    }
}
