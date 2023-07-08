using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFlyWeight
{
    public class Font : IFont
    {
        private string _name;
        private int _size;
        private bool _bold;
        private bool _italic;

        public Font(string name, int size, bool bold, bool italic)
        {
            _name = name;
            _size = size;
            _bold = bold;
            _italic = italic;
        }

        public void SetFont(string name, int size, bool bold, bool italic)
        {
            _name = name;
            _size = size;
            _bold = bold;
            _italic = italic;
        }

        public void Display(string text)
        {
            Console.WriteLine($"Displaying text '{text}' in font '{_name}', size {_size}, {(_bold ? "bold" : "not bold")}, {(_italic ? "italic" : "not italic")}");
        }
    }

}
