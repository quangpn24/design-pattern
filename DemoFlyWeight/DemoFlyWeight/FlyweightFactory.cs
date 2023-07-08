using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DemoFlyWeight
{
    public class FontFactory
    {
        private static readonly Dictionary<string, IFont> _fonts = new Dictionary<string, IFont>();

        public static IFont GetFont(string name, int size, bool bold, bool italic)
        {
            string key = $"{name}-{size}-{bold}-{italic}";

            if (!_fonts.ContainsKey(key))
            {
                _fonts[key] = new Font(name, size, bold, italic);
            }

            return _fonts[key];
        }
    }

}
