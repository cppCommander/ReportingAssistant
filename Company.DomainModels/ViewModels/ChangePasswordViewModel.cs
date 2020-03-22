using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DomainModels.ViewModels
{
    public class ChangePasswordViewModel
    {

     
        public string UserID { get; set; }

        [Required(ErrorMessage = "Username can't be blank")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Username can't be blank")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Username can't be blank")]
        [Compare("NewPassword", ErrorMessage = "Password and confirm password do not match")]
        public string ConfirmNewPassword { get; set; }
    }
}
