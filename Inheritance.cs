using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class WorkItem
    {
        private static int currentID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan JobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Default Title";
            Description = "Default description";
            JobLength = new TimeSpan();
        }

        public WorkItem(string title, string desc, TimeSpan joblen)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.JobLength = joblen;
        }

        static WorkItem() => currentID = 0;

        protected int GetNextID() => ++currentID;
        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.JobLength = joblen;
        }

    }


    class Inheritance
    {
    }
}
