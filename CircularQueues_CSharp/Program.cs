﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            //Initializing the values of the variables REAR and FRONT to -1
            //to indicate that the queue is initially empty
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            //This statement check for overflow condition
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            //The following  statement checks whether the queue is empty.
            //If the queue is empty, then the value of the rear and front
            //variabel is set to 0.
            if(FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
