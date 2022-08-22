using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



#nullable disable



namespace LMSS.Models
{
    public partial class LendRequest
    {
        [Key]
        public int LendId { get; set; }
        public string LendStatus { get; set; }
        public DateTime LendDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Account User { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }



        public double? FineAmount { get; set; }



    }

}