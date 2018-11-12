using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRIpeFarm
{
    public class Task
    {
        private string title;
        private string category;
        private string description;
        private DateTime startDate;
        private DateTime dueDate;
        private string status;

        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public string Status { get => status; set => status = value; }
    }
}