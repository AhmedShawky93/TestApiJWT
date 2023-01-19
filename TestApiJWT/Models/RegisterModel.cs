using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class RegisterModel
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(128)]
        public string Email { get; set; }
        [StringLength(256)]
        public string Password { get; set; }

    }
}
