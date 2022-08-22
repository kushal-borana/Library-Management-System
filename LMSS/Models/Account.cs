using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



#nullable disable



namespace LMSS.Models
{
    public partial class Account
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }



    }
}