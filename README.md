# Name Sorter
This is a command-line application that reads a list of names from a file, sorts them by last name first and then by given names, and writes the sorted list to a new file.

## Build
To build the application, run the following command:
```
dotnet publish -c Release
```

This will create a `name-sorter.exe` file under `NameSorter\bin\Release\net7.0\win-x64` folder.

## Usage
To use the application, run the following command:
```
name-sorter.exe <filename>
```

Replace `<filename>` with the path to the file containing the list of names.

For example:
```
name-sorter.exe unsorted-names-list.txt
```

This will read the list of names from `unsorted-names-list.txt`, sort them, and write the sorted list to a new file named `sorted-names-list.txt`.

## Dependencies
This application was created with .NET 7.0


## SOLID Principles
This project was designed with the SOLID principles in mind to make it more maintainable and scalable. Here's how we used each of the SOLID principles:

### Single Responsibility Principle (SRP)
We used the `SRP` by separating the responsibilities of the Main method into separate classes. The `ArgumentsChecker` class is responsible for checking the command-line arguments, the `FileReader` class is responsible for reading the file, the `Sorter` class is responsible for sorting the lines, and the `FileWriter` class is responsible for writing the sorted lines to a new file.

### Open/Closed Principle (OCP)
We used the `OCP` by encapsulating the sorting algorithm in the `Sorter` class and making it easy to add new sorting strategies by implementing the `ISorter` interface. This makes it easy to add new sorting strategies without modifying existing code.

### Liskov Substitution Principle (LSP)
No implmentation needed here because there is no inherited classes.

### Interface Segregation Principle (ISP)
We used the `ISP` by creating interfaces for each of the classes (`IArgumentsChecker`, `IFileReader`, `ISorter`, and `IFileWriter`) to encapsulate their behavior and make it easy to swap out implementations.

### Dependency Inversion Principle (DIP)
We used the `DIP` by injecting the abstractions of `ArgumentsChecker`, `FileReader`, `Sorter`, and `FileWriter` into the `Program` class. This makes the `Program` class dependent on abstractions rather than concrete implementations, which makes it easier to test and maintain.


## Resources Used
- [Console Class](https://learn.microsoft.com/en-us/dotnet/api/system.console?view%253Dnet-7.0)
- [File Class](https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view%253Dnet-7.0)
- [Create a .NET console application using Visual Studio Code](https://learn.microsoft.com/en-ca/dotnet/core/tutorials/with-visual-studio-code?pivots%253Ddotnet-7-0)
- [Single-file deployment](https://learn.microsoft.com/en-us/dotnet/core/deploying/single-file/overview?tabs%253Dcli)
- [SOLID Principles In C# With Examples](https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/)
