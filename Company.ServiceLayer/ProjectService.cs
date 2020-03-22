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
    public class ProjectService : IProjectService
    {
        IProjectRepository projectRepository;

        public ProjectService(IProjectRepository r)
        {
            this.projectRepository = r;
        }

        public void AddProject(Project p)
        {
            projectRepository.AddProject(p);
        }

        public void EditProject(Project p)
        {
            projectRepository.EditProject(p);
        }

        public List<Project> GetProjects()
        {
            List<Project> projects = projectRepository.GetProjects();
            return projects;
        }

        public Project GetProjectById(long projectId)
        {
            Project project = projectRepository.GetProjectById(projectId);
            return project;
        }

        public List<Project> GetProjectsByProjectNameContains(string contains)
        {
            List<Project> projects = projectRepository.GetProjectsByProjectNameContains(contains);
            return projects;
        }

        public void DeleteProject(long id)
        {
            projectRepository.DeleteProject(id);
        }
    }
}
