using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6_GIT_EXERCISE
{
    enum TaskStatus
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3
    }
    class TaskItem
    {
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
    }
    internal class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void PrintMenu()
        {
            Console.WriteLine("\n--- TASK MANAGER ---");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. Change Task Status");
            Console.WriteLine("3. View Tasks by Status");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
        }

        static void CreateTask()
        {
            Console.WriteLine("enter task Title");
            string title=Console.ReadLine();

            TaskItem task = new TaskItem
            {
                Title = title,
                Status = TaskStatus.Pending
            };
            tasks.Add(task);
            Console.WriteLine("task crated with status pending");
        }

        static void ChangeTaskStatus()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
                return;
            }
            DisplayAllTasks();
            Console.WriteLine("select task number :");
            int index=Convert.ToInt32(Console.ReadLine())-1;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("invalid task selection");
                return;
            }
            Console.WriteLine("1.Pending\n2.InProgress\n3.Completed");
            Console.Write("Select new status:");
            int statusChoice=Convert.ToInt32(Console.ReadLine());
            if(Enum.IsDefined(typeof(TaskStatus), statusChoice))
            {
                tasks[index].Status = (TaskStatus)statusChoice;
                Console.WriteLine("Task status updated");
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }
        
        static void ViewTasksByStatus()
        {
            Console.WriteLine("1.Peding\n2.InProgress\n3.Completed");
            Console.WriteLine("choose status:");
            int choice=Convert.ToInt32(Console.ReadLine());
            if(!Enum.IsDefined(typeof(TaskStatus), choice))
            {
                Console.WriteLine("Invalid Status");
                return;
            }
            TaskStatus selectedStatus = (TaskStatus)choice;
            Console.WriteLine($"\nTasks With status {selectedStatus}:");

            bool found = false;
            foreach(TaskItem task in tasks)
            {
                if(task.Status == selectedStatus)
                {
                    Console.WriteLine("-" + task.Title);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No tasks found");
            }
        }
        static void DisplayAllTasks()
        {
            Console.WriteLine("\nAll Tasks:");
            for(int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{tasks[i].Title}[{tasks[i].Status}]");
            }
        }
        
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateTask(); break;

                    case 2:
                        ChangeTaskStatus();
                        break;
                    case 3:
                        ViewTasksByStatus(); break;
                    case 4:
                        running = false; break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
