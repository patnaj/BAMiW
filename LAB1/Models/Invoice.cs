using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LAB1.Models{
    public class InvoiceModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Address { get; set; }
        public IList<InvoiceModel> Invoices {get;set;}

        [ForeignKey("User")]
        public int UserID { get; set; }
        public UserModel User { get; set; }
    
    }
}