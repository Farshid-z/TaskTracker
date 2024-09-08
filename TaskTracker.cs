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
        public void GetUserCommand()
        {        
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !input.StartsWith("task-cli"))
            {
                Console.WriteLine("Command is not Valid . Try Again");
            }
            else
            {
                ExecuteCommands(input);
            }
            GetUserCommand();
        }
        public bool ExecuteCommands(string input)
        {
            var userCommand = input.Split(" ");
            string command = userCommand[1]; // main Command
            string param = string.Empty;
            if(userCommand.Length>2)
                param= userCommand[2]; // params of command

            if (commandHelper.IsCommandExists(command))
            {
                if (commandHelper.ExecuteCommand(param,out string error) == false)
                {
                    Console.WriteLine("Executation Failed " +
                        Environment.NewLine +
                        error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
