using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class ClassGenerator : IValueGenerator
    {
        
        public bool CanGenerate(Type type)
        {
            if (type.IsClass && !type.IsGenericType && type!=typeof(string))
            {
                return true;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            throw new NotImplementedException();
        }

        public object Generate(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
