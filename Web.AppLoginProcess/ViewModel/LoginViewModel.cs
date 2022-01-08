using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.AppLoginProcess.ViewModel
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı"),Required(ErrorMessage ="Boş Geçilemez !!")]
        public string UserName { get; set; }
        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "Boş Geçilemez !!"), DataType(DataType.Password)]

        public string Password { get; set; }
    }
}