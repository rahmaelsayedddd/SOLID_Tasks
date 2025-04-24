using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    // 1.
    // a. Based on specifications, we need to create an interface and a TeamLead class to implement it.
    // b. Later another role like Manager, who assigns tasks to TeamLead and will not work on the tasks, is introduced into the system,
    // Apply needed refactoring to for better design and mention the current design smells
    public interface ICreate
    {  
        void CreateSubTask();  
    }
    public interface IWorkOn
    {
        void WorkOnTask();
    }
    public interface IAssign
    {
        void AssignTask(ITask _task, Role role);
    }

    public class Role
    {
        public string Name { get; set; }
    }
    public class Developer: Role, IWorkOn
    {
        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }

    public interface ITask
    {
        void AssignTo(Role role);
    }
    public class Task: ITask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public void AssignTo(Role role)
        {
            Console.WriteLine($"Task '{Title}' assigned to {role.Name}");
        }
    }
    public class TeamLead : Role, IAssign, ICreate, IWorkOn
    {
        ITask Task;
        public void AssignTask(ITask _task, Role role)
        {
            // create a Task
            Task = _task;

            //Code to assign a Task. 
            Task.AssignTo(role);
        }

        public void CreateSubTask()
        {
            //Code to create a sub Task  
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned Task.  
        }
    }

    public class Manager : Role, IAssign
    {
        ITask Task;
        public void AssignTask(ITask _task, Role role)
        {
            // create a Task
            Task = _task;

            //Code to assign a Task. 
            Task.AssignTo(role);
        }
    }
    internal class Task01
    {
    }
}
