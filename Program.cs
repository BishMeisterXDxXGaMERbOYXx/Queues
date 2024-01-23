namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinearQueue q = new LinearQueue(10);

            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.enQueue("Hi");
            q.deQueue();
            
        }
    }
}