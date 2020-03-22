using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DomainModels
{
    public class TaskDone
    {
        [Key]
        public long TaskDoneID { get; set; }
        public string Screen { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public DateTime DateOfTaskDone { get; set; }

        public string Attachment { get; set; }

        public long ProjectID { get; set; }



        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }
    }
}
