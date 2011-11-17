using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using HtmlAgilityPack;
using HttpUtils;

namespace Parafia.Model.Quest
{
    public class QuestContainer
    {
        [XmlArray("quests"), XmlArrayItem("quest", typeof(Quest))]
        private List<Quest> listOfQuests;

        public QuestContainer() { }

        public QuestContainer(DefaultHttpClient httpClient, String responseContent)
        {
            listOfQuests = new List<Quest>();

            HtmlNodeCollection questsNodeCollection = HtmlUtils.GetNodesCollectionByXPathExpression(responseContent, "//div[@id='quest_sections_inner']/a");

            foreach (HtmlNode questNode in questsNodeCollection)
            {
                Quest quest = new Quest(HtmlUtils.GetAttributeValueFromHtmlNode(questNode, "title"), HtmlUtils.GetAttributeValueFromHtmlNode(questNode, "href"));

                String questContent = httpClient.SendHttpGetAndReturnResponseContent(quest.Link);

                HtmlNodeCollection tasksNodeCollection = HtmlUtils.GetNodesCollectionByXPathExpression(questContent, "//div[@class='quest mt20']");

                foreach (HtmlNode taskNode in tasksNodeCollection)
                {
                    quest.AddTask(new Task(taskNode.InnerHtml));
                }

                listOfQuests.Add(quest);
            }
        }

        public void updateTaskProgress(String content, Task task)
        {
            HtmlNodeCollection tasksNodeCollection = HtmlUtils.GetNodesCollectionByXPathExpression(content, "//div[@class='quest mt20']");

            foreach (HtmlNode taskNode in tasksNodeCollection)
            {
                Task temp = new Task(taskNode.InnerHtml);
                if (task.Name.Equals(temp.Name))
                {
                    task.Progress = temp.Progress;
                    break;
                }
            }
        }

        public void checkQuest(Quest quest)
        {
            foreach (Quest questFromList in listOfQuests)
            {
                if (questFromList.Link.Equals(quest.Link))
                {
                    questFromList.IsChecked = true;
                    break;
                }
            }
        }

        public Queue<Quest> GetSelectedQuests()
        {
            List<Quest> selectedQuests = new List<Quest>();
            foreach (Quest quest in listOfQuests)
                if (quest.IsChecked)
                    selectedQuests.Add(quest);

            selectedQuests.Sort();

            Queue<Quest> questsQueue = new Queue<Quest>();

            foreach (Quest quest in selectedQuests)
                questsQueue.Enqueue(quest);

            return questsQueue;
        }

        public List<Quest> GetAllQuests
        {
            get { return this.listOfQuests; }
            set { this.listOfQuests = value; }
        }

        public List<String> GetAllQuestsName()
        {
            List<String> listOfQuestsName = new List<String>();

            foreach (Quest quest in listOfQuests)
            {
                listOfQuestsName.Add(quest.Name);
            }

            return listOfQuestsName;
        }

        public List<Task> GetAllTasks()
        {
            List<Task> listOfTasks = new List<Task>();

            foreach (Quest quest in listOfQuests)
            {
                listOfTasks.AddRange(quest.ListOfTasks);
            }

            return listOfTasks;
        }

        public List<Task> GetAllTasksMatching(int energy, int health, int cash)
        {
            List<Task> listOfTasks = GetAllTasks();

            List<Task> tasksMatch = new List<Task>();

            foreach (Task task in listOfTasks)
            {
                bool flag = true;
                if (energy != null)
                    if (task.Cost.energy != null && task.Cost.energy > energy)
                        flag = false;

                if (health != null)
                    if (task.Cost.health != null && task.Cost.health > health)
                        flag = false;

                if (cash != null)
                    if (task.Cost.cash != null && task.Cost.cash > cash)
                        flag = false;

                if (flag) tasksMatch.Add(task);
            }

            return tasksMatch;
        }

        public Quest GetQuestByName(String name)
        {
            foreach (Quest quest in listOfQuests)
            {
                if (quest.Name.Contains(name))
                {
                    return quest;
                }
            }
            return null;
        }

        public ArrayList GetQuestsByNameList(String[] names)
        {
            ArrayList matchedQuests = new ArrayList();

            if (names != null)
            {
                foreach (Quest quest in listOfQuests)
                {
                    foreach (String name in names)
                    {
                        if (quest.Name.Equals(name))
                        {
                            matchedQuests.Add(quest);
                        }
                    }
                }
            }

            return matchedQuests;
        }

        public void updatePriority(int priority, String name)
        {
            foreach (Quest quest in listOfQuests)
            {
                if (quest.Name.Contains(name))
                {
                    quest.Priority = priority;
                    break;
                }
            }
        }

        public void select(String name)
        {
            foreach (Quest quest in listOfQuests)
            {
                if (quest.Name.Contains(name))
                {
                    quest.IsChecked = true;
                    break;
                }
            }
        }

        public void unSelect(String name)
        {
            foreach (Quest quest in listOfQuests)
            {
                if (quest.Name.Contains(name))
                {
                    quest.IsChecked = false;
                    break;
                }
            }
        }

        public List<Quest> compare(QuestContainer questContainer)
        {
            List<Quest> newQuests = new List<Quest>();

            if (questContainer.listOfQuests.Count != this.listOfQuests.Count)
            {
                List<Quest> temp; List<Quest> temp1;
                if (questContainer.listOfQuests.Count > this.listOfQuests.Count)
                {
                    temp = new List<Quest>(questContainer.listOfQuests);
                    temp1 = new List<Quest>(this.listOfQuests);
                }
                else
                {
                    temp = new List<Quest>(this.listOfQuests);
                    temp1 = new List<Quest>(questContainer.listOfQuests);
                }

                foreach (Quest quest in temp)
                {
                    bool flag = false;
                    foreach (Quest quest1 in temp1)
                        if (quest.Link.Equals(quest1.Link))
                            flag = true;

                    if (!flag)
                        newQuests.Add(quest);
                }
                return newQuests;
            }
            return null; 
        }
    }
}
