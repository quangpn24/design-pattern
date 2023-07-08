using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBuilderPattern
{
    interface ILaptopBuilder
    {
        LaptopBuilder AddRAMSize(int size);
        LaptopBuilder AddManufacturer(string manufacturer);
        LaptopBuilder AddDiskType(string diskType);
        LaptopBuilder AddStorageSpace(int size);
        LaptopBuilder AddMinPrice(int minPrice);
        LaptopBuilder AddMaxPrice(int maxPrice);
        LaptopBuilder AddName (string name);

        Laptop Build();
    }
}
