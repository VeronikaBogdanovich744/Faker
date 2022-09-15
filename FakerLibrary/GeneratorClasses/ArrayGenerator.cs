using FakerLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class ArrayGenerator : IValueGenerator
    {
        public  bool CanGenerate(Type type)
        {
            if (type.IsArray)
            {
                return true;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int size = context.Random.Next(Byte.MaxValue / 2);
            Type innerType = typeToGenerate.GetElementType();
            Array array = Array.CreateInstance(innerType, size);

            for (int i = 0; i < size; i++)
            {
                array.SetValue(context.Faker.Create(innerType), i);


            }
            return array;
        }

    }
}
