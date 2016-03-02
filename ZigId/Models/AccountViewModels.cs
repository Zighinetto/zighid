using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZigId.Models
{
        

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Codice")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Memorizzare questo browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Memorizza account")]
        public bool RememberMe { get; set; }
    }

    
}
