using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests.ExampleClasses
{
    public class ExampleClass
    {
        public string str;
        public int Int;
        public int Int2;
        public byte Byte { get; set; }

        public ExampleClass()
        {
            Int = 1;
        }

        public ExampleClass(int _int)
        {
            Int = _int;
        }
    }
}
