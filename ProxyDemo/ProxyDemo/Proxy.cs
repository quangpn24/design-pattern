using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class Proxy : IRemote
    {
        private RemoteImpl? remote = null;
        public void turnOff()
        {
            if (this.remote == null)
            {
                this.remote = new RemoteImpl();
            }
            this.remote.turnOff();
        }

        public void turnOn()
        {
            if (this.remote == null)
            {
                this.remote = new RemoteImpl();
            }
            this.remote.turnOn();
        }
    }
}
