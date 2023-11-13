using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class TaskScheduler<TTask, TPriority>
    {
        private Queue<TTask> taskQueue = new Queue<TTask>();
        private Func<TTask, TPriority> prioritySelector;

        public TaskScheduler(Func<TTask, TPriority> prioritySelector)
        {
            this.prioritySelector = prioritySelector;
        }

        public void AddTask(TTask task)
        {
            taskQueue.Enqueue(task);
        }

        public void ExecuteNext(Action<TTask> taskExecution)
        {
            if (taskQueue.Count > 0)
            {
                TTask nextTask = taskQueue.Dequeue();
                taskExecution(nextTask);
            }
            else
            {
                Console.WriteLine("Немає завдань у черзі.");
            }
        }
    }
}
