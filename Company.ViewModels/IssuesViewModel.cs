using System;
using System.Collections.Generic;
using Company.DomainModels;
using System.Linq;
using System.Web;

namespace ReportingAssistantExercise.Areas.Admin.ViewModels
{
    public class IssuesViewModel
    {
        public IssuesViewModel()
        {
            AdminsNamesTaskToday = new Dictionary<string, string>();

            AdminsNamesTaskYesterday = new Dictionary<string, string>();

            AdminsNamesFinalCommentsToday = new Dictionary<string, string>();

            AdminsNamesFinalCommentsYesterday = new Dictionary<string, string>();
        }
        public string UserID { get; set; }
        public List<Company.DomainModels.Task> TasksToday { get; set; }

        public List<Company.DomainModels.Task> TasksYesterday { get; set; }


        public Dictionary<string, string> AdminsNamesTaskToday { get; set; }

        public Dictionary<string, string> AdminsNamesTaskYesterday { get; set; }

        public Dictionary<string, string> AdminsNamesFinalCommentsToday { get; set; }

        public Dictionary<string, string> AdminsNamesFinalCommentsYesterday { get; set; }

        public List<Company.DomainModels.TaskDone> TasksDoneToday { get; set; }

        public List<Company.DomainModels.TaskDone> TasksDoneYesterday { get; set; }

        public List<Company.DomainModels.FinalComment> FinalCommentsToday { get; set; }
        public List<Company.DomainModels.FinalComment> FinalCommentsYesterday { get; set; }
    }
}