using FakerLibrary.GeneratorClasses;
using FakerLibrary.Interfaces;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace FakerLibrary
{
    public class Faker: IFaker
    {
        Generator generator;
        public Faker()
        {
            generator = new Generator();
        }
       
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }

        public object Create(Type t) // метод для внутреннего использования
        {
                CycleError cycleError = new CycleError();
            if (cycleError.IsContainsCycles(t))
                return DefaultGenerator.GetDefaultValue(t);
           
            GeneratorContext context = new GeneratorContext(this);
            return generator.createRandomValue(t, context);

        }    
    }
}