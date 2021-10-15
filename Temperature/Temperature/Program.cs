using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            InputObj agent = new InputObj(new ConverterObj());
            agent.ServerForever();
        }
    }
}
