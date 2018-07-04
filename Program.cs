using System;
using System.IO;
using System.Text;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document");

            Console.WriteLine("Enter Document name: ");
            String filename = Console.ReadLine();

            Console.WriteLine("Enter Contents: ");
            String contents = Console.ReadLine();


            String newFileName = filename + ".txt";

            Console.WriteLine(newFileName); 

    
            String line;
            try
            {
                
                //Pass the file path and file name to the StreamWriter constructor
                StreamWriter sw = new StreamWriter(newFileName);


                // Write the first line of text
                sw.Write(contents);
                sw.Write("\n");

                //close the file
                sw.Close();
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
