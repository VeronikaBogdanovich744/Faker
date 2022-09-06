using FakerLibrary.Interfaces;
using System.Reflection;
using System.Reflection.Emit;

namespace FakerLibrary
{
    public class Faker: IFaker
    {
        public Faker()
        {

        }
        //
        public Faker(int i)
        {

        }
        //
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }

        private object Create(Type t) // метод для внутреннего использования
        {
            var constructorClass = new Constructor(t);
          //  ParameterInfo[] parameters = null;
            ConstructorInfo constructor = constructorClass.theHighestNumberParametersConstructor();
            if (constructor == null)
            {
                //create value type instance
                return Activator.CreateInstance(t);
            }
            else
            {
                return CreateInstanceWithParameters(t, constructorClass.parameters);
            }
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
            return Activator.CreateInstance(t, parametersInstance);
        } 
    }
}