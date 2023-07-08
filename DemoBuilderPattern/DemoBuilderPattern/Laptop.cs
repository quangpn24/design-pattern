using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBuilderPattern
{
    class Laptop
    {
        public string Manufacturer { get; set; }
        public int RAMSize { get; set; }
        public string DiskType { get; set; }
        public int StorageSpace { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public string Name { get; set; }

        public Laptop(string manufacturer, int ramSize, string diskType, int storageSpace, int minPrice, int maxPrice, string name)
        {
            Manufacturer = manufacturer;
            RAMSize = ramSize;
            DiskType = diskType;
            StorageSpace = storageSpace;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Name = name;
        }

        public override string ToString()
        {
            var content = "";
            content += $"Manufacturer:     \t {Manufacturer}\n";
            content += $"Ram:              \t {RAMSize}GB\n";
            content += $"Disk type:        \t {DiskType}\n";
            content += $"Storage space:    \t {StorageSpace}GB\n";
            content += $"Min price:        \t {MinPrice}tr\n";
            content += $"Max price:        \t {MaxPrice}tr\n";
            content += $"Name:             \t {Name}\n";
            return content;
        }
    }
}
