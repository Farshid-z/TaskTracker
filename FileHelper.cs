using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TaskTracker
{
    class FileHelper
    {
        static string CurrentPath = Directory.GetCurrentDirectory();
        public static void AddFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return;
            string file = CurrentPath + fileName ;
            if(File.Exists(fileName))
            try
            {
                using (FileStream fileStream  = File.Create(fileName))
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
