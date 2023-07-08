using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class RemoteImpl : IRemote
    {
        public void turnOff()
        {
            Console.WriteLine("Turn off the light");
        }

        public void turnOn()
        {
            Console.WriteLine("Turn on the light");
        }
    }
}
