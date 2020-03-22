using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.RepositoryContracts
{
    public interface ITasksRepository
    {
        void AddTask(Company.DomainModels.Task t);
        void EditTask(Company.DomainModels.Task t);
        List<Company.DomainModels.Task> GetTasks();
        List<Company.DomainModels.Task> GetTaskByUserIdAndAdminIdAndDate(string userId, string adminId, DateTime dateTime);

        Company.DomainModels.Task GetTaskByTaskId(long taskId);

        void DeleteTask(long id);
    }
}
