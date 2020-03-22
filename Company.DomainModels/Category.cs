using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DomainModels
{
    public class Category
    {
        [Key]
        public long CategoryID { get; set; }

        [StringLength(450)]
        [Index(IsUnique = true)]
        public string CategoryName { get; set; }
    }
}
