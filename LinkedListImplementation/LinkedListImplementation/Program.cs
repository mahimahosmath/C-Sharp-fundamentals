using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
                LinkedList ll = new LinkedList();
                ll.PrintAllNodes();
                Console.WriteLine();

                ll.AddAtLast(12);
                ll.AddAtLast("John");
                ll.AddAtLast("Peter");
                ll.AddAtLast(34);
                ll.PrintAllNodes();
               Console.WriteLine();

                ll.AddAtStart(55);
                ll.PrintAllNodes();
                Console.WriteLine();

                ll.RemoveFromStart();
                ll.PrintAllNodes();

                Console.ReadKey();
       
        }
    }
}
