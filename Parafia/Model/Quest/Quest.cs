using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    public class Quest : IComparable
    {
        private String name;
        private String link;
        private int priority;
        private bool isChecked = false;

        [XmlArray("tasks"), XmlArrayItem("task", typeof(Task))]
        private List<Task> listOfTasks;

        private double progress;

        public Quest() { }

        public Quest(String name, String link)
        {
            this.name = name;
            this.link = link;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Link
        {
            get { return this.link; }
            set { this.link = value; }
        }

        public int Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public double Progress
        {
            get { return this.progress; }
            set { this.progress = value; }
        }

        public List<Task> ListOfTasks
        {
            get { return this.listOfTasks; }
            set { this.listOfTasks = value; }
        }

        public bool IsChecked
        {
            get { return this.isChecked; }
            set { this.isChecked = value; }
        }

        public void AddTask(Task task)
        {
            if (listOfTasks == null)
            {
                listOfTasks = new List<Task>();
            }
            listOfTasks.Add(task);
        }

        public double GetProgress()
        {
            double value = 0;
            foreach (Task task in listOfTasks)
            {
                value += task.Progress;
            }

            progress = value / listOfTasks.Count;

            return progress;
        }

        public int CompareTo(object obj)
        {
            if (obj is Quest) {
                Quest quest = (Quest)obj;
                if (quest.Priority > this.priority)
                    return -1;
                if (quest.Priority < this.priority)
                    return 1;

                return 0;
            }
            throw new Exception();
        }
    }
}
