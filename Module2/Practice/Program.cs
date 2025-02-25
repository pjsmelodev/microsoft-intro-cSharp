using System;

public class ToDoList {
    // Create an array called tasks that can hold up to 10 tasks.
    public static string[] tasks = new string[10];

    // Create a variable called taskCount to keep track of how many tasks have been added.
    public static int taskCount = 0;

    // Step 3: Adding a Task
    public static void AddTask() {
        if (taskCount < tasks.Length) {
            Console.Write("Enter a task: ");
            tasks[taskCount] = Console.ReadLine();
            taskCount++;
        } else {
            Console.WriteLine("Task list is full! Cannot add more tasks.");
        }
    }

    // Step 4: Viewing Tasks
    public static void ViewTasks() {
        if (taskCount == 0) {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("Your tasks:");
        for (int i = 0; i < taskCount; i++) {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    // Step 5: Marking a Task as Completed
    public static void CompleteTask() {
        if (taskCount == 0) {
            Console.WriteLine("No tasks available to complete.");
            return;
        }

        ViewTasks();
        Console.Write("Enter the number of the task to complete: ");
        
        if (int.TryParse(Console.ReadLine(), out int selectedTaskNo)) {
            selectedTaskNo--; // Convert to zero-based index
            
            if (selectedTaskNo >= 0 && selectedTaskNo < taskCount) {
                tasks[selectedTaskNo] += " -> Completed";
                Console.WriteLine("Task marked as completed!");
            } else {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    // Step 6: Running the Program
    public static void Main(string[] args) {
        bool loopStatus = true;

        while (loopStatus) {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark a task as complete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    loopStatus = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}
