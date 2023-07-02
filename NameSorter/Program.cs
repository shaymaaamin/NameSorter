namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("error: no arguments provided");
                return;
            }

            string filename = args[0];

            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} does not exist");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            lines = lines.OrderBy(line => line.Split(" ").Last())
                        .ThenBy(line => string.Join(" ", line.Split(" ").Reverse().Skip(1).Reverse()))
                        .ToArray();

            File.WriteAllText("sorted-names-list.txt", string.Empty);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                File.AppendAllText("sorted-names-list.txt", line + "\n");
            }

        }
    }
}