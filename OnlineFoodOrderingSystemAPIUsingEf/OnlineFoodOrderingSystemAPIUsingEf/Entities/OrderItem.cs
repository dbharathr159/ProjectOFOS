using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;

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
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Orders orders { get; set; }

        //Foreign Key
        [ForeignKey("MenuId")]
        public int MenuId { get; set; }
        public Menu menu { get; set; }
        
  
        [Column(TypeName = "Decimal")]
        public int Amount { get; set; }

        public int NoOfServing { get; set; }

        [Column(TypeName = "Decimal")]
        public int Total { get; set; }
        

        
       
    }
}
