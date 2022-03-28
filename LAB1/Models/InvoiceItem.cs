using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LAB1.Models{
    public class InvoiceItemModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        [RegularExpression("^([a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+)$")]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        [ForeignKey("Invoice")]
        public int IvoiceID { get; set; }
        public InvoiceModel Ivoice { get; set; }
        
    }
}