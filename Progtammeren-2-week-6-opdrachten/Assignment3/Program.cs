namespace Assignment3
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
            SaveMultipleEntries();
        }

        void SaveMultipleEntries()
        {
            try
            {
                string input = Console.ReadLine();
                string fileName = "records.txt";
                StreamWriter writer = new StreamWriter(fileName);
                while (input != "exit")
                {
                    Console.Write($"Enter a name (type 'exit' to stop): ");
                    input = Console.ReadLine();
                    writer.WriteLine(input);
                }

                writer.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Attempting to save records to file...");
                Console.WriteLine($"Error: Unable to save records. Please check file permissions or if the file is in use.");
            }

            Console.WriteLine($"Records saved to file: ");
            StreamReader reader = new StreamReader("records.txt");
            string content = reader.ReadLine();
            Console.WriteLine(content);
            reader.Close();
        }
    }
}
