using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTracker
{
    class TaskTracker
    {
        static TaskTracker obj;
        CommandHelper commandHelper = new CommandHelper();
        public static TaskTracker GetInstance()
        {
            if (obj == null)
                obj = new TaskTracker();
            return obj;
        }
        public void UserInputTask()
        {
            
            string input = Console.ReadLine();
            if (!input.StartsWith("task-cli"))
            {
                Console.WriteLine("Command is not Valid . Try Again");
                return;
            }
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Command is not Valid . Try Again");
                return;
            }

            var commands = input.Split(" ");
            string error = string.Empty;
            foreach(string command in commands)
            {
                if (commandHelper.IsCommandExists(command))
                {
                    error = string.Empty;
                    if (commandHelper.ExecuteCommand(out error)==false)
                    {
                        Console.WriteLine("Executation Failed " +
                            Environment.NewLine +
                            error);
                        break;
                    }
                }
            }
        }
    }
}
