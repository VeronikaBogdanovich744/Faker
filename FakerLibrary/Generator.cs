using FakerLibrary.GeneratorClasses;
using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class Generator
    {
        IValueGenerator generator;
        IFaker faker;
        public Generator()
        {
        }


        private IValueGenerator getGenerator(Type type)
        {
            Type lookupType = typeof(IValueGenerator);
            IEnumerable<Type> generatorTypes = GetType().Assembly.GetTypes().Where(
                    t => lookupType.IsAssignableFrom(t) && !t.IsInterface);
            foreach (Type gen in generatorTypes)
            {
                generator = (IValueGenerator)Activator.CreateInstance(gen);
                if (generator.CanGenerate(type))
                {
                    return generator;
                }
            }
            return null;
        }

        public object createRandomValue(Type type, GeneratorContext generatorContext)
        {
            if (getGenerator(type) == null)
            {
                return DefaultGenerator.GetDefaultValue(type);  
            }
            return generator.Generate(type, generatorContext);
        }
    }
}
