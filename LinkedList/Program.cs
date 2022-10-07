using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            //declaration of linked list
            LinkedList<Task> list = new LinkedList<Task>();

            //varaible collection
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter task number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter task weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter task start date: ");
            DateTime startdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter task end date: ");
            DateTime enddate = DateTime.Parse(Console.ReadLine());

            //option for entering a new task
            Task firstTask = new Task(title, num, weight, startdate, enddate);
            list.AddFirst(firstTask);
            Console.WriteLine("Do you want to enter another task: ");
            Console.WriteLine("Enter 0 for No and any other number for Yes ");
            string s = Console.ReadLine();
            int.TryParse(s, out option);


            //if option is true then loop will run until it is false
            while (option != 0)
            {
                //collection of variables for new task
                Console.Write("Enter task title: ");
                string ntitle = Console.ReadLine();
                Console.Write("Enter task number: ");
                int nnum = int.Parse(Console.ReadLine());
                Console.Write("Enter task weight: ");
                double nweight = double.Parse(Console.ReadLine());
                Console.Write("Enter task start date: ");
                DateTime nsdate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter task end date: ");
                DateTime nedate = DateTime.Parse(Console.ReadLine());
                Task newTask = new Task(title, num, weight, startdate, enddate);
                LinkedListNode<Task> first = list.First;
                list.AddAfter(first, newTask);
                Console.WriteLine("Do you want to enter another task: ");
                Console.WriteLine("Enter 0 for No and any other number for Yes ");
                int.TryParse(Console.ReadLine(), out option);
                firstTask = newTask;
            }

            //loop that will display all inputted variables for each entry
            foreach (Task task in list)
            {
                Console.WriteLine(task);
            }

            Console.ReadLine();
        }
    }
}
