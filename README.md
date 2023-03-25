# C# Tutorial
This is the code I'll write while learning C#. The goal of this tutorial is to be able to read and understand some C# code that I need for a project.

**Course Link: https://www.youtube.com/watch?v=gfkTfcpWqAY**

## C# vs .NET
C# is a programming language while .NET is a framework used for building apps in windows. .NET can be thought of as something like React that is just a framework used for building Single Page Applications. Like React, .NET supports multiple languages including F# and VBNet. 
.NET has the Common Language Runtime and Class Library

## Common Language Runtime(CLR)
This allows programs written with .NET to be able to run on machines of different architectures (x86 or other) and different OSs. What happens is that when the C# code is compiled it doesn't produce machine code, it instead produces IL Code (Intermediate Language).

IL Code is platform independent meaning that as lonf as the CLR is there to convert it to machine code the code can run anywhere.

The CLR converts the IL to machine code of the platform it is running on

## .NET Architecture
The simplest component of a .NET application is a class that has data and methods. In .NET applications classes interact with each other to create a final product. For example you could have a class that deals with the database interacting with a class that deals with your frontend to create an app.

Many related classes are stored in a namespace. In the example above all the functionalities of the database could be stored in a namespace while all the classes that make up the frontend e.g a button class text class etc could be stored in a namespace. Namespaces make it easier to work with a large number of classes.

Namespaces can also be combined to form assemblies that are either DLLs (Dynamic Link Libraries) or .EXEs. When the application runs multiple assemblies are loaded and executed.

## Parts of a C# Application
1. **Assembly.info.cs** - has information about the assembly that will be formed after the application written is combiled. It defines things such as copyright, name, etc
2. **References** - a list of the assemblies used when creating the application e.g an application for accesing the database if that is required etc.
3. **
