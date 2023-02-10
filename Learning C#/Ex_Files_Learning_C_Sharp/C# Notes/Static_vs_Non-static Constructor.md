# Static vs Non-Static Constructors in C# with Examples

## Point 1:
If a constructor is explicitly declared by using the static modifier, we call that constructor a static constructor whereas the rest of the others are called non-static constructors only. For a better understanding, please have a look at the below code. Non-Static Constructors are also called Instance Constructors in C#.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27892-1.png)


## Point 2:
Constructors are responsible for initializing the fields or variables of a class. Static Fields/Variables are initialized by static constructors and non-static fields/variables are initialized by non-static or instance constructors in C#. For a better understanding, please have a look at the below code. Here, both the variables x and y are initialized with the default values i.e. 0. The variable x is going to be initialized by a static constructor whereas the variable y is going to be initialized by a non-static constructor.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27892-2.png)


## Point 3:
Static constructors are implicitly called whereas non-static constructors are explicitly called. For better understanding, please have a look at the below example. Here, the Program execution is always going to start from the Main method. In the below example, the Main method and Static constructors, both are present in the same classes. So, before executing the body of the Main method, it will execute the static constructor of the class because the static constructor is the first block of code to be executed under a class and once the static constructor execution is completed, then it will execute the Main method body. So, when you will run the below code, you will see that first, the static constructor is executed and then only the Main method is executed.

```cs
using System;
namespace ConstructorDemo
{
    public class ConstructorsDemo
    {
        static int x; //It is going to be initialized by static constructor
        int y; //It is going to be initialized by non-static constructor

        //Static Constructor
        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }

        //Non-Static Constructor
        public ConstructorsDemo()
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }

        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            //Before Executing the body of Main Method, Static Constructor is executed
            Console.WriteLine("Main Method Body..");
            Console.ReadKey();
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27892-3.png)

If you notice, we did not call the Static Constructor anywhere in our code, but it is executed. That means, it is always going to be called Implicitly. In the above example, we have not called the no-static constructors, and hence the non-static constructor is not executed.


## Point 4:
Static Constructors execute immediately once the execution of a class start and moreover, it is the first block of code to run under a class whereas non-static constructors execute only after creating the instance of the class as well as each and every time the instance of the class is created.

For a better understanding, please have a look at the below example. In the below example, the Main method and Static constructors are present in two different classes. So, the Program execution started from the Main method and it will start executing the Main method body. Then inside the Main method, we are creating the instance of ConstructorsDemo class i.e. we are trying to execute ConstructorsDemo class for the first time and as this class has a static constructor, that static constructor will implicitly be called and once that static constructor completes its execution, then only the instance is being created and the non-static constructor is executed.

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");

            //Creating Object of ConstructorsDemo
            //Now the ConstructorsDemo class Execution Start
            //First, it will execute the Static constructor 
            //Then it will execute the non-static constructor
            ConstructorsDemo obj = new ConstructorsDemo();
            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
    }

    public class ConstructorsDemo
    {
        static int x; //It is going to be initialized by static constructor
        int y; //It is going to be initialized by non-static constructor

        //Static Constructor
        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }

        //Non-Static Constructor
        public ConstructorsDemo()
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27892-4.png)

In the above example, the execution takes place as follows:
1. First, the Main method of the Program class starts its execution as it is the entry point for our application.
2. Then the Static Constructor of the ConstructorsDemo class is executed.
3. Then the Non-Static Constructor of the ConstructorsDemo class is executed.
4. Finally, the Main method completes its execution.

## Summary of Static and Non-Static Constructors:
1. A constructor is a special method inside a class used to initialize the data members. If we create the constructor using a static modifier then we call it a static constructor and the rest of all are non-static constructors only.
2. The static constructor is used to initialize the static data members and the non-static constructor is used to initialize the non-static data members of a class.
3. The static constructor is always invoked implicitly while the non-static constructor is always invoked explicitly.
4. If we have not defined any constructor explicitly, then the compiler will provide the implicit constructor in the following conditions.
5. For a static class, the compiler will provide a static constructor implicitly, but no non-static constructor.
6. For a non-static class, the compiler will provide a non-static constructor, if the non-static class has any static member, then only the compiler will provide the static constructor.
7. Static constructors will execute only once during the life cycle of a class and non-static constructors are executed 0 or n number times. If we have not created any object, then the constructor will execute 0 times and if we create n number of objects, then the constructor will execute n number of times.
8. In a class, we can have only one static constructor and i.e. too parameterless, and hence static constructor cannot be overloaded. But, in a class, we can define any number of non-static constructors and hence non-static constructors as overloaded.
9. A static constructor is executed when our class execution starts and it will execute only once and it will be the first block inside a class to be executed while non-static constructors are going to be executed when we create an instance of a class and for each instance of the class.


## Private Constructors in C#
### What is a private constructor?
In C#, when the constructor is created by using the **Private Access Specifier**, then it is called a **Private Constructor**. When a class contains a private constructor and if the class `does not have any other Public Constructors`, then you `cannot create an object for the class outside of the class`. But we can `create objects for the class within the same class`. 

So, the most important point that we need to keep in mind is that the restrictions such as restrictions for creating objects, restrictions for accessing members, etc. will come into the picture when you are trying to create the objects and accessing the members from outside the class. If you are creating the objects and accessing the members within the same class, then no such restrictions come into the picture.

### Creating Object using Private Constructor within the same class in C#:
Many articles on the web say that you cannot create an instance of the class if it has a private constructor. But this is partially true. You cannot create an instance from outside the class, but you can create the instance from within the class. For a better understanding, please have a look at the below example. Here, in the Program class, we defined a private constructor and the Main method is also defined in the same Program class. As you can see, within the Main method, we are creating an instance of the Program class and calling the Method1.

```cs
using System;
namespace PrivateConstructorDemo
{
    class Program
    {
        //Private Constructor
        private Program()
        {
            Console.WriteLine("This is Private Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 is Called");
        }

        static void Main(string[] args)
        {
            //Creating instance of Program class using Private Constructor
            Program obj = new Program();
            obj.Method1();
            Console.ReadKey();
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/07/word-image-28092-1.png)


## Creating an Instance from Outside the Class in C#:
The point that you need to remember is while creating the instance from outside the class, the class should have a public constructor. It does not matter if a class has a private constructor or not, but if a class has a public constructor, then using that public constructor, we can create the class instance and invoke the public non-static members.

For a better understanding, please have a look at the below example. Here, we have the Test class with both Private and Public constructors and a public method. Now, from the Program class Main method (which is outside of the Test class), we are creating an instance of the Test class and invoking the Methdo1.

```cs
using System;
namespace PrivateConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating instance of Test class using public Constructor
            Test obj = new Test(10);
            obj.Method1();
            Console.ReadKey();
        }
    }

    public class Test
    {
        //Private Constructor
        private Test()
        {
            Console.WriteLine("This is Private Constructor");
        }

        //Public Constructor
        public Test(int x)
        {
            Console.WriteLine("This is public Constructor");
        }

        public void Method1()
        {
            Console.WriteLine("Method1 is Called");
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/07/word-image-28092-2.png)

