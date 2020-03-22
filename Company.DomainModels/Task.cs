using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;

namespace Company.DomainModels
{
    public class Task
    {
        [Key]
        public long TaskID { get; set; }
        public string Screen { get; set; }
        public string Description { get; set; }
        public string AdminUserID { get; set; }
        public string UserID { get; set; }

        //TODO ADMIN AND USER FOREIGN KEYS
        
        public DateTime DateOfTask { get; set; }

        public string Attachment { get; set; }

        public long ProjectID { get; set; }

        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }

    }
}
