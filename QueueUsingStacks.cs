using System;
using System.Collections;

class QueueUsingStacks
{
    private Stack stack1;
    private Stack stack2;

    public QueueUsingStacks()
    {
        stack1 = new Stack();
        stack2 = new Stack();
    }

    // Enqueue operation
    public void Enqueue(int item)
    {
        // Push item onto stack1
        stack1.Push(item);
    }

    // Dequeue operation
    public int Dequeue()
    {
        // If both stacks are empty, queue is empty
        if (stack1.Count == 0 && stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return -1; // Indicating empty queue
        }

        // If stack2 is empty, transfer elements from stack1
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        
        // Pop from stack2
        return (int)stack2.Pop();
    }

    public static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Should print 1
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Should print 2
        queue.Enqueue(4);
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Should print 3
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Should print 4
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Should print Queue is empty.
    }
}
