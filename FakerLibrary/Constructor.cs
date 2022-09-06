using FakerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    internal class Constructor
    {
        ConstructorInfo? constructor;
       internal ParameterInfo[]? parameters;
        Type type;
       
        internal Constructor(Type t)
        {
            parameters = null;
            constructor = null;
            type = t;
        }

        internal ConstructorInfo theHighestNumberParametersConstructor()
        {
            ConstructorInfo[] constructorsInfo = type.GetConstructors();
            int maxParameterNumber = 0;
            //ConstructorInfo constructor = null;
            foreach (ConstructorInfo currentConstructor in constructorsInfo)
            {
                var parametersInfo = currentConstructor.GetParameters();
                if (parametersInfo.Length > maxParameterNumber)
                {
                    maxParameterNumber = parametersInfo.Length;
                    constructor = currentConstructor;
                    parameters = parametersInfo;

                }

            }
            return constructor;
        }
    }
}
