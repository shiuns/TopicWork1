using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicWork.Models.ViewModels
{
   
    public class ManagerIndexVM
    {
        public int Uid { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

    }

    public class ManagerVM
    {
        public int Uid { get; set; }

        [Required(ErrorMessage = "帳號必填AAA")]
        public string Account { get; set; }


        [Required(ErrorMessage = "密碼必填EEE")]
        //[EmailAddress(ErrorMessage ="Email格式有誤")]
        public string Password { get; set; }
    }
}
