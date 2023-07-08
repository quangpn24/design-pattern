using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDemo
{
    public class TextEditor
    {
        private string state;
        public TextEditor(string state)
        {
            this.state = state;
            Console.WriteLine("Current state: " + state);
        }

        public string GetState() { return state; }
        public void SetState(string state) {
            Console.WriteLine("Change state: " + state);
            this.state = state;
        }
        
        public Memento Save()
        {
            return new Memento(state);
        }

        public void Restore(Memento memento)
        {
            this.state = memento.GetState();
        }
        public class Memento
        {
            private string _state;

            internal Memento(string state)
            {
                this._state = state;
            }

            public string GetState()
            {
                return this._state;
            }
        }
    }
}
