using EFCoreProject2.Models;
namespace EFCoreProject2
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProjectContext  context = new ProjectContext();

            //register employee
            Console.WriteLine("Register employee");

            Employee e1 = new Employee();

            Console.WriteLine("enter name");
            e1.EmpName = Console.ReadLine();

            Console.WriteLine("enter age");
            e1.EmployeeAge = int.Parse(Console.ReadLine());

            Console.WriteLine("enter salary");
            e1.EmployeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("enter ssn");
            e1.EmployeeSsn = int.Parse(Console.ReadLine());

            context.employees.Add(e1);
            context.SaveChanges();

            // delete employee
            Console.WriteLine("enter employee ID to delete");
            int id = int.Parse(Console.ReadLine());

            Employee employee = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                Console.WriteLine("employee not found");
            }
            else
            {
                context.employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}
