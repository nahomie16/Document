using System;
using System.IO;


namespace Document
{
    class Program
    {
        int number = 9;

        static void Main(string[] args)
        {
            Console.WriteLine("Document merger\n");

            String newFileName;
            String filename;
            String user_continue;
            do
            {
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
                String newFileName2 = filename2 + ".txt"; // for the second file


                while (!File.Exists(newFileName2))
                {

                    Console.WriteLine("File does not exist.");

                    Console.WriteLine("Enter Second Document name: ");
                    filename2 = Console.ReadLine();
                    newFileName2 = filename2 + ".txt";
                }


                string merge = filename + filename2;
                string mergeTxt = merge + ".txt";

                string contents = " ";                  // Stores the contents of merged files 


                String line2;
                try
                {


                    StreamWriter sw3 = new StreamWriter(mergeTxt);      // writing to the merged file


                    StreamReader sr = new StreamReader(newFileName);        // reading to the first file
                    StreamReader sr2 = new StreamReader(newFileName2);      // reading  to the second file


                    String line;
                    bool IsEmpty = true;            // Checks if the first file is empty
                    bool IsEmpty2 = true;           // Checks if the second file is empty


                    while ((line = sr.ReadLine()) != null)
                    {  // Read first file 
                       //Console.WriteLine(line);
                        sw3.WriteLine(line);
                        IsEmpty = false;
                        contents += line; 
                    }


                    while ((line2 = sr2.ReadLine()) != null)      // Read second file 
                    {  // Read first file 
                       //Console.WriteLine(line2);
                        sw3.WriteLine(line2);
                        IsEmpty2 = false;
                        contents += line2;

                    }

                    if (IsEmpty && IsEmpty2)
                    {

                        Console.WriteLine("Both of these files are empty");
                    }

                    //close the file
                    sr.Close();
                    sw3.Close();
                    sr2.Close();


                    Console.WriteLine($"{newFileName} was successfully saved  The document contains {contents.Length} characters.");


                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);

                }

                finally
                {
                    Console.WriteLine("Executing finally block.");
                }

                Console.WriteLine("Would like to merge two more files: ");

            }

            while (Console.ReadLine().ToLower().StartsWith('y')); 
        }
    }
}
