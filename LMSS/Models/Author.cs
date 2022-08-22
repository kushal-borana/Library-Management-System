using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



#nullable disable



namespace LMSS.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }



    }
}