using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for Document Name
            Console.WriteLine("Document:");
            string DocName;
            DocName = Console.ReadLine();

            //Asking to Write in Document
            Console.WriteLine("Enter Content for {0}:", DocName);
            string Content;
            Content = Console.ReadLine();

            //Character Count
            int count = 0;
            foreach(char c in Content)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }

            //Making of Document
            try
            {
                StreamWriter sw = new StreamWriter(DocName + ".txt");
                sw.WriteLine(Content);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error. Failed to process document." + e.Message);
            }
            finally
            {
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", DocName, count);
            }

            //Prevents program from ending automatically
            Console.ReadKey();
        }
    }
}
