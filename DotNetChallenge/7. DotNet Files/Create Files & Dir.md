# Create files and directories.
The `File` and `Directory` classes in .NET let you create new files and directories programmatically.

So far, you've created a robust command-line application in .NET that can read any folder structure to find files with a .json extension. You'll need to read those files to summarize the data in them. You'll then write the totals to a new file in a new directory called salesTotals.

In this exercise, you'll create the *salesTotalDir* directory and *totals.txt* file where the sales totals will eventually go.

## Create the SalesTotals directory.
1. In the `Program.cs` file, remove the `foreach` loop that iterates and writes each filename returned from the `FindFiles` function to the *Console* output. This will result in the `salesFiles` variable going unused. We'll leave it in here for now because it will be used again in a future lesson.

2. In the `Program.cs` file, create a variable called `salesTotalDir`, which holds the path to the *salesTotalDir* directory:

```cs
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

var salesFiles = FindFiles(storesDirectory);
```

3. In the `Program.cs` file, add code to create the directory:

```cs
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

var salesFiles = FindFiles(storesDirectory);
```

## Write the totals.txt file.
1. In the `Program.cs` file, add the code to create an empty file called *totals.txt* inside the newly created *salesTotalDir* directory. Use an empty string for the file's contents for now:

```cs
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

var salesFiles = FindFiles(storesDirectory);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);
```

2. Press `Ctrl+S` to save the file.
3. Run the program by running the following code from the terminal prompt:

```bash
dotnet run
```

4. Select the Refresh icon in the Files explorer.

![pic](https://learn.microsoft.com/en-us/training/modules/dotnet-files/media/refresh-file-explorer.png)

You're almost finished. The last step is to read the sales files, add up the totals, and write the grand total to the new *totals.txt* file. Next, you'll learn how to read and parse data inside files.