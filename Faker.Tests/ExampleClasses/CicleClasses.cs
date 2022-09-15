using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests.ExampleClasses
{
    public class CicleClasses
    {
    }

    public class CicleClassA
    {
       public  CicleClassB cicleClassB { get; set; }
    }

    public class CicleClassB
    {
        public CicleClassA cicleClassA { get; set; }
    }
}
