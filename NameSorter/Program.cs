namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var argumentsChecker = new ArgumentsChecker();
            if (!argumentsChecker.ValidArguments(args))
            {
                return;
            }

            var fileReader = new FileReader();
            var fileWriter = new FileWriter();
            var sorter = new Sorter();

            string filename = args[0];
            var lines = fileReader.ReadLines(filename);
            var sortedLines = sorter.Sort(lines);
            fileWriter.WriteLines("sorted-names-list.txt", sortedLines);
        }
    }

    public interface IArgumentsChecker
    {
        bool ValidArguments(string[] args);
    }

    public class ArgumentsChecker : IArgumentsChecker
    {
        public bool ValidArguments(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("error: no arguments provided");
                return false;
            }

            string filename = args[0];

            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} does not exist");
                return false;
            }

            return true;
        }
    }

    public interface IFileReader
    {
        string[] ReadLines(string filename);
    }

    public class FileReader : IFileReader
    {
        public string[] ReadLines(string filename)
        {
            return File.ReadAllLines(filename);
        }
    }

    public interface IFileWriter
    {
        void WriteLines(string filename, string[] lines);
    }

    public class FileWriter : IFileWriter
    {
        public void WriteLines(string filename, string[] lines)
        {
            File.WriteAllText(filename, string.Empty);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                File.AppendAllText(filename, line + "\n");
            }
        }
    }

    public interface ISorter
    {
        string[] Sort(string[] lines);
    }

    public class Sorter : ISorter
    {
        public string[] Sort(string[] lines)
        {
            return lines.OrderBy(line => line.Split(" ").Last())
                        .ThenBy(line => string.Join(" ", line.Split(" ").Reverse().Skip(1).Reverse()))
                        .ToArray();
        }
    }
}