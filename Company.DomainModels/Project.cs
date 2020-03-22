using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DomainModels
{
    public class Project
    {
        [Key]
        public long ProjectID { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string ProjectName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfStart { get; set; }
        public bool AvailabilityStatus { get; set; }
     
        public string Photo { get; set; }

        
        public long CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}
