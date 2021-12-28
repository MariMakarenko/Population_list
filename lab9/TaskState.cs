using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public interface ITaskStatus
    {
        string getStatus();
        void nexTaskStep(Task task);
        void prevTaskStep(Task task);
    }

    public class NewTask : ITaskStatus
    {
        public string getStatus()
        {
            return "новый таск";
        }
        public void nexTaskStep(Task task)
        {
            Console.WriteLine("тикет выполняется");
            task.status = new InProgress();
        }
        public void prevTaskStep(Task task)
        {
            Console.WriteLine("минимальній статус задания");
        }
    }
    public class InProgress : ITaskStatus
    {
        public string getStatus()
        {
            return "выполняется";
        }
        public void nexTaskStep(Task task)
        {
            Console.WriteLine("тикет проверяется");
            task.status = new InReview();
        }
        public void prevTaskStep(Task task)
        {
            Console.WriteLine("новый тикет");
            task.status = new NewTask();
        }
    }

    public class InReview : ITaskStatus
    {
        public string getStatus()
        {
            return "проверяется";
        }
        public void nexTaskStep(Task task)
        {
            Console.WriteLine("тикет подтвержден");
            task.status = new Approve();
        }
        public void prevTaskStep(Task task)
        {
            Console.WriteLine("тикет выполняется");
            task.status = new NewTask();
        }
    }

    public class Approve : ITaskStatus
    {
        public string getStatus()
        {
            return "выполнен и подтвержден";
        }
        public void nexTaskStep(Task task)
        {
            Console.WriteLine("максимальный статус задания");
        }
        public void prevTaskStep(Task task)
        {
            Console.WriteLine("тикет выполняется");
            task.status = new InReview();
        }
    }
}
