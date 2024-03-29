# Introduction.
Imagine you're a software developer working for a ski resort. You are launching a new application, which will let users view trail maps and purchase lift tickets on your website or from their mobile phones. You want to create an ASP.NET Core web application to complement and advertise the app. Being a Visual Studio developer, you want to use Visual Studio 2022 to create, deploy, and manage your new site.

Visual Studio and Azure App Service provide a powerful mechanism for creating, publishing, and maintaining web apps in Azure. Here, you will learn how to use the publishing features built in to Visual Studio to deploy and manage ASP.NET Core web applications hosted on Azure.

## Learning objectives.
In this module, you'll:
* Create an **ASP.NET Core** web app in **Visual Studio**
* **Publish** a web app to **Azure** using **Visual Studio**
* **Update** a web app in **Visual Studio** and **publish** the changes to **Azure**

## Prerequisites
* Knowledge of the Azure cloud environment
* Familiarity with Visual Studio 2022
* Familiarity with web app concepts
* Basic programming knowledge
* Basic HTML knowledge
* A local installation of Visual Studio 2022 or a later version

------
# Install the necessary workloads.
The first step in getting your new site ready is to prepare your development environment. Creating and deploying ASP.NET Core web applications requires that you have the necessary tools installed on your local machine. Here, we'll cover the development tools you need and how to install them.

## Configure your Development environment.
We'll need to install a few more tools within Visual Studio to build, debug, and deploy ASP.NET Core web applications to Azure. To install these tools, we'll install two Visual Studio *workloads*.

## What are Visual Studio workloads?
A *workload* is a pre-configured bundle of tools within Visual Studio. These bundles are grouped to allow developers to build certain types of applications, use certain development languages, or develop for specific platforms.

For example, the *Desktop development with C++* workload includes Visual Studio features that let you run and debug C++ console applications. The *Mobile development with .NET* workload installs all of the tools you need to create mobile applications with .NET.

## Visual Studio workloads for ASP.NET Core development and publishing.
Visual Studio 2022 has two workloads that you need to create, publish, and deploy your website to Azure. These workloads include the templates for your ASP.NET Core site and let you connect and deploy your site to Azure.

With Visual Studio 2022 installed, you need to make sure you have the following Visual Studio workloads installed:
* **ASP.NET and web development**: The web development workload in Visual Studio is designed to maximize your productivity in developing web applications using ASP.NET and standards-based technologies like HTML and JavaScript.
* **Azure development**: The Azure development workload in Visual Studio installs the latest Azure SDK for .NET and tools for Visual Studio. Once you've installed these items, you can create resources using Azure Resource Manager tools, build applications for Azure web and Cloud Services, and perform big data operations using Azure Data Lake tools.

##  Installing Visual Studio workloads.
You can use the Visual Studio Installer to modify the components installed as part of Visual Studio including workloads.
1. To launch the Installer, from your Windows Start menu, scroll down to V, and then select Visual Studio Installer. Alternatively, while the Start menu is open, you can just type `Visual Studio Installer` to find the Installer link, then select **Enter**.
2. The Visual Studio Installer window appears. Select the **Modify** button.
3. Ensure the **ASP.NET and web development and Azure development** workloads are selected under the **Web & Cloud** section of the **Workloads** tab.
4. Next, select the **Modify** button on the bottom right of the Installer. The Visual Studio Installer will download and install the necessary components.
5. When the install completes, select **Launch** to open Visual Studio.

Workloads are added to your local Visual Studio installation, and you only need to install them once. You can launch the Visual Studio Installer in the future to add more workloads, customize installed workloads, or remove them.
To complete the exercises in this module, you'll need the ASP.NET and web development and Azure development workloads installed. If you haven't already, install these workloads before moving onto the next exercise.