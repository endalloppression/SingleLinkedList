using System;
using System.IO;

namespace SingleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers you will be entering: ");
            var textWriter = new StreamWriter(@"C:\Users\LinuxBox1\source\repos\SLL\test.txt", true);

            var head = new SinglyLinkedList();

            int headCount = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Please enter each of the integers followed by enter: (do NOT enter more numbers than initialized!) ");
            for (int i = 0; i < headCount; i++)
            {             
                int headItem = Convert.ToInt32(Console.ReadLine().Trim());
                head.InsertNode(headItem);
            }

            int result = Result.maximumPages(head.head);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
