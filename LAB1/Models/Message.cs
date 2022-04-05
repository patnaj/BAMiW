using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAB1.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public DateTime Date { get; set; }
    }
}

