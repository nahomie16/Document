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
                // "[filename] was successfully saved. The document contains [count] characters." and exit. [filename] and[count] are placeholders for the filename of the document and the number of characters it contains.

                StreamReader sr = new StreamReader(newFileName);
                line = sr.ReadLine();
                int count = 0;   /// counts numbers of lines 
                String[] words_from_file = new String[10];

                while (line != null){
                    Console.WriteLine(line);
                    count += 1;
                    line = sr.ReadLine();
                
                }
                //close the file
                sr.Close();
                Console.WriteLine($"{newFileName} was successfully saved and it contains {count} lines");

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
