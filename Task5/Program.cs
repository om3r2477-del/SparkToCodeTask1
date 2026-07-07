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
        
    }
    }
}
