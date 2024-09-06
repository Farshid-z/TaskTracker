using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTracker
{
    class CommandHelper
    {
        public static Dictionary<string, string> commands = new Dictionary<string, string>();
        string _command = string.Empty;
        public string Command
        {
            get
            {
                return _command;
            }
            set
            {
                _command = value;
            }
        }
        public CommandHelper()
        {
            commands.Add("add","Add");
            commands.Add("update", "UpdateTask");
            commands.Add("delete","DeleteTask");
            commands.Add("list", "ListAllTasks");
        }
        /// <summary>
        /// If command is valid or not
        /// </summary>
        /// <returns></returns>
        public bool IsCommandExists(string command)
        {
            Command = command;
            return IsCommandExists();
        }
        public bool IsCommandExists()
        {
            if (string.IsNullOrEmpty(Command))
                return false;
            if (commands.ContainsKey(_command))
                return true;

            return false;
        }
        public bool ExecuteCommand(string param,out string Error)
        {
            /// This Method Run only if command is exists
            Error = string.Empty;
            string selectedCommand = commands[Command];
            var type = Type.GetType("TaskTracker.Command");
            try
            {
                var method = type.GetMethod(selectedCommand);
                method.Invoke(new Command(),new object[]{param});
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }

            return true;
        }
    }
}
