# Class and Objects in C# with Examples
## Class and Objects from Layman’s Point of View.
Most people will say that everything that you can see and touch in the world is an object and there is a class for it. So let us understand what it means. Classes come from classification. If you take anything in the world you can say that this belongs to so-and-so class. If you take a group of students at a college then you can say that these students belong to computer science, and this is a class of computer science and these students belong to electronics and this is the class of electronics.

So, here, we are classifying based on the subject or the course they are going through. It means that classification is based on the criteria that we are adopting.

So, classification is done based on some criteria or the common things that you can find in them. We define classes in our daily life. Any 4-wheeler vehicle in which there is a driver and some people are sitting at the back or beside the driver, then we say it’s a car. So, this is the classification depending on the property we are defining. So, based on the properties we can define whether it is a truck or it is a car and both are vehicles again, so the vehicle is again a class.

If we take examples of human beings, it is a class. There’s a class human and you are an object of human being class. The BMW is a car and Toyota is also a car. These are the objects of class cars. So, class is a definition and objects are instances.

Some companies provide housing facilities for their employees. They will have some cargo or apartments or independent houses. All the apartments will be similar because they follow the same design. So, design is one and there are the houses or the apartments or the flats that are based on the design. This design is nothing but class and the houses created with the help of that design are objects.

Design is nothing but the blueprint of the house object. So, the house will be having all those things that are defined in the design plan or in the blueprint.

So, every engineer does some paperwork or designing work, and based on that design the manufacturing is done. When you make a product, that product will be having all those things that are there in the design and you can then make many products based on that design.

A car company will design a new car. Then they will manufacture many cars based on that design. So, all those cars are objects and the design that the company is holding with them is a class. In the same way, we also want to write a class and create objects in our program.

## Class and Objects from Programming Language Point of View.
### Class:
A class is simply a user-defined data type that represents both state and behavior. The state represents the properties and behavior is the action that objects can perform. In other words, we can say that a class is the blueprint/plan/template that describes the details of an object. A class is a blueprint from which the individual objects are created. In C#, `a Class is composed of three things i.e. a name, attributes, and operations`.

### Objects:
It is an instance of a class. A class is brought live by creating objects. An object can be considered as a thing that can perform activities. The set of activities that the object performs defines the object’s behavior. All the members of a class can be accessed through the object. To access the class members, we need to use the dot `(.) operator`. The **dot operator links the name of an object with the name of a member of a class**.

### How can we create a Class and Object in C#?
Let us understand how to create class and object in C#:
 In order to understand this, please have a look at the following image. As you can see in the below image, a class definition starts with the keyword `class` followed by the `class name` (here the class name is Calculator), and the class body is enclosed by a pair of `curly braces`. As part of the class body, you define `class members` (properties, methods, variables, etc.). Here as part of the body, we define one `method` called CalculateSum. The class Calculator is just a template. In order to use this class or template, you need an object. As you can see in the second part of the image, we create an object of the class Calculator using the `new` keyword. And then store the `object reference` on the variable `calObject` which is of type Calculator. Now, using this `calObject` object we can access the class members using a dot.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/08/word-image-334.png)

**So, the point that you need to remember is, to create a class you need to use the class keyword while if you want to create an object of a class then you need to use the new keyword. Once you create the object then you can access the class members using the object.**


### The complete example code:

```cs
using System;
namespace ClassObjectsDemo
{
    class Program
    {
        //Defining class or blueprint or template
        public class Calculator
        {
            public int CalculateSum(int no1, int no2)
            {
                return no1 + no2;
            }
        }
        static void Main(string[] args)
        {
            //Creating object
            Calculator calObject = new Calculator();

            //Accessing Calculator class member using Calculator class object
            int result = calObject.CalculateSum(10, 20);  //Output: 30

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
```

## Difference between Class and Objects in C#
Many programmers or developers still get confused by the difference between class and object. As we already discussed, in object-oriented programming, a Class is a template or blueprint for creating Objects, and every Object in C# must belong to a Class. The following diagram illustrates the difference between them.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/08/Difference-between-Class-and-Objects-in-C.jpg)

As you can see in the above image, here we have one class called “Employee”. All the Employees have some properties such as employee id, name, salary, gender, department, etc. These properties are nothing but the attributes (properties or fields) of the Employee class.

So, the idea is that the template or blueprint of the Employee is not going to change. Each and every Object is going to build from the same template (Class) and therefore contains the same set of methods and properties. Here, all Objects share the same template but maintain a separate copy of the member data (Properties or fields).

For example: If we create two employees, let’s say Emp1 and Emp2, then both Emp1 and Emp2 are Employees, so they can be classified as belonging to the Employee class. Both have the same methods (InsertData and DisplayData) but are different in models (properties or fields).


## Types of Classes in C#:

![pic](https://dotnettutorials.net/wp-content/uploads/2018/08/Types-of-Classes-in-C-768x252.jpg)

In C# we have the below types of classes:
1. Abstract Class
2. Concrete class
3. Sealed Class
4. Partial Class
5. Static Class


## Constructors in C#
### What is a Constructor in C#?
It is a special method present inside a class responsible for initializing the variables of that class.

The name of the constructor method is exactly the same name as the class in which it was present. You cannot change the name. If your class name is Employee, then the name of the constructor method is going to be Employee, and if your class name is Student, then the constructor name is also going to be Student.

The constructor method does not return any value. That means it is a non-value returning method. Generally, methods are of two types i.e. value returning and non-value returning and constructors are purely non-value returning. That is, they never return any value.

### Example to Understand Constructor in C#
Each and every class requires this constructor if we want to create the instance of the class. If we don’t have a constructor, then we cannot create an instance of the class. At this point, you have one doubt, earlier we defined many classes but we never used a constructor, but still, we are able to create the instance of the class, how? Let us clarify this doubt. Suppose, we have a class as follows:

```cs
    class Test
    {
        int i;
    }
```
Then, we create an instance of the above Test class somewhere in our application as follows:
`Test obj = new Test();`

Is the above statement valid? Yes, it is valid. The reason is that it is the responsibility of a programmer to define a constructor under his class and if he/she fails to do, on behalf of the programmer an implicit constructor gets defined in that class by the compiler. For a better understanding, look at the below diagram which shows the code before and after compilation.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-1.png)

You can see here that after compilation, the compiler adds the public constructor to the class and initializes the variable and this is the responsibility of a constructor i.e. **initializing the variables of that class**. Here, it is initializing the variable with 0. If a class variable is initialized implicitly means that is done by a constructor.

Every variable we declared inside a class and every field we declared inside a class has a default value. All numeric types are initialized with 0, Boolean types initialized with false, and string and object types initialized with null. For a better understanding, please have a look at the below image.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-2.png)

Like this, the initialization is performed for each and all variables present in the class and this is the responsibility of the constructor. That is why a constructor is very important for us inside a class.

We are **not assigning a value**, but a value is coming there means someone has assigned the value to these variables. So, who is going to do that? The constructor is going to do that. And this constructor is not defined by us. Then who defined this constructor? The compiler defined this constructor for us. And we call this an **Implicit Constructor**. And if we defined the same thing, then it is called an **explicit constructor**.

### Points to Remember while working with Constructors in C#:
1. Implicitly Defined Constructors are parameter less and these constructors are also known as Default Constructors. This is because they are used to initialize the variables with default values.
2. Implicitly Defined Constructors are public. If you see in our example, we define the class Test with a default access specifier but the constructor is public which is generated by the compiler.
3. We can also define a constructor under the class and if we define it, we can call it an Explicit Constructor and an Explicit Constructor can be parameter less and parameterized also.

### Example to Understand Implicitly Constructor in C#:
In the below example, we are creating a class with three variables and in the class, we have not defined any constructor explicitly. So, here compiler will provide the implicit constructor and will initialize the variables with the default value. Then from the Main method, we create an instance of the class and print the values of the variables and it should print the default values based on the variable type. For example, for int, the default value is 0, for bool the default value is false, and for string or object the default is null. And this default initialization is done by the implicit constructor which is given by the compiler.

```cs
using System;
namespace ConstructorDemo
{
    class Test
    {
        public int i;
        public bool b;
        public string s;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine($"i = {obj.i}");  //Output: 0
            Console.WriteLine($"b = {obj.b}");  //Output: False

            //value null will be printed, so here we checking the null
            if (obj.s == null)
            {
                Console.WriteLine("s = null");  //Output: null
            }

            Console.ReadKey();
        }
    }
}
```

### How to Define the Constructor Explicitly in C#?
We can also define the constructor explicitly in C#. The following is the explicit constructor syntax.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/How-to-Define-the-Constructor-Explicitly-in-C.jpg)

Whenever we are creating an instance, there will be a call to the class constructor. For a better understanding, please have a look at the below example. Here, we defined one parameter less constructor explicitly, and then from the Main method, we create an instance. When we create the instance, it will make a call to the constructor, and the statements written inside the constructor will be executed. In this case, it will execute the print statement in the console.

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExplicitConstructor obj = new ExplicitConstructor();
            
            Console.ReadKey();
        }
    }
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor is Called!");  //Output: Explicit Constructor is Called! 
        }
    }
}
```
One more important point that you need to remember is, how many instances you created, and that many times the constructor is called for us. Let us prove this. Please modify the example code as follows. Here, I am creating the instance four times and it should and must call the constructor 4 times and we should see the print statement four times in the console window.

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor obj2 = new ExplicitConstructor();
            ExplicitConstructor obj3 = new ExplicitConstructor();
            ExplicitConstructor obj4 = new ExplicitConstructor();

            Console.ReadKey();
        }
    }
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor is Called!");  //Output: Explicit Constructor is Called! x4
        }
    }
}
```
### We should not use the word Implicitly while calling the constructor in C#, why?
See, if we are not defining any constructor explicitly, then the compiler will provide the constructor which is called Implicitly Constructor. See, the following example. If you move the mouse pointer over the Test class, then you will see the following. Here, Test is a class present under the ConsructorDemo namespace.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-5.png)

Now, move the mouse pointer to Test() as shown in the below image. Here, the first Test is the class name and the second Test() is the constructor. That means we are calling the constructor explicitly.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-6.png)

Here, we are explicitly making a call to the constructor and when we call the constructor, the implicit constructor which is provided by the compiler is called and will initialize the variables.

Now coming to the ExplicitConstructor example, we are also doing the same thing. Please have a look at the below example. If you move the mouse pointer over the ExplicitConstructor class, then you will see the following. Here, ExplicitConstructor is a class present under the ConsructorDemo namespace.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-7.png)

Now, move the mouse pointer to ExplicitConstructor() as shown in the below image. Here, the first ExplicitConstructor is the class name and the second ExplicitConstructor() is the constructor. That means we are calling the constructor explicitly.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-8.png)

Here, we are explicitly making a call to the constructor and when we call the constructor, the explicit constructor which is provided by us is called and will initialize the variables. So, here you might be confused with terms. Defining and calling.


### Defining and Calling Constructor in C#:
**Defining:** Defining a constructor means implementing a constructor in your class. Defining can be two types i.e. Implicit and Explicit. Implicit means the compiler will define the constructor. Explicit means we as a programmer define the constructor. The following code shows defining a constructor explicitly.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-9.png)

**Calling:** Whenever we are creating the instance, we are calling the constructor. Calling is Explicit. We should only call. There is no implicit call to the constructor. For a better understanding, please have a look at the below code.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-10.png)

The calling should be done explicitly by us. That may be an implicit or explicit constructor but calling the constructor should be explicit.


                                    ## Frequently Asked Interview Questions:
## What is a Constructor in C#?
In simple words, we can define the constructors in C# are the special types of methods of a class that are executed whenever we create an instance (object) of that class. The Constructors are responsible for two things. One is the object initialization and the other one is memory allocation. The role of the new keyword is to create the object and the role of the constructor is to initialize the variables.

## What are the rules to follow while working with C# Constructor?
1. The constructor’s name should be the same as the class name.
2. It should not contain a return type even void also.
3. As part of the constructor body return statement with a value is not allowed.

## What does a Constructor have in C#?
1. It can have all five accessibility modifiers i.e. public, private, protected, etc.
2. The constructor can be parameterless or parameterized.
3. It can have a throws clause which means we can throw an exception from the constructor.
4. The constructor can have logic, as part of logic it can have all C#.NET legal statements except return statements with value.
5. We can place a return; in the constructor.

**Syntax:**

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-11.png)

## Can we define a method with the same class name in C#?
No, it is not allowed to define a method with the same class name in C#. It will give you a compile-time error. For a better understanding, please have a look at the below image.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-1122-12.png)


