using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.RepositoryContracts
{
    public interface IProjectRepository
    {
        void AddProject(Project p);

        void EditProject(Project p);

        void DeleteProject(long id);

        List<Project> GetProjects();

        Project GetProjectById(long projectId);

        List<Project> GetProjectsByProjectNameContains(string contains);

    }
}
