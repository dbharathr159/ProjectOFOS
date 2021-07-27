using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating OrderItem Table Using Code First Approach
    [Table("OrderItem")]
    
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int OrderItemId { get; set; }
        //Foreign Key
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        //public Order Order { get; set; }
        //Foreign Key
        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        //public Menu Menu { get; set; }
        [Column(TypeName = "Decimal")]
        public int Amount { get; set; }
        public int NoOfServing { get; set; }
        [Column(TypeName = "Decimal")]
        public int Total { get; set; }
        

        
       
    }
}
