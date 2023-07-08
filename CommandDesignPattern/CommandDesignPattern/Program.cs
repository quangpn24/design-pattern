using CommandDesignPattern;
using CommandDesignPattern.ConcreteCommand;
using CommandDesignPattern.IoTDevice;

Invoker invoker = new();

CeilingLight ceilingLight = new();
LightOnCommand lightOnCommand = new(ceilingLight);
GarageDoor garageDoor = new();
DoorUpCommand doorUpCommand = new(garageDoor);
Stereo stereo = new();
StereoOnWithCdCommand cdCommand = new(stereo, "ABC", 12);
StereoOffCommand stereoOffCommand = new(stereo);

/*invoker.SetCommand(lightOnCommand);
invoker.ExecutionCommand();
invoker.SetCommand(doorUpCommand);
invoker.ExecutionCommand();*/


invoker.SetCommand(cdCommand);
invoker.ExecutionCommand();
/*invoker.UndoCommand();*/
invoker.SetCommand(doorUpCommand);
invoker.ExecutionCommand();
invoker.SetCommand(stereoOffCommand);
invoker.ExecutionCommand();
//invoker.UndoCommand();

Console.WriteLine();

invoker.UndoCommands();

Console.WriteLine();


/*List<ICommand> commands = new List<ICommand>();
commands.Add(lightOnCommand);
commands.Add(doorUpCommand);
commands.Add(cdCommand);

MacroCommand macroCommand = new MacroCommand(commands);

invoker.SetCommand(macroCommand);
invoker.ExecutionCommand();*/




