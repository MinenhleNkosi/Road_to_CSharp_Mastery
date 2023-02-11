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


## Types of Constructors in C# with Examples
### Types of Constructors in C#
There are five types of constructors available in C#, they are as follows:
1. Default or Parameter Less Constructor
2. Parameterized Constructor
3. Copy Constructor
4. Static Constructor
5. Private Constructor

Let’s discuss each of these constructors in detail with examples.

### Default or Parameterless Constructors in C#
If a constructor method does not take any parameters, then we call that a Default or Parameter Less Constructor. These constructors can be defined by a programmer explicitly or else will be defined implicitly provided there is no explicit constructor under the class. So, the Default or Parameterless Constructors are again classified into two types. They are as follows:
1. System-Defined Default Constructor
2. User-Defined Default Constructor

### What is System Defined Default or Parameterless Constructor in C#?
As a programmer, if we are not defined any constructor explicitly in our program, then by default the compiler will provide one constructor at the time of compilation. That constructor is called a default constructor and the default constructor is parameterless. The default constructor will assign default values to the data members (non-static variables). As this constructor is created by the system this is also called a system-defined default constructor.

### Example to understand System-Defined Implicit or Default Constructor in C#:
In the below example, within the Employee class, we have created a few variables. And then from the Main method, we created an instance of the Employee class and then printed the values of the variables.

```cs
using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;
    }
    class Test
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Employee Id is:  " + e1.Id);  //Employee Id is: 0
            Console.WriteLine("Employee Name is:  " + e1.Name);  //Employee Name is: null
            Console.WriteLine("Employee Age is:  " + e1.Age);  //Employee Age is: 0
            Console.WriteLine("Employee Address is:  " + e1.Address);  //Employee Address is: null
            Console.WriteLine("Is Employee Permanent:  " + e1.IsPermanent); //Is Employee Permanent: false
            Console.ReadKey();
        }
    }
}
```
In our example, we have not specified these default values. Then who provided these default values and when? These default values are provided by the default constructor based on the variable data type and the compiler will provide the default constructor at the time of compilation. So, the Employee class will be converted as follows after compilation:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-2.png)

As you can see the Implicit Constructor which is always public and parameterless initialize the variables with default values and these default values you are seeing in the output. As this Implicit Constructor initializes the variables with default values, we also called this a System Defined Default Constructor.

**Note:** The point that you need to keep in mind is that the Compiler will only provide the default constructor if a programmer has not defined any constructor explicitly.

### When do we need to provide the Constructor Explicitly?
If we want to execute some custom logic at the time of object creation, that logic may be object initialization logic or some other useful logic, then as a developer, we must provide the constructor explicitly in C#.

### What is a User-Defined Default Constructor in C#?
The constructor which is defined by the user without any parameter is called the user-defined default constructor. This constructor does not accept any argument but as part of the constructor body, you can write your own logic.

### Example to understand User-defined Default Constructor in C#
In the below example, within the Employee class, we have created a public parameterless constructor which is used to initialize the variables with some default hard-coded values. And then from the Main method, we created an instance of the Employee class and invoke the Display method.

```cs
using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        //User Defined Default Constructor
        public Employee()
        {
            Id = 100;
            Age = 30;
            Address = "Midrand";
            Name = "Minenhle";
            IsPermanent = true;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);  //Employee Id is: 100
            Console.WriteLine("Employee Age is:  " + Age);  //Employee Age is: 30
            Console.WriteLine("Employee Address is:  " + Address);  //Employee Address is: Midrand
            Console.WriteLine("Employee Name is:  " + Name);  //Employee Name is: Minenhle
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);  //Is Employee Permanent: true
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Display();

            Console.ReadKey();
        }
    }
}
```
The Employee class constructor is also called a Default Constructor because it is public and parameter-less.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-4.png)

And more importantly, it does not matter how many objects are being created for the Employee class, each instance or object is initialized with the same set of values. This is the reason we call it a Default Constructor. As this constructor is created by the user, so we call it a User-Defined Default Constructor.

**Note:** The drawback of the above user-defined default constructor is that each and every instance (i.e. object) of the class will be initialized (assigned) with the same set of values. That means it is not possible to initialize each instance of the class with different values. For a better understanding, please modify the Main method as follows and see the output.

```cs
class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Display();  //Same results as above
        Employee e2 = new Employee();
        Console.WriteLine();
        e2.Display();  //Same results
        Console.ReadKey();
    }
}
```

### When should we define a parameterized constructor in a class?
If we want to initialize the object dynamically with the user-given values or if we want to initialize each instance of a class with a different set of values then we need to use the Parameterized Constructor in C#. The advantage is that we can initialize each instance with different values.

### What is Parameterized Constructor in C#?
If a constructor method is defined with parameters, we call it a Parameterized Constructor in C#, and these constructors are defined by the programmers only but never can be defined implicitly. So, in simple words, we can say that the developer-given constructor with parameters is called Parameterized Constructor in C#.

Let us understand Parameterized Constructor in C# with Examples. Please have a look at the below code. Here, we have a class called ParameterizedConstructor, and this class has one constructor which is taking one integer parameter. As this constructor takes a parameter, we call it a Parameterized Constructor. And in this constructor, we are printing the i value.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-6.png)

And now, when you are going to create an instance of the ParameterizedConstructor class, it will ask you for the integer parameter value as shown in the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-7.png)

Now, you can pass an integer value. Suppose, we pass the value 10, then that value 10 will directly come to variable i which is then printed on the console. For a better understanding, please have a look at the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-8.png)

The complete example code is given below:

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj = new ParameterizedConstructor(10);
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called: {i}");  //Output: 10
        }
    }
}
```

So, in this way, we can create any number of instances of the class, and while creating the instance we can pass different values and those values will go and sit in the variable i. In the below example, we are creating two different instances of ParameterizedConstructor class with two different values:

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
    }
}
```
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-9.png)

### When should we use Parameterized Constructor in C#?
With the help of a Parameterized constructor, we can initialize each instance of the class with a different set of values. That means using parameterized constructor we can store a different set of values in different instances created in the class.

Let us understand this with an example. Please have a look at the below class. This is the same class that we worked on in our previous example with some changes. Now, in the class, I have declared a variable called x. Remember, this variable x is initialized with default value only i.e. 0. Why default value? Because we didn’t assign a value and when we don’t assign a value, the constructor will take the responsibility of assigning a value. And the value for x is going to be 0. Then we created a method called Display where we print the x value.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-10.png)

Now, let us call this Display method using two different instances. The complete example code is given below:

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            obj1.Display();
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            obj2.Display();
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
```

**Output**
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-11.png)

As you can see in the above image, for both the instances it is printing the x value as 0. In instance one we pass 10 to the constructor and in instance two we pass 20 to the constructor. So, can we use the values 10 and 20 in place of x? Yes, it is possible. How it is possible? By using Parameterized constructor only. Let us see how we can do this. Inside the constructor, we can assign the x variable with the value of "i" as shown in the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-12.png)

With the above changes in place, now if you run the application, then it will print 10 and 20 for the x variable. The complete example code is given below:

```cs
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            obj1.Display();
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            obj2.Display();
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            //Initializing the variable
            x = i;
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
```

The output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-13.png)

As we have created two instances separately i.e. obj1 and obj2. So, internally two copies of the x variable are available in the memory for us. For a better understanding, please have a look at the below diagram. As you can see in the below image, we have two separate objects i.e. obj1 and obj2. For obj1 we have one copy of the x variable with the value 10 is there and the obj2 another copy of the x variable with the value 20 is there in the memory:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-14.png)

### Copy Constructor in C#:
If we want to create multiple instances with the same values then we need to use the copy constructor in C#, in a copy constructor the constructor takes the same class as a parameter to it.
Let us understand Copy Constructor in C# with Examples. Please have a look at the below code. This is the same code that we have written in our previous example:

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            Console.ReadKey();
        }
    }

    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");  //Value of x = 10
        }
    }
}
```

Now, we want to create another instance with the same value. Then we can create another instance as follows:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-16.png)

See, passing one parameter is not a difficult task. Suppose, the constructor takes 10 or 20 parameters, then it is a time-consuming and error-prone process to pass the same 10 or 20 parameters. We can overcome this problem by using Copy Constructor in C#. The copy constructor takes a parameter of the same class type. How we can pass a class name as a parameter. This is because a class is a user-defined data type. For a better understanding, please have a look at the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-17.png)

With the above changes, now you can see we have two constructors as shown in the below image. One constructor takes an int as a parameter and the other constructor takes the CopyConstructor type as a parameter.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-18.png)

So, can we define multiple constructors in a class? Yes, we can. Constructors can be overloaded in C#. The complete example code is given below. Now, we are passing obj1 as a parameter to the copy constructor.

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();  //Value of x = 10
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();  //Value of x = 10
            Console.ReadKey();
        }
    }

    public class CopyConstructor
    {
        int x;

        //Parameterized Constructor
        public CopyConstructor(int i)
        {
            x = i;
        }

        //Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
```
Now, the memory is separate for each instance but the value is going to be the same for both instances. For a better understanding, please have a look at the below diagram.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-20.png)

### How many Constructors can be Defined in a Class in C#?
In C#, within a class, we can define any number of constructors. But the most important point that you need to remember is that each and every constructor must have a different signature. A different signature means the number, type, and parameter order should be different. So, in a class, we can define one no-argument constructor plus ‘n’ number of parameterized constructors in C#.

### Static Constructor in C#
In C#, it is also possible to create a constructor as static and when we do so, it is called a Static Constructor. If a constructor is declared explicitly by using the static modifier, then it is called a static constructor in C#. All the constructors we defined till now are non-static or instance constructors.

For a better understanding, please have a look at the below example. In a static constructor, you cannot use any access specifiers like public, private, and protected.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-22.png)

But, when you compile the above skeleton, the compiler will provide the default parameter less constructor. For a better understanding, please have a look at the below code:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-23.png)

### Points to Remember while working with Static Constructors in C#:
**Point1:**
If a class contains any static variables, then only implicit static constructors come into the picture otherwise we must define them explicitly. On the other hand, non-static constructors will be implicitly defined in every class (except the static class) provided we didn’t define any constructor explicitly.

**Point2:**
Static Constructors are responsible for initializing static variables and these constructors are never called explicitly. They are called Implicitly and moreover, these constructors are the first to execute in any class. For a better understanding, please have a look at the below example. Here, we have defined one static constructor, and please observe from the Main method we are not calling the Static constructor.

```cs
using System;
namespace ConstructorDemo
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
            Console.ReadKey();
        }
    }
}
```
Now, when you execute the above code, the Static constructor will execute first and then the main method. And this proves the following output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-24.png)

The non-static constructors are never called implicitly, they are always called explicitly whereas the static constructor never called explicitly, they are always going to be called implicitly. How does the execution happen? See, the Main method is the starting point of execution, and in this case no difference. The program execution will start from the Main method but before executing any statement inside the Main method, it will first execute the Static constructor and once the Static Constructor execution is completed, then it will continue the execution of the Main method. So, the static constructor is the first block of code in a class to be executed.

**Point3:**
Static Constructors cannot be parameterized, so overloading of the static constructors is not possible in C#. Now, the question is why we cannot parameterize the static constructor? The answer is simple. The static constructors are executed implicitly and hence we never get a chance to pass a value. And as the static constrictor is the first block to be executed in a class, and hence there is no chance to pass a value.

### Points To Remember About Static Constructor in C#:
1. There can only be one static constructor in a class.
2. It can’t be called explicitly, it is always called implicitly.
3. The static constructor should be without any parameters.
4. It can only access the static members of the class.
5. There should not be any access specifiers in the static constructor definition.
6. If a class is static then we cannot create the object for the static class.
7. It is called automatically to initialize the static members.
8. Static constructor will be invoked only once i.e. at the time of class loading.

### Can we initialize non-static data members within a static constructor in C#?
It is not possible to initialize non-static data members within a static constructor, it raises a compilation error. For a better understanding, please have a look at the following example:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-26.png)

### Can we initialize static data fields within a non-static constructor in C#?
Yes, we can initialize static data members within a non-static constructor. Consider the following example for better understanding:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27825-27.png)

### What is a Private Constructor in C#?
In C#, it is also possible to create a constructor as private. The constructor whose accessibility is private is known as a private constructor. When a class contains a private constructor then we cannot create an object for the class outside of the class. So, private constructors are used to create an object for the class within the same class. Generally, private constructors are used in the Remoting concept.

### Example to understand Private Constructor in C#:

```cs
using System;
namespace ConstructorDemo
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("This is private constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Main method");
            Console.ReadKey();
        }
    }
}
```

### Points To Remember about C# Private Constructor:
1. Using Private Constructor in C# we can implement the singleton design pattern.
2. We need to use the private constructor in C# when the class contains only static members.
3. Using a private constructor is not possible to create an instance from outside the class.


## Why do we need Constructors in C#?
Every class requires a constructor to be present in it if we want to create the instance of that class. Every class contains an implicit constructor if not defined explicitly by the programmer and with the help of that implicit constructor, we can create the instance of that class.

If we don’t define any constructors, then an implicit constructor is there which is provided by the compiler at the time of compilation and using that implicit constructor we can create the instance, then the question is why do we need to define the constructor explicitly again or when do we need to define an explicit constructor in C#?

### What is the need of Defining a Constructor Explicitly Again?
This is one of the frequently asked interview questions. Let us understand this. Implicit Constructors of a class will initialize variables of a class with the same value even if we create multiple instances of that class.

Let us understand this with an example. Please have a look at the following code. Here, we have a class called First with one variable and then from inside the Main method, we are creating three instances of the First class:

```cs
using System;
namespace ConstructorDemo
{
    class First
    {
        public int x = 100;
    }
    class Test
    {
        static void Main(string[] args)
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine($"{f1.x}   {f2.x}   {f3.x}"); //Output: 100 100 100
            Console.ReadKey();
        }
    }
}
```
Now, internally, it allocates the memory separately for each instance as shown in the below image. The point that you need to remember, we created three instances and these three instances have a copy of x. And the value is going to be the same for all.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-1.png)

This is the problem. Right now, the class contains a constructor i.e. Implicit constructor. And that constructor is going to initialize the variable x with the value 100. So, how many instances we are going to be created, all the instances will be created with the same value.

If we define constructors explicitly with parameters then we will get a chance of initializing the fields or variables of the class with a new value every time we are going to create the instance of that class.

Now, observe the below example, here we have created another class called Second, and this class has a variable called x. Now, the implicit constructor will initialize the x variable with the default value 0 when we created an instance of the Second class and the same for each instance.

```cs
using System;
namespace ConstructorDemo
{
    class First
    {
        public int x = 100;
    }
    class Second()
    {
        //Initialize with default value
        public int x;
    }
    class Test
    {
        static void Main(string[] args)
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine($"{f1.x}   {f2.x}   {f3.x}");  //100 100 100

            Second s1 = new Second();
            Second s2 = new Second();
            Second s3 = new Second();
            Console.WriteLine($"{s1.x}   {s2.x}   {s3.x}");  //0 0 0
            Console.ReadKey();
        }
    }
}
```

Now, I want the x value to be different under the three instances. What value, I don’t know. I will know the value when I am going to create the instances. Remember one thing whenever we are creating a class, it means we can reuse the class and we can create the instance whenever and wherever we want. That is code reusability.

So, in the future whenever I am going to create an instance of the class Second, I only need to send the value for x. This is the scenario where we need to go for or define an explicit parameterized constructor. Let us modify the Second class as follows to add one explicit parameterized constructor to initialize the x variable:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-3.png)


Here, this.x refers to the class variable x. See, when I select this.x, automatically the class variable x is highlighted as shown in the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-4.png)


And here x refers to the local variable x. See, when I select x, automatically the local variable x is highlighted as shown in the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-5.png)


This means the local variable x is being assigned to the class variable x. Now, while creating the instance of the Second class, we need to pass a value and that value is stored inside the local variable x. And in this way, while creating multiple instances of the class Second, we can pass different values as shown in the below image:

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-6.png)


The complete example code is given below:

```cs
using System;
namespace ConstructorDemo
{
    class First
    {
        public int x = 100;
    }
    
    class Second
    {
        public int x;

        //Parameterized Explicit Constructor
        public Second(int x)
        {
            this.x = x;
        }
    }
    
    class Test
    {
        static void Main(string[] args)
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine($"{f1.x}   {f2.x}   {f3.x}");

            Second s1 = new Second(100); //100 wll send to local variable x
            Second s2 = new Second(200); //200 wll send to local variable x
            Second s3 = new Second(300); //300 wll send to local variable x

            Console.WriteLine($"{s1.x}   {s2.x}   {s3.x}");
            Console.ReadKey();
        }
    }
}
```

Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-7.png)

**Note:** The following diagram shows the memory architecture of the above example. Here, for the First class, all the instances contain the same value for x. On the other hand, for class Second, all the instances have a different value and this is possible because of the Explicit Parameterized Constructor in C#.

![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-8.png)

**When we define a class, first identify whether the class variables require some values to execute and if they are required then define a constructor explicitly and pass values through the constructor, so that every time the instance of the class is created, we get a chance of passing new values.**

**Note:** Generally, every class requires some values for execution, and the values that are required for a class to execute are always sent to that class by using the constructor only.

### Parameterized Constructor Real-time Example in C#
With the help of a Parameterized constructor, we can initialize each instance of the class with a different set of values. That means using parameterized constructor we can store a different set of values in different objects created in the class. For a better understanding, please have a look at the below example:

```cs
using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        //User Defined Parameterized Constructor
        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            IsPermanent = isPermanent;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Name is:  " + Age);
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 30, "Midrand", "Minenhle", true);
            e1.Display();
            Console.WriteLine();

            Employee e2 = new Employee(101, 28, "Carlswald", "Jetro", false);
            e2.Display();
            Console.ReadKey();
        }
    }
}
```

Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-9.png)

### Copy Constructor Real-time Example in C#
The constructor which takes a parameter of the class type is called a copy constructor. This constructor is used to copy one object’s data into another object. The main purpose of the copy constructor is to initialize a new object (instance) with the values of an existing object (instance). For a better understanding, please have a look at the below example:

```cs
using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        //Parameterized Constructor
        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            IsPermanent = isPermanent;
        }

        //Copy Constructor
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Age = emp.Age;
            Address = emp.Address;
            Name = emp.Name;
            IsPermanent = emp.IsPermanent;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Name is:  " + Age);
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 30, "Midrand", "Minenhle", true);
            e1.Display();
            Console.WriteLine();
            
            Employee e2 = new Employee(e1);
            e2.Display();
            Console.ReadKey();
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-10.png)

### Static Constructor Real-time Example in C#
The static Constructor in C# will be invoked only once. There is no matter how many instances (objects) of the class are created, it is going to be invoked only once and that is when the class is loaded for the first time.

The static constructor is used to initialize the static fields of the class. You can also write some code inside the static constructor which is going to be executed only once. The static data members in C# are created only once even though we created any number of objects.

```c
using System;
namespace StaticConstructorDemo
{
    class Example
    {
        int i;
        static int j;

        //Default Constructor
        public Example()
        {
            Console.WriteLine("Default Constructor Executed");
            i = 100;
        }

        //static Constructor
        static Example()
        {
            Console.WriteLine("Static Constructor Executed");
            j = 100;
        }
        public void Increment()
        {
            i++;
            j++;
        }
        public void Display()
        {
            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of j : " + j);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.Increment();
            e1.Display();
            e1.Increment();
            e1.Display();
            Example e2 = new Example();
            e2.Increment();
            e2.Display();
            e2.Increment();
            e2.Display();
            Console.ReadKey();
        }
    }
}
```
Output:
![pic](https://dotnettutorials.net/wp-content/uploads/2022/06/word-image-27828-11.png)




