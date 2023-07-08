using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBuilderPattern
{
     class LaptopBuilder :ILaptopBuilder
    {
        public string? Manufacturer { get; set; }
        public int RAMSize { get; set; }
        public string? DiskType { get; set; }
        public int StorageSpace { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public string? Name { get; set; }

        public LaptopBuilder AddDiskType(string diskType)
        {
            this.DiskType = diskType;
            return this;
        }

        public LaptopBuilder AddManufacturer(string manufacturer)
        {
            this.Manufacturer = manufacturer;
            return this;
        }

        public LaptopBuilder AddMaxPrice(int maxPrice)
        {
            this.MaxPrice = maxPrice;
            return this;
        }

        public LaptopBuilder AddMinPrice(int minPrice)
        {
            this.MinPrice = minPrice;
            return this;
        }

        public LaptopBuilder AddName(string name)
        {
            this.Name = name;
            return this;
        }

        public LaptopBuilder AddRAMSize(int size)
        {
            this.RAMSize = size;
            return this;
        }

        public LaptopBuilder AddStorageSpace(int size)
        {
            this.StorageSpace = size;
            return this;
        }

        public Laptop Build()
        {
            return new Laptop(this.Manufacturer, this.RAMSize,this.DiskType, this.StorageSpace, this.MinPrice, this.MaxPrice, this.Name);
        }
    }
}
