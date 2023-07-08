using System;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;

namespace DemoBuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Laptop newLaptop = new Laptop("Dell", 16, "SSD", 256, 16, 20, "");

            //use builder
            Laptop newLaptopByBuilder = new LaptopBuilder()
                                                .AddManufacturer("Dell")
                                                .AddDiskType("HDD")
                                                .AddRAMSize(8)
                                                .AddMinPrice(10)
                                                .AddMaxPrice(20)
                                                .AddStorageSpace(512).Build();

            Console.WriteLine(newLaptop.ToString());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(newLaptopByBuilder.ToString());
        }
    }
}