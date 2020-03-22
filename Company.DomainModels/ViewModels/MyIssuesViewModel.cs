using System;
using System.Collections.Generic;
using Company.DomainModels;
using System.Linq;
using System.Web;

namespace Company.DomainModels.ViewModels
{
    public class MyIssuesViewModel
    {
        
        public string UserID { get; set; }

        public string UserName { get; set; }

        public int DayRange { get; set; }

        public IEnumerable<Company.DomainModels.ViewModels.UsersInRoleViewModel> Admins { get; set; }

        public IEnumerable<Company.DomainModels.Task> Tasks { get; set; }

        public IEnumerable<Company.DomainModels.TaskDone> TasksDone { get; set; }

        public IEnumerable<Company.DomainModels.FinalComment> FinalComments { get; set; }
    }
}
