using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MementoDemo.TextEditor;

namespace MementoDemo
{
    public class Caretaker
    {
        private Stack<TextEditor.Memento> history = new Stack<TextEditor.Memento>();
        private TextEditor _originator;

        public Caretaker(TextEditor originator)
        {
            this._originator = originator;
        }
        public void Save()
        {
            var m = _originator.Save();
            history.Push(m);
        }

        public void Undo()
        {
            if (history.Count > 0 )
            {
                var m = history.Pop();
                _originator.Restore(m);
            }
        }


    }
}
