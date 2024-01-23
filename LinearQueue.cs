using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class LinearQueue
    {

        private string[] linearQueue;
        private int front;
        private int rear;
        private string[] dequeuedItems;
         
        public LinearQueue(int s)
        {
            linearQueue = new string[s];
            dequeuedItems = new string[s];
            front = 0;
            rear = -1;
        }
        

        public bool isFull()
        {
            if (rear + 1 == linearQueue.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void enQueue(string d)
        {
            if (isFull() == true)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                rear += 1;
                linearQueue[rear] = d;
            }
        }

        public bool isEmpty()
        {
            if (front > rear)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void deQueue()
        {
            string dequeuedItem;

            if (isEmpty() == true)
            {
                Console.WriteLine("Can't remove anything because there is nothing in the queue.");
                dequeuedItem = "";
            }
            else
            {
                front += 1;
                dequeuedItem = linearQueue[front - 1];
                dequeuedItems.Append(dequeuedItem);
            }
        }

  
    }
}
