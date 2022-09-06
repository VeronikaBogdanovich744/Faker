using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    internal class StringGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type == typeof(string))
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
