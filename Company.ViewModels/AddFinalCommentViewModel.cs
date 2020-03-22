using System;
using System.Collections.Generic;
using Company.DomainModels;
using System.Linq;
using System.Web;
using ReportingAssistantExercise.Identity;

namespace Company.ViewModels
{
    public class AddFinalCommentViewModel
    {
        public string Screen { get; set; }
        public string Description { get; set; }
        public string ProjectID { get; set; }
        public string UserID { get; set; }
        public List<Project> Projects { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}