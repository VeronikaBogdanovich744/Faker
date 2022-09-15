using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    internal class Constructor
    {
        internal ConstructorInfo[]? constructors { get; private set; }
        ConstructorInfo? constructor;
        internal ParameterInfo[]? parameters;
        private static Constructor instance = null;
       
        private Constructor(Type t)
        {
            parameters = null;
            constructor = null;
            constructors = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
        }

        internal static Constructor CreateInstance(Type type)
        {
            if (instance == null)
            {
                instance = new Constructor(type);
            }
            return instance;
        }

        internal ConstructorInfo theHighestNumberParametersConstructor()
        {
            constructor = null;
            int maxParameterNumber = 0;
            foreach (ConstructorInfo currentConstructor in constructors)
            {
                var parametersInfo = currentConstructor.GetParameters();
                if (parametersInfo.Length >= maxParameterNumber)
                {
                    maxParameterNumber = parametersInfo.Length;
                    constructor = currentConstructor;
                    parameters = parametersInfo;

                }

            }
            return constructor;
        }
        internal void deleteConstrucor(ConstructorInfo constructorInfo)
        {
            constructors = constructors.Where(val => val != constructorInfo).ToArray();
        }
    }
}
