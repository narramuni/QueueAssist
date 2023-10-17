using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAssist
{
    public class Queues
    {
        private int[] element;
        private int front;
        private int rear;
        private int max;

        public Queues(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if (rear == max - 1)
            {
                return;
            }
            else
            {
                element[++rear] = item;
            }
        }

        public int delete()
        {
            if (front == rear + 1)
            {
                return -1;
            }
            else
            {
                return element[front++];
            }
        }

        public string printQueue()
        {
            string retVal = "";
            if (front == rear + 1)
            {
                return retVal;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    retVal += element[i] + " ";
                }
            }
            return retVal;
        }
    }
}


