using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class CircularQueue
    {
        private string[] circularQueue;
        private String[] deQueuedItems;
        private int front, f;
        private int rear;
        private string dequeuedItem;

        public CircularQueue(int s)
        {
            circularQueue = new string[s];
            deQueuedItems = new string[s];
            front = 0;
            rear = -1;
        }

        public bool isFull()
        {
            if ((rear + 1) % circularQueue.Length == front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool initialised()
        {
            return front == 0 && rear == -1;
        }

        public bool isEmpty()
        {
            return ((front + 1) % circularQueue.Length == 0 && rear == circularQueue.Length - 1) || ((front + 1) > rear && !initialised()) && !isFull() || initialised();
        }
        public void enQueue(string d)
        {
            if (initialised() || !isFull())
            {
                rear = (rear + 1) % circularQueue.Length;
                circularQueue[rear] = d;
            }
            else
            {
                Console.WriteLine("Full queue, remove item first!");
            }
        }

        public void deQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue empty");
            }
            else
            {
                front = (front + 1) % circularQueue.Length;
                dequeuedItem = circularQueue[front];
                f += 1;
                dequeuedItems[f] = dequeuedItems;
            }

        }


    }
}
