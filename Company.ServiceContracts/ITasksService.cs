using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
using Task = Company.DomainModels.Task;

namespace Company.ServiceContracts
{
    public interface ITasksService
    {
        void AddTask(Task t);
        void EditTask(Task t);
        List<Task> GetTasks();
        List<Task> GetTaskByUserIdAndAdminIdAndDate(string userId, string adminId, DateTime dateTime);

        Task GetTaskByTaskId(long taskId);

        void DeleteTask(long id);
    }
}
