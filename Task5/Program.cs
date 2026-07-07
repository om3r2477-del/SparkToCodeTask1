namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1 - Fixed Grades Array

            int[]  greads = new int[5];

            for (int i = 0; i < greads.Length; i++) { 
            
            Console.Write("Enter gread "+(i + 1) + ":");
            greads[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("students gread");
            foreach (int grade in greads)
                Console.WriteLine(grade);

            ////////////////////////////////////////////////////////////////////////

            //Task 2 - Dynamic To-Do List


            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter tsak"+( i + 1)+":");
                tasks.Add(Console.ReadLine());
                }
            Console.WriteLine("List needs to be done:");
            int number = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine(number + "." + task);
                number++;
            }

            ////////////////////////////////////////////////////////////////////////

            //Task 3 - Browsing History Stack

            Stack<string> history = new Stack< string > ();

            for (int i = 0; i < 3; i++) {

                Console.WriteLine("Enter website Url" + (i + 1) + ":");
                history.Push(Console.ReadLine());
            
            }

            history.Pop();

            Console.WriteLine(" after passing back button once");
            Console.WriteLine("You are now on:" + history.Peek());

        }
    }
    }

