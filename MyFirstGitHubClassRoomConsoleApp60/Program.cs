// See https://aka.ms/new-console-template for more information
using MyFirstGitHubClassRoomConsoleApp60;

Console.WriteLine("Hello, World!\n");

Demo firstDemo = new Demo(2, 8, true, "First test");
Demo secondDemo = new Demo(3.12, 16, false, "Second test");
Demo thirdDemo = new Demo(8.1234, 22, true, "Third test");

firstDemo.printOutForm();
secondDemo.printOutForm();
thirdDemo.printOutForm();
