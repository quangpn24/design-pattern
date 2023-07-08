// See https://aka.ms/new-console-template for more information
using DemoFlyWeight;

IFont font1 = FontFactory.GetFont("Arial", 12, false, true);
IFont font15 = FontFactory.GetFont("Arial", 14, false, true);
IFont font2 = FontFactory.GetFont("Calibri", 14, true, false);

font1.Display("Hello World");
font2.Display("This is a test");
font15.Display("Hello worlh v2");