using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Reservation
    {
        [Key]
        public int ResId { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime BookDate { get ; set; }
    }
}
