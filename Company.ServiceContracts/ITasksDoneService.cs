using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.ServiceContracts
{
    public interface ITasksDoneService
    {
        void AddTaskDone(TaskDone t);
        void EditTaskDone(TaskDone t);
        List<TaskDone> GetTasksDone();

        TaskDone GetTaskByTaskDoneById(long taskId);
    }
}
