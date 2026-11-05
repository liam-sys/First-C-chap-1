/*  
Chap 1 summary (Intro to Programming)
- This chapter basically introduces me to programming and the basics of C#. 
- The main things i covered in this chapter:
1. What is means to program and the stages in software development:
   I was reminded of the 6 stages of software development in which contains the implementation stage which is mostly connected with programming
2. C# program introduction:
   I wrote my first C# program to print out "Hello World" to the console. I also learned about the structure of a C# program which consisted of the class, the method Main() and contents of the method Main(). I also learned how to run it on a console.
3. Formating rules and case sensitivity in C#:
   I learned about the formatting rules in C# which includes the use of semicolons, braces, and indentation. I also learned that C# is case sensitive which means that variable names and keywords must be used with the correct case.
4. Keywords in C#:
   I learned about the keywords in C# which are reserved words that have a special meaning in the language. I also learned that keywords cannot be used as identifiers like variable names and method names in C#.
5. What happens to a C# program:
   I learned about what i needed to program in C# which is a text editor and the .NET framework. I learned about the process of compiling and executing a C# source code done by the .NET framework and the source code is written with the text editor. The C# code is first compiled into an intermediate language (IL) by the C# compiler, and then the IL is executed by the Common Language Runtime (CLR) which is part of the ls.NET framework.
6. The Visual Studio IDE:
   I learned about the Visual Studio IDE which is a software application that provides a comprehensive environment for developing C# programs. I learned about the features of Visual Studio such as the code editor, debugger, and project management tools. I also learned how to create a new C# project in Visual Studio and how to run it. I also learned the short cuts to compile(F6), run(Ctrl + F5) and debug(F5) a C# program in Visual Studio.
7. The Console class:
   I learned about the Console class which is a part of the System namespace in C#. The Console class provides methods for reading from and writing to the console. I learned about the WriteLine() method which is used to write a line of text to the console and the ReadLine() method which is used to read a line of text from the console. I also learned how to edit how my output is displayed on the console
*/

//Chap 1 code snippet

using System;

class FirstProgram// This is the class and FirstProgram is the name of the class. The class is a container for the method Main() and its contents.
{
    static void Main(string[] args) // This is the method Main() which is the entry point of the program. The method Main() is where the program starts executing. The static keyword means that the method belongs to the class and not to an instance of the class. The void keyword means that the method does not return a value. The string[] args parameter is an array of strings that can be used to pass command-line arguments to the program.
    {
        string first = "Hello World"; // This is a variable declaration and initialization. 
        Console.WriteLine(first);
    }
}


