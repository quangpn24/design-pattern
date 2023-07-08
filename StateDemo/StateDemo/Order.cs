using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo
{
    class Order
    {
        private IOrderState currState;

        public Order() {
            this.currState = new WaitingConfirmState(this);
        }
        public void changeState(IOrderState state)
        {
            this.currState = state;
        }
        public void confirmOrder()
        {
            this.currState.confirmOrder();
        }
        public void ship()
        {
            this.currState.ship();
        }
        public void deliver()
        {
            this.currState.deliver();
        }
        public void cancelOrder()
        {
            this.currState.cancel();
        }

    }
}
