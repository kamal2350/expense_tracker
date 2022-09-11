using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expense_tracker.Models
{
    
     public class Transaction
    {
        [Key]
        public int TransationId { get; set; }

        public int CategotyId { get; set; }
        public Category Category { get; set; }  
        
        public int Amount { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string? Note  { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;



    }
}
