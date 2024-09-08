using System;
using System.Collections.Generic;
using System.Text;
using TaskTracker.Entities;
using System.IO;
using System.Text.Json;

namespace TaskTracker
{
    class Command 
    {
        public bool Add(string description)
        {
            TaskItem task = new TaskItem()
            {
                Id = GetLastId() + 1,
                Description=description,
                CreatedAt=DateTime.Now,
                UpdatedAt=DateTime.Now,
                Status=(int)TaskItem.StatusEnum.todo
            };

            return TaskItem.AddTask(task);
        }
        public int GetLastId()
        {
            int lastId = 0;
            var tasks = TaskItem.Tasks;
            if(tasks.Count>0)
                lastId = tasks[tasks.Count - 1].Id;
            return lastId;
        }

        public void UpdateTaskDescription(string newDescription)
        {

        }  
        public void DeleteTask(int id)
        {

        }
        public List<TaskItem> List()
        {
            return TaskItem.Tasks;
        }
    }
}
