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
3. **App.config** - store configurations for the app. Maybe its similar to a package.json or maybe a .env file
4. **something.cs** - where we write our code. 

*References seems to be replaced with dependancies. Assembly.info.cs is yet to be seen.*

## Parts of a C# program
We import namespaces using the *using* keyword. A common namespace that we import is System that has the primitives we use in our code an many more utilities.
An example is:
```C#
using System;
// Do some stuff
```
We create a namespace using the *namespace* keyword and a class using the *class* keyword. An example is:
```C#
namespace HelloWorld {
	class Greeting {

	}
}
```
The entry point of C# programs is the **Main** function which I think is in the Program class
The format of functions in C# is:
return-type name (parameters) {
	body
}
To access the attributes or members of a class we use the dot notation i.e **Class.method() or Class.attribute**. An example of a common class is Console which gives us acess to the commnad line. A common method in Console is *WriteLine* that writes a line in the console.
```C#
Console.WriteLine("Hello World!");
```

## Variables And Constants
Variables are declared using the format: *type name = value;* or *type name;*
Constants are declared the same way but you put the *const* keyword at the beginning.

### Naming Conventions
It is common practice to use camelcase to name local variables e.g *str myName;* and to use pascal case when naming constants e.g *str MyName*

### Types in C#
![Types](Screenshot 2023-03-25 171644.png)
```C#
float number = 1.2f; // The compiler treats all float like numbers as double by default so adding f tells the compile that we want 1.2 to be treated as a float
decimal number2 = 1.2m;
```
We have some non-primitive types in C# that are commonly used: class, String, enum and array.
Format strings are created using {pos} where pos indicates the postion the arguement of to write to screen for example:
```C#
string name = "Roman";
Console.WriteLine("Hello my name is {0}", name);
```

### Type Conversion
When the compiler is sure that there is no chance for data loss when changing between 2 types e.g changing from a byte to an int you can do *implicit type conversion*. You don't tell the compiler explicitly that you want to change data types
```C#
byte i = 10;
int num = i; // Since a byte will always fit in an int thus there is no data loss you can perform implicit type conversion
```
When it's possible for data loss to occur you can we need to perform *explicit type conversion* where we prefix the variable with the type we want to be e.g
```C#
int i = 10;
byte b = (byte)i; // We can't do this implicitly because its possible to have an int that is too big to fit in a byte so we have to do explicit type conversion
```
If the types are incompatible e.g a str and an int we use the *Convert* class or the datatypes *parse* method. For example to convert a string to an int:
```C#
str number = '1';
int num = Convert.ToInt32(number);
int num = int.Parse(number);
``` 

### Error Handling
When running code that can cause an error it is advisable to handle the error in the program than to let the application crash. This is done using try catch blocks
```C#
try {
	/// Code that can cause an error
} catch(Exception ex) {
	/// Handle the error
}
```
### Branching
The if-else clause allows you to check for a condition and to perform a different action depending on whether the condition is true or not
```C#
if(condition){
	// Do something
}else {
	// Do something else
}
```
Some logic operations are: 
1. **==** - equality
2. **&&** - AND
3. **||** - OR
4. **!=** - not equal

### Looping
To repeat a condition as long as a condition is true we can use a while loop i.e
```C#
int counter = 0;
while(counter < 10) {
	// Do something as long as counter is less than 10
	counter++;
}
```
If you want to always do something at first before checking the condition then you continue doing the same thing as long as the condition is true you can use a do while loop
```C#
do {
	// Something you have to do once then check a condition to see if you need to do again
} while(condition);
```
When you want to do something many times but you know how may times you are going to do it e.g you want to print every number in a list you use a for loop
```C#
for(start_condition; stopping_condition; change) {
	// Do Something
}
for(int index = 0; index < 10; index++) {
	Console.WriteLine(index);
}
```

### Arrays, Lists and Collections
List<T> is defined in the System.Collections.Generic namespace. Lists are a generic that can be of any type T. Lists are created using the following format:
```C#
var myList = new List<type> {list-contents};
```
List members are accessed using [] braces. The length of a list can be gotten using the *Count* attribute. To iterate over all the items in a list you can use the *foreach* loop
```C#
foreach(<data-type> item in items) {
	// Do Something
}
var numbers = new List<int> {1, 2, 3, 4, 5};
foreach(int num in numbers) {
	Console.WriteLine(num);
}
```
To append an item to a list you can use the *Add* method and to remove you use the *Remove* method.

### Object Oriented Programming
Attributes and methods can have different visibilities e.g private, public, protected, internal(the item is only visible within an assembly). We can tell C# whether certain values can be read(get) or changed (set) by the code(if a value is only given get then it means thats its value cannot be set even in the constructor) etc
```C#
public class MyClass {
	public int myNumber {get; set} // Don't put a semicolon after attribute or method
}
```
Every class has a constructor that is a function(that has not return type) that has the same name as the class and specifies how to create an object of the class. Object attributes can be gotten using the *this* keyword.
```C#
public class MyClass {
	private int myNumber {get; set;}

	public MyClass(int num) {
		this.myNumber = num;
	}
}
```
To create an object of a class we use the *new* keyword.

To access object methods and attributes we use the . notation.

Static items are items that are shared by all instances of the class
```C#
var myObject = new Class(params);
```
To throw an error we write: throw new <error-name>(<error-message>)

## Services in .NET Framework
A service is something that runs in the background or performing a time based operation on a schedule. It's optional for them to have a UI built around them.


