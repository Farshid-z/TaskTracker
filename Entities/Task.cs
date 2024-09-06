using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTracker.Entities
{
    [Serializable]
    class Task
    {
        #region Fields
        int id;
        string description;
        int status;
        DateTime createdAt;
        DateTime updatedAt;
        #endregion
        #region Props
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
            set
            {
                createdAt = value;
            }
        }
        public DateTime UpdatedAt
        {
            get
            {
                return updatedAt;
            }
            set
            {
                updatedAt = value;
            }
        }
        #endregion
    }
}
