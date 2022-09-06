using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    internal class FloatGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type.IsValueType == true) { 
                if (type == typeof(float) || type == typeof(double) || type == typeof(decimal))
                {
                return true;
                }
                return false;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            throw new NotImplementedException();
        }
    }
}
