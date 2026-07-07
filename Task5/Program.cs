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

            int number = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine(number + "." + task);
                number++;
            }
       
    }
}
}
