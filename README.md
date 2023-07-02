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


## Resources Used
- [Console Class](https://learn.microsoft.com/en-us/dotnet/api/system.console?view%253Dnet-7.0)
- [File Class](https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view%253Dnet-7.0)
- [Create a .NET console application using Visual Studio Code](https://learn.microsoft.com/en-ca/dotnet/core/tutorials/with-visual-studio-code?pivots%253Ddotnet-7-0)
- [Single-file deployment](https://learn.microsoft.com/en-us/dotnet/core/deploying/single-file/overview?tabs%253Dcli)
