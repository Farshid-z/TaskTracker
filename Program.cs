using System;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Task Tracker");
                TaskTracker.GetInstance().GetUserCommand();
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
