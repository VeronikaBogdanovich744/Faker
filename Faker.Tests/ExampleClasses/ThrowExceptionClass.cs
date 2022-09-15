using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests.ExampleClasses
{
    public class ThrowExceptionClass
    {
        public int intValue;
        public ThrowExceptionClass(int t){
            try
            {
                throw new Exception();
            }
            catch
            {
                throw;
            }
         }

        public ThrowExceptionClass()
        {
           
        }
    }
}
