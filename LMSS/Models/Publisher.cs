using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



#nullable disable



namespace LMSS.Models
{
    public partial class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }



    }
}