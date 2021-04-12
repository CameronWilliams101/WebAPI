using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class HelloService
    {
        public List<Hello> list;

        public HelloService()
        {
            list = new List<Hello>();
        }

        public void AddManual(Hello hello)
        {
            list.Add(hello);
        }
    }
}
