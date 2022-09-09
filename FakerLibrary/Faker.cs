using FakerLibrary.Interfaces;
using System.Reflection;
using System.Reflection.Emit;

namespace FakerLibrary
{
    public class Faker: IFaker
    {
        Generator generator;
        ConstructorInfo constructor;
        public Faker()
        {
            generator = new Generator();
        }
        //
        public Faker(int i)
        {
            generator = new Generator();
        }
        //
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }

        public object Create(Type t) // метод для внутреннего использования
        {
            /* var constructorClass = new Constructor(t);
           //  ParameterInfo[] parameters = null;
              constructor = constructorClass.theHighestNumberParametersConstructor();
             if (constructor == null)
             {

                 //create value type instance
                 //value types generator
                 return generator.createRandomValue(t);//Activator.CreateInstance(t);
             }
             else
             {
                 return CreateInstanceWithParameters(t, constructorClass.parameters);
             }*/
            GeneratorContext context = new GeneratorContext(this);
            return generator.createRandomValue(t, context);
        }

        private object CreateInstanceWithParameters(Type t, ParameterInfo[] parameters)
        {
            object[] parametersInstance = new Object[parameters.Length];
            int i = 0;
            foreach (ParameterInfo parameter in parameters)
            {
                parametersInstance[i] = Create(parameter.ParameterType);
                i++;
            }
            GeneratorContext context = new GeneratorContext(constructor, parametersInstance,this);
            return generator.createRandomValue(t, context);//Activator.CreateInstance(t, parametersInstance);
        } 
    }
}