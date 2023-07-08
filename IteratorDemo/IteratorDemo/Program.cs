// See https://aka.ms/new-console-template for more information

using IteratorDemo;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Node root = new Node(10, new Node(8, new Node(7), new Node(9)), new Node(11));
TreeCollection collection = new TreeCollection(root);

//Duyệt theo chiều sâu
Iterator iteratorDFT = new DepthFirstIterator(collection);
Console.WriteLine("======== Duyệt theo chiều sâu ========");
Console.WriteLine(iteratorDFT.CurrentNode().Val);
while (iteratorDFT.HasNext())
{
    Console.WriteLine(iteratorDFT.NextNode().Val);
}

//Duyệt theo chiều rộng
Console.WriteLine("======== Duyệt theo chiều rộng ========");
Iterator iteratorBFT = new BreadthFirstIterator(collection);

Console.WriteLine(iteratorBFT.CurrentNode().Val);
while (iteratorBFT.HasNext())
{
    Console.WriteLine(iteratorBFT.NextNode().Val);
}