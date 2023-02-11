# Object-Oriented Programming (OOPs) in C# | OOPs Concept in C#
## How do we Develop Applications?
Object-Oriented Programming is a strategy that provides some principles for developing applications or developing software. It is a methodology. Like OOPs, other methodologies are also existing such as Structured Programming, Procedural Programming, or Modular Programming. But nowadays, one of the well-known and famous styles is Object Orientation i.e. Object-Oriented Programming.

Nowadays, all most all the latest programming languages support object orientation and this object orientation is more related to the designing of software and this deals with the internal design of the software, not the external design. So, it is nowhere related to the users of the software, it is related to the programmers who are working on developing software.

With the help of Object Orientation, the application development or the programming becomes more and more systematic and we can follow the procedures of engineering to develop software. Like in other engineering how a product is developed, in the same way, a software product is developed by adopting object orientation.

If we talk a little bit about other engineering like a civil engineer is constructing a building then first of all he/she will make a plan or will make a design.  While making a design or plan, they may be having many options but they will select one of the designs and finalize it. Then once it is finalized as a blueprint on paper, then they will start constructing. In the same way, an electronic engineer, when he is manufacturing any device, he will come up with some design that is the circuit design of that device on paper. And once that design or blueprint is finalized then he will start manufacturing the device.

So, the point that you need to keep the focus on is on paper we make blueprints or designs or plans. Nowadays, we are not using paper. We have many computer editing tools and we can use those tools to make out designs. But let us just imagine on paper we are working on and we are preparing our design or blueprint or plan on paper. In the same way for developing software we have to do some paperwork, we have to come up with a blueprint or design or plan, and then we need to start developing the application. And a team of programmers can work on a single project and the work can be distributed easily and the work can be reused between the programmers very easily.

So, the **Object Orientation** all depends on how you see the system or how you understand the system. Looking at the system and your perspective is more important. So, if you understand the system perfectly and if your perspective is very clear then you can develop a better system.

Not just Object-Oriented Programming, there are other programming styles that are also available like Procedural Programming, Modular Programming, or Structured Programming but Object-Oriented Programming is a well-known and successful one for software development, and most of the latest languages that are used for application development, they are object-oriented.

## Why Object Orientation?
Let us talk about a manufacturing firm which manufactures cars or vehicles. If you look at that manufacturing farm then it may be working in the form of departments like one is an inventory department that maintains the stock of raw material and one is manufacturing that is the production work that they do and one department will be looking at sales and one department is looking at marketing and one is about payroll and one is for accounts and so on. So, there may be many departments.

Now if you are developing software only for payroll purposes or only for inventory purposes then you may look at the system just like a modular approach and in that you can find the functions like placing an order and checking the item in stock. These types of things you can have a set of functions in that, so you can develop the software only for the inventory system as a collection of functions but when you are developing software for the entire organization then you have to see the things in the form of objects.

So, the inventory item is an object, an employee is an object, an account is an object, and a product manufacturer is an object, the machines that are used for production are an object. So, all these things are objects. Here, you need to see the things in the form of objects and define their data and the functions that they’re performing. We are looking at the system at a higher level. So, we can adopt object orientation.

## What are the Problems of Modular Programming?
Modular programming has the following problems.
1. Reusability
2. Extensibility
3. Simplicity
4. Maintainability

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-490.png)

**Reusability**:  In Modular Programming, we need to write the same code or logic at multiple places which increases the code duplication. Later if we want to change the logic, then we need to change it at all places.

**Extensibility**: It is not possible in modular programming to extend the features of a function. Suppose you have a function and you want to extend it with some additional features then it is not possible. You have to create a completely new function and then change the function as per your requirement.

**Simplicity**: As extensibility and reusability are not possible in Modular Programming, usually we end up with lots of functions and lots of scattered code.

**Maintainability**: As we don’t have Reusability, Extensibility, and Simplicity in modular Programming, it is very difficult to manage and maintain the application code.

## How we can overcome Modular Programming Problems?
We can overcome the modular programming problems (Reusability, Extensibility, Simplicity, and Maintainability) using Object-Oriented Programming. OOPs provide some principles and using those principles we can overcome Modular Programming Problems.

## What Is Object-Oriented Programming?
Let us understand Object-Oriented Programming i.e. OOPs Concepts using C#. Object-Oriented Programming (OOPs) in C# is a design approach where we think in terms of real-world objects rather than functions or methods. Unlike procedural programming language, here in oops, programs are organized around objects and data rather than action and logic.

![pic](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-491-768x407.png)

**Reusability**:
To address reusability, object-oriented programming provides something called Classes and Objects. So, rather than copy-pasting the same code again and again in different places what you can do here is, create a class and make an instance of the class which is called an object, and reuses them whenever you want.

**Extensibility**:
Suppose you have a function and you want to extend it with some new features that were not possible with functional programming. You have to create a completely new function and then change the whole function whatever you want. In OOPs, this problem is addressed by using some concepts called Inheritance, Aggregation, and Composition. In our upcoming article, we will discuss all these concepts in detail.

**Simplicity**:
Because we don’t have extensibility and reusability in modular programming, we end up with lots of functions and lots of scattered code and from anywhere we can access the functions, security is less. In OOPs, this problem is addressed by using some concepts called Abstraction, Encapsulation, and Polymorphism.

**Maintainability**:
As OOPs address Reusability, Extensibility, and Simplicity, we have good maintainable code and clean code which increases the maintainability of the application.


## What are the OOPs Principles or OOPs Concepts in C#?
OOPs, provide 4 principles. They are:
1. Encapsulation
2. Inheritance
3. Polymorphism
4. Abstraction

**Note**: Don’t consider Class and Objects as OOPs principle. We use class and objects to implement OOPs Principles.

## What are Abstraction and Encapsulation?
The process of representing the essential features without including the background details is called **Abstraction**. In simple words, we can say that it is a process of defining a class by providing necessary details to the external world which are required by hiding or removing unnecessary things.

The process of binding the data and functions together into a single unit (i.e. class) is called **Encapsulation**. In simple words, we can say that it is a process of defining a class by hiding its internal data members from outside the class and accessing those internal data members only through publicly exposed methods or properties. Data encapsulation is also called data hiding because by using this principle we can hide the internal data from outside the class.

Abstraction and Encapsulation are related to each other. We can say that Abstraction is logical thinking whereas Encapsulation is its physical implementation.

## Understanding Abstraction and Encapsulation with an Example:
Let us understand Abstraction and Encapsulation Principles with an example. Suppose you want to design one class for providing the register functionality of a user. For that what you need to do is, first you need to get the data and validate the data, then you need to get the connection string for the database, and finally, you need to save the data in the database. And for this, you have three methods i.e. Validate, GetConnectionString, and SaveUser. If you provide access to these three methods to the users of this class, then he may end up calling these methods in the wrong order or it may be possible that he may forget to call any of these methods.

So, here, what you need to do is, you need to create one method called Register and as part of that method you need to call all these methods (Validate, GetConnectionString, and SaveUser) in a proper sequence. And finally, you need to give access to the Register method instead of the Validate, GetConnectionString, and SaveUser methods. This is what we discussed is nothing but abstraction. How you implement this is nothing but encapsulation. So, here, you need to create the Validate, GetConnectionString, and SaveUser methods with private access specifier so that the user cannot access these methods. And make the Register method as Public so that the user can access this method as shown below.

![pioc](https://dotnettutorials.net/wp-content/uploads/2018/07/word-image-492.png)

We can achieve code **Simplicity** through Encapsulation and Abstraction.

## What is Inheritance?
The process by which the members of one class are transferred to another class is called **inheritance**. The class from which the members are transferred is called the Parent/Base/Superclass and the class which inherits the members of the Parent/Base/Superclass is called the Derived/Child/Subclass. We can achieve code **extensibility** through inheritance.

## What is Polymorphism?
The word **Polymorphism** is derived from the Greek word, where Poly means many and morph means faces/ behaviors. So, the word polymorphism means the ability to take more than one form. Technically, we can say that when the same function/operator will show different behaviors by taking different types of values or with a different number of values called **Polymorphism**. There are two types of polymorphism:
1. Static polymorphism/compile-time polymorphism/Early binding.
2. Dynamic polymorphism/Run time polymorphism/Late binding.

Static polymorphism is achieved by using **function overloading** and **operator overloading** whereas dynamic polymorphism is achieved by using **function overriding**.

## Why do we need Object-Oriented Programming (OOPs) in C#?
If you want to represent the real-world objects in a programming language for automating the business by achieving **Reusability**, **Extensibility**, **Simplicity**, and **Maintainability**, then you need the concept of OOPs. OOPs provide some principles and by using those principles we can develop real-world objects in a programming language by achieving Reusability, Extensibility, Simplicity, and Maintainability.

All living and non-living things are considered objects. So real-world objects such as Persons, Animals, Bikes, Computers, etc. can be developed in object-oriented programming languages by using the OOPs concept.

## Why do we need real-world objects in a Project?
We need real-world objects in a project because real-world objects are part of our business. As we are developing applications (software) for automating the business, we must have to create the business-related real-world objects in the project.

For example, to automate the Bank business we must create real-world objects like Customers, Managers, Clerks, Office Assistants, Marketing Executives, Computers, Printers, Chairs, tables, etc. So along with the Bank object, we must also have to create all the above objects because without all the above objects we cannot run a Bank business. Technically we call the above objects business objects.

## What types of programming languages come under the OOP system?
The programming languages which implement all the four principles provided by OOPs are called object-oriented programming languages. Examples: Java, C#, C++, etc.

## Points to Remember:
1. Object-Oriented Programming Principles or OOPs Concepts in C# are design principles that suggest how we should develop a program so that we can reuse it from other layers of the project effectively and with high scalability.
2. Scalability means we have to develop the project in such a way that it should accept future changes without doing major changes in the project, that small changes also should be accepted from external files like properties files, XML files, etc. Scalability is achieved by developing classes by integrating them in a loosely coupled way.
3. We should develop the project with scalability as there will be a growth in business, according to the growth in business we must add required changes to the project with minimal modifications.
4. As a developer, we must remember that in the initial stage of business customer never makes a significant investment. As the business grows customers increase investment according to the growing new requirements are added to the projects. To add those new requirements we should not design the project entirely.
5. So we must design the project by following OOPs principles strictly even though they are not needed at the initial stage but for accepting future changes


