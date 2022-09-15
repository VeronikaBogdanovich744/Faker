using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class StringGenerator : IValueGenerator
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
            string str = "";
            byte count = (byte)context.Random.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                str += (char)context.Random.Next('A', 'z');
            }
            return str;
        }

    }
}
