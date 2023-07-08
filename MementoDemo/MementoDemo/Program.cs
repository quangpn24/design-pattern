// See https://aka.ms/new-console-template for more information

using MementoDemo;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

TextEditor editor = new TextEditor("Text: Xin chào các bạn!!!");
Caretaker caretaker = new Caretaker(editor);


caretaker.Save(); // Lưu trạng thái cũ vào history
editor.SetState("Text: Demo memento"); // Thay đổi văn bản

caretaker.Save(); // Lưu trạng thái cũ vào history 
editor.SetState("Text: Demo memento 2"); // Thay đổi văn bản

Console.WriteLine("\n\nUndo");
caretaker.Undo();
Console.WriteLine(editor.GetState());

Console.WriteLine("\n\nUndo");
caretaker.Undo();

Console.WriteLine(editor.GetState());