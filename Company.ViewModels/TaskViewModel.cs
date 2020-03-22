using System;
using System.Collections.Generic;
using Company.DataLayer;
using Company.DomainModels;
using System.Linq;
using System.Web;
using ReportingAssistantExercise.Identity;


namespace ReportingAssistantExercise.Areas.Admin.ViewModels
{
    public class TaskViewModel
    {
        public string Screen { get; set; }
        public string Description { get; set; }
        public string TaskID { get; set; }
        public string UserID { get; set; }

        public DateTime DateOfTask { get; set; }
        public List<Project> Projects { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}