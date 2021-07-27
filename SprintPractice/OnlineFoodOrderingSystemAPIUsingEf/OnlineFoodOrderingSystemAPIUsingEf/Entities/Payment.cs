using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating Payment Table Using Code First Approach
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int PaymentId { get; set; }

        //Foreign Key
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]

        [Column(TypeName = "Decimal")]
        public int TotalAmount { get; set; }

        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string PaidBy { get; set; }
              
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string PaymentStatus { get; set; }
    }
}
