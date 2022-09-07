using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class EnumerableGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type.GetInterfaces().Contains(typeof(IEnumerable<>)))
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
