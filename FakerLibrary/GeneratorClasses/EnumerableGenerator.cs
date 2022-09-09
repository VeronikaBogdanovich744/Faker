using FakerLibrary.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class EnumerableGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            if (type.GetGenericTypeDefinition() == typeof(List<>))
            {
                return true;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int size = context.Random.Next(Byte.MaxValue / 2);
            Type genericType = typeToGenerate.GetGenericArguments()[0];
            object list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(genericType));
           // var generator = new Generator();
            
            for (int i = 0; i < size; i++)
            {
               // generator.createRandomValue(genericType);
                ((IList)list).Add(context.Faker.Create(genericType));
            }
            return list;
        }

        public object Generate(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
