using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class Generator
    {
        //IEnumerable<IValueGenerator> generators;
        IValueGenerator generator;
        public Generator()
        {
            //get generators from the assembly
            Type lookupType = typeof(IValueGenerator);
            IEnumerable<Type> generatorTypes = GetType().Assembly.GetTypes().Where(
                    t => lookupType.IsAssignableFrom(t) && !t.IsInterface);
            foreach(Type gen in generatorTypes)
            {
                generator = (IValueGenerator)Activator.CreateInstance(gen);
                if(generator.CanGenerate(typeof(int)))
                {
                    return;
                }
                generator = null;
            }
        }
    }
}
