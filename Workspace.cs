using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_to_consol
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string content;

            Console.WriteLine("Document \n\n");

            Console.WriteLine("Please name the document: ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please write the content for this document: ");
            content = Console.ReadLine();
            Console.WriteLine();
            int numOfChars = content.Length;

            name += ".txt";

            File.Create(name);
            StreamWriter sw = new StreamWriter(name);

            sw.WriteLine("{0}", content);
            sw.Close();

            if (name == null && content == null)
            { 
                Console.WriteLine("Document name and content did not save. Exiting program.");
                return;
            }
            
            else
            {
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", name, numOfChars);
                return;
            }
        }
    }
}
