using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    interface IOrderState
    {
        public void confirmOrder();
        public  void ship();
        public void deliver();
        public void cancel();
    }
}
