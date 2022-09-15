using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.GeneratorClasses
{
    public class ClassGenerator : IValueGenerator
    {
        private GeneratorContext Context;

        private bool b = false;
        public ClassGenerator()
        {
         
        }

        public bool CanGenerate(Type type)
        {
            if ((type.IsClass && !type.IsGenericType && type!=typeof(string)) || (type.IsValueType && !type.IsPrimitive))
            {
                return true;
            }
            return false;
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            Context = context;
            var constructorClass = Constructor.CreateInstance(typeToGenerate);

            ConstructorInfo constructor = constructorClass.theHighestNumberParametersConstructor();
            if(constructor!=null){
                try { 
                        return CreateInstanceWithParameters(typeToGenerate, constructorClass.parameters,constructor);
                }
                catch {
                    constructorClass.deleteConstrucor(constructor);
                    return Generate(typeToGenerate, context);
                }
            }
            else
            {
                return DefaultGenerator.GetDefaultValue(typeToGenerate);
            }
        }

        private object CreateInstanceWithParameters(Type t, ParameterInfo[] parameters, ConstructorInfo constructor)
        {
            object[] parametersInstance = new Object[parameters.Length];
            object obj;


            int i = 0;
            foreach (ParameterInfo parameter in parameters)
            {
                parametersInstance[i] = Context.Faker.Create(parameter.ParameterType);
                i++;
            }
            try
            {
                obj = constructor.Invoke(parametersInstance);
            }
            catch (Exception ex)
            {
                throw;
               
            }


            foreach(var f in t.GetProperties().Where(f => f.CanWrite && f.CanRead))
            {
                object? zero = DefaultGenerator.GetDefaultValue(f.PropertyType);
                if (ValueType.Equals(f.GetValue(obj), zero))
                {
                    f.SetValue(obj, Context.Faker.Create(f.PropertyType));
                  
                }
            }
            foreach (var f in t.GetFields().Where(f => f.IsPublic))
            {
                object? zero = DefaultGenerator.GetDefaultValue(f.FieldType);
                if (ValueType.Equals(f.GetValue(obj), zero))
                {
                    f.SetValue(obj, Context.Faker.Create(f.FieldType));

                }

                
            }
            return obj;
        }
    }
}
