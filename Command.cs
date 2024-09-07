using System;
using System.Collections.Generic;
using System.Text;
using TaskTracker.Entities;

namespace TaskTracker
{
    class Command 
    {
        public void Add(string description)
        {
            Task task = new Task();
            task.Description = description;
            task.CreatedAt = DateTime.Now;
            task.UpdatedAt = DateTime.Now;
        }
        public int GetNewId()
        {
            
        }

        public void Update()
        {

        }  
        public void Delete()
        {

        }
        public void List()
        {

        }
    }
}
