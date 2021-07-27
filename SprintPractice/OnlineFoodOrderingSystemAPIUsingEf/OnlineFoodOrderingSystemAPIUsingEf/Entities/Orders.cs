using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating Order Table Using Code First Approach
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int OrderId { get; set; }
        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }
       
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string OrderStatus { get; set; }

        //Foreign Key
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
  
        
    }
}
