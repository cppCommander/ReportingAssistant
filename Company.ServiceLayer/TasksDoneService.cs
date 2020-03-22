using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
using Company.RepositoryContracts;
using Company.RespositoryLayer;
using Company.ServiceContracts;

namespace Company.ServiceLayer
{
    public class TasksDoneService : ITasksDoneService
    {
        ITasksDoneRepository tasksDoneRepository;

        public TasksDoneService(ITasksDoneRepository r)
        {
            tasksDoneRepository = r;
        }

        public void AddTaskDone(TaskDone t)
        {
            tasksDoneRepository.AddTaskDone(t);
        }

        public void EditTaskDone(TaskDone t)
        {
            tasksDoneRepository.EditTaskDone(t);
        }

        public TaskDone GetTaskByTaskDoneById(long taskId)
        {
            TaskDone taskDone = tasksDoneRepository.GetTaskByTaskDoneById(taskId);
            return taskDone;
        }

        public List<TaskDone> GetTasksDone()
        {
            List<TaskDone> tasksDone = tasksDoneRepository.GetTasksDone();
            return tasksDone;
        }
    }
}
