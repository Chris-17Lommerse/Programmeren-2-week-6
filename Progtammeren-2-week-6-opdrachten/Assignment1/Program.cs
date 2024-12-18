namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            WriteToFile();
            ReadFromFile();
        }

        void WriteToFile()
        {
            Console.Write($"Enter a text to save to file: ");
            string input = Console.ReadLine();
            string fileName = "user_input.txt";

            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(input);
            Console.WriteLine($"Data written to file successfully");
            Console.WriteLine();
            writer.Close();
        }

        void ReadFromFile()
        {
            Console.WriteLine($"Reading from file: ");
            string fileName = "user_input.txt";
            StreamReader reader = new StreamReader(fileName);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
        }
    }
}
