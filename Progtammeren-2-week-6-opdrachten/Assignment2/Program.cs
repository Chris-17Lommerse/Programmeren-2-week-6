namespace Assignment2
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
            SafeFileReadWrite();
        }
        
        void SafeFileReadWrite()
        {
            Console.Write($"Enter data to write to the file: ");
            string input = Console.ReadLine();
            try
            {
                string fileName = "safe_data.txt";
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(input);
                writer.Close();
                Console.WriteLine($"Data written successfully. ");
                Console.WriteLine();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: Unable to write to file");
            }

            StreamReader reader = new StreamReader("safe_data.txt");
            Console.WriteLine($"Reading file content: ");
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
        }
    }
}
