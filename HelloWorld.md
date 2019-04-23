# Hello World in C#
Just click the `run` button to get started
``` cs --source-file .\csharp_tutorial\Program.cs --project .\csharp_tutorial\csharp_tutorial.csproj --region Helloworld
```
## Run your First Program
Congratulations! You've run your first C# program. It used the Console.WriteLine method to print `Hello World`. `Console` is a type that represents the console window. `WriteLine` is a method of the `Console` type that prints a line of text to the console. 

### Who are you? 
Try modifying the code so that the console says hello to your name, instead of the world (e.g. Hello Rain!). Click the run button again.
``` cs --source-file .\newtest\Program.cs --project .\newtest\newtest.csproj --region test
```
### Variables
In programming we want to store values in container so we can use them later; these are called `variables`. 
Let's store your name in a variable, then read the value from that variable when creating the output message. 
``` cs --source-file .\csharp_tutorial\Program.cs --project .\csharp_tutorial\csharp_tutorial.csproj --region run1
var name = "Your Name";
Console.WriteLine("Hello " + name + "!");
```
The first line `var name = "Your Name";` declares a variable, `name` and assigns it a value,`Your Name`. The second line prints out the name.

### Working with Strings 