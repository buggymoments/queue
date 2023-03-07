using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        
        queue.Enqueue("apple");
        queue.Enqueue("banana");
        queue.Enqueue("cherry");

        foreach (string fruit in queue)
        {
            Console.WriteLine(fruit);
        }
    }
}
