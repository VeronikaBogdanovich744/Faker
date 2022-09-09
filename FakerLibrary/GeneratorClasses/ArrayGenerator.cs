using FakerLibrary.Interfaces;
using System;
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
            // var obj = Activator.CreateInstance(typeof(Array), context.parameters);
            /* foreach (var f in typeToGenerate.GetFields().Where(f => f.IsPublic))
             {
                 if (f.GetValue(obj) == null)
                 {
                     f.SetValue(obj, context.Faker.Create(f.FieldType));
                 }
             }
             foreach (var f in typeToGenerate.GetProperties().Where(f => f.CanWrite))
             {
                 if (f.GetValue(obj) == null)
                 {
                     f.SetValue(obj, context.Faker.Create(f.PropertyType));
                 }
             }*/

            //return obj;
            throw new NotImplementedException();
        }

        public object Generate(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
