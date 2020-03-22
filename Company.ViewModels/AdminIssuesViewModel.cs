using System;
using System.Collections.Generic;
using Company.DataLayer;
using Company.DomainModels;
using System.Linq;
using System.Web;

namespace ReportingAssistantExercise.Areas.Admin.ViewModels
{
    public class AdminIssuesViewModel
    {

        public AdminIssuesViewModel()
        {
        }




        //public List<ReportingAssistantExercise.Identity.ApplicationUser> Users { get; set; }

        public IEnumerable<Company.DomainModels.ViewModels.UsersInRoleViewModel> Users { get; set; }

        public IEnumerable<Company.DomainModels.ViewModels.UsersInRoleViewModel> Admins { get; set; }
        public List<Company.DomainModels.Task> Tasks { get; set; }

        public List<Company.DomainModels.TaskDone> TasksDone { get; set; }

        public List<Company.DomainModels.FinalComment> FinalComments { get; set; }
    }
}