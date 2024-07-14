﻿using System;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public void SetDueDateUtc(DateTime dueDate)
        {
            DueDate = DateTime.SpecifyKind(dueDate, DateTimeKind.Utc);
        }
    }
}
