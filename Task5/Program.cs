namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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


            /////////////////////////////////////////////////////////////////////

            //Task 4 - Customer Service Queue

            Queue<string> customer = new Queue<string>();

            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter customer" + (i + 1) + ":");
                customer.Enqueue(Console.ReadLine());
            }
            string serveCustomer = customer.Dequeue();
            Console.WriteLine("customers served:"+ serveCustomer);

            ///////////////////////////////////////////////////////////////////////////////////////

            //Task 5 - Array Grade Range

            int[] greadss = new int[5];

            for(int i = 0; i < greadss.Length; i++)
            {
                Console.WriteLine("Enter grade" + (i + 1) + ":");
                greadss[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(greadss);

            int total = 0;
            for(int i = 0; i < greadss.Length; i++)
                {
                total += greadss[i];

            }
            double avrage = (double)total / greadss.Length;

            Console.WriteLine("the highst grade:" + greadss[greadss.Length - 1]);
            Console.WriteLine("the lowest:" + greadss[0]);
            Console.WriteLine("the avrage:" + avrage);

            //////////////////////////////////////////////////////////////////////////////
            
            //Task 6 - Filtered Shopping List


            List<string> shopingList = new List<string>();

            string item = "";
            while(item != "done")
            {
                Console.WriteLine("Enter an item or type done:");
                 item = Console.ReadLine();

                if(item != "done")
                {
                    shopingList.Add(item);
                }
                
            }

            Console.WriteLine("Shopping list before removing:");

            foreach(string shopingItem in shopingList)
            {
                Console.WriteLine(shopingItem);

            }

            Console.WriteLine("Enter n item to remove:");
            string remooveitem = Console.ReadLine();

            shopingList.Remove(remooveitem);

            Console.WriteLine("shoping list after remove");

            foreach(string shopingItem in shopingList)
            {
                Console.WriteLine(shopingItem);
            }
            ///////////////////////////////////////////////////////////////////////////////////
            
            //Task 7 - High Score Podium

            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter game score" + (i + 1) + ":");
                scores.Add(Convert.ToInt32(Console.ReadLine));


            }
            scores.Sort();
            scores.Reverse();

            Console.WriteLine("First place :" + scores[0]);
            Console.WriteLine("second place :" + scores[1]);
            Console.WriteLine("therd place :" + scores[2]);
            ///////////////////////////////////////////////////////////////////////////////////////

            */
            // Task 8 - Undo Last Action 

            Stack<string> actions = new Stack<string>();

            string  action = "";

            while(action != "stop")
            {
                Console.WriteLine("Enter an action or type (stop)");
                action = Console.ReadLine();

                if(action != "stop")
                {
                    actions.Push(action);
                }
            }

            Console.WriteLine("undo the actions:");

            Console.WriteLine("undone :" + actions.Pop());
            Console.WriteLine("undone :" + actions.Pop());

            Console.WriteLine("rename actions:");

            foreach(string renameaction in actions)
            {
                Console.WriteLine(renameaction);
            }
        }
    }
}

