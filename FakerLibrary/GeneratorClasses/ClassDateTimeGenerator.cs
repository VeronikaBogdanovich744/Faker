using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class ClassDateTimeGenerator : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type==typeof(DateTime);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int year = context.Random.Next(2022);
            int month = context.Random.Next(12);
            int day = context.Random.Next(31);
            return new DateTime(year,month,day);
        }
    }
}
