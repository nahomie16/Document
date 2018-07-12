using System;
using System.IO;
using System.Text;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document merger\n");

            String newFileName;
            String filename;

            Console.WriteLine("Enter Document name: ");
            filename = Console.ReadLine();
            newFileName = filename + ".txt";


            while (!File.Exists(newFileName))
            { 
               
                Console.WriteLine("File does not exist.");

                Console.WriteLine("Enter Document name: ");
                filename = Console.ReadLine();
                newFileName = filename + ".txt";


            }
          

            Console.WriteLine("Enter Second Document name: ");
            String filename2 = Console.ReadLine();

            Console.WriteLine("Enter Contents: ");
            String contents = Console.ReadLine();


            String newFileName2 = filename2 + ".txt"; // for the second file

            Console.WriteLine(newFileName);
            Console.WriteLine(newFileName2);

            String line;
            try
            {
                //Pass the file path and file name to the StreamWriter constructor
                StreamWriter sw = new StreamWriter(newFileName);
                StreamWriter sw2 = new StreamWriter(newFileName2); // writing to the second file

                // Write the first line of text
                sw.Write(contents);
                sw.Write("\n");

                //close the file
                sw.Close();

                StreamReader sr = new StreamReader(newFileName);
                line = sr.ReadLine();
                int count = 0;   /// counts numbers of lines 
                String[] words_from_file = new String[10];

                while (line != null)
                {
                    line = sr.ReadLine();
                    count++;

                }
                Console.WriteLine($"{newFileName} was successfully saved  The document contains {contents.Length} characters.");

                //close the file
                sr.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);

            }

            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }
    }
}
