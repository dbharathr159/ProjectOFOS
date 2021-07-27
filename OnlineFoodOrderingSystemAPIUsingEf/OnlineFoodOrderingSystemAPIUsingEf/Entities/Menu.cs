using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating Menu Table Using Code First Approach
    [Table("Menu")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int MenuId { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string MenuName { get; set; }
        public int Quantity { get; set; }
        
        public int Price { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string FoodCategory { get; set; }

    }
}
