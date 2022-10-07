using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Task
    {
        //declaration of properties
        public string TaskTitle { get; set; }
        public int TaskNumber { get; set; }
        public DateTime StartDate { get; set; }
        public double TaskWeight { get; set; }
        public DateTime EndDate { get; set; }


        public Task(string title, int num, double weight, DateTime sdate, DateTime edate)
        {
            TaskTitle = title;
            TaskNumber = num;
            StartDate = sdate;
            EndDate = edate;
            TaskWeight = weight;
        }

        //override to show how to display the variables
        public override string ToString()
        {
            return string.Format($"Task Title: {TaskTitle}\nTask No: {TaskNumber}\nTask Weight is: " +
                $"{TaskWeight}\nTask Start Date: {StartDate.ToShortDateString()}\nTask End Date: {EndDate.ToShortDateString()}");
        }
    }
}
