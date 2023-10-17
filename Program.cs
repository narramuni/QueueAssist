using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            Queues Q = new Queues(10);

            Q.insert(1);
            Q.insert(2);
            Q.insert(3);
            Q.insert(4);
            Q.insert(5);          
            Console.WriteLine(Q.printQueue());

            Q.delete();
            Q.delete();

            Console.WriteLine(Q.printQueue());

            Console.ReadLine(); 
        }

    }
}

