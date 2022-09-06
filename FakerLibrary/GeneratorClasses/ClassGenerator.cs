using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    internal class ClassGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type.IsClass)
            {
                return true;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            throw new NotImplementedException();
        }
    }
}
