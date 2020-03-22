using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryContracts;

namespace Company.RespositoryLayer
{
    public class ProjectRepository : IProjectRepository
    {
        CompanyDbContext db;

        public ProjectRepository()
        {
            this.db = new CompanyDbContext();
        }
        public void AddProject(Project p)
        {
            db.Projects.Add(p);
            db.SaveChanges();
        }

        public void DeleteProject(long id)
        {
            Project project = db.Projects.Where(temp => temp.ProjectID == id).SingleOrDefault();
            db.Projects.Remove(project);
            db.SaveChanges();
        }

        public void EditProject(Project p)
        {
            Project project = db.Projects.Where(temp => temp.ProjectID == p.ProjectID).FirstOrDefault();
            if(project != null)
            {
                project.Photo = p.Photo;
                project.Category = p.Category;
                project.CategoryID = p.CategoryID;
                project.AvailabilityStatus = p.AvailabilityStatus;
                project.ProjectName = p.ProjectName;
                project.Photo = p.Photo;
                project.DateOfStart = p.DateOfStart;
                db.SaveChanges();
            }
        }

        public Project GetProjectById(long projectId)
        {
            Project project = db.Projects.Where(temp => temp.ProjectID == projectId).SingleOrDefault();
            return project;
        }

        public List<Project> GetProjects()
        {
            List<Project> projects = db.Projects.OrderBy(o => o.ProjectName).ToList();
            return projects;
        }

        public List<Project> GetProjectsByProjectNameContains(string contains)
        {
            List<Project> projects = db.Projects.Where(temp => temp.ProjectName.Contains(contains)).ToList();
            return projects;
        }
    }
}
