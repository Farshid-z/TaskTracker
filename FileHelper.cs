using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TaskTracker
{
    class FileHelper
    {
        static string file = Directory.GetCurrentDirectory()+"TaskLists";
        public static void AddFile()
        {
            try
            {
                using (FileStream fileStream  = File.Create(file))
                {
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool IsFileExists()
        {
            if (File.Exists(file))
                return true;
            return false;
        }
        public static string ReadFile()
        {
            if (!IsFileExists())
                AddFile();
            using (StreamReader reader = new StreamReader(file))
            {
                string data = reader.ReadToEnd();
                return data;
            }
        }
        public static void AddTaskToFile(string task)
        {
            if (!IsFileExists())
                AddFile();
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(task);
            }
        }
    }
}
