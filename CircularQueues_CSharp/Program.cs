using System;
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
            else
            {
                //if rear is at the last position of the array, then the value
                //of rear is set to 0 that corresponds to the first position of
                //the array
                if (REAR == max - 1)
                    REAR = 0;
                else
                    //if rear is not at the last position, then 
                    //its value is incremented by one.
                    REAR = REAR + 1;
            }
            //Once the position of rear is determined, the element is
            // added at its proper place.
            queue_array[REAR] = element;
        }
        public void remove()
        {
            //checks whether the queue is empty
            if(FRONT == -1)
            {
                Console.WriteLine("\nQueue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + 
                queue_array[FRONT] + "\n");
            //checks if the queue has one element.
            if(FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                if(FRONT == max - 1)
                    FRONT = 0;
                else
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            if(FRONT == -1)
            {
                Console.WriteLine("\nQueue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are...........\n");
            if (FRONT_position <= REAR_position)
            {
                while (FRONT_position <= REAR_position)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while(FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;  
                }
                FRONT_position = 0;
                while(FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break ;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
