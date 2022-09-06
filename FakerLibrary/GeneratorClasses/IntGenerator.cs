using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    internal class IntGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type.IsValueType == true)
            {
                if (type == typeof(int) || type == typeof(byte) || type == typeof(short) || type == typeof(sbyte) || type == typeof(ushort) || type == typeof(uint) || type == typeof(long) || type == typeof(ulong))
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
