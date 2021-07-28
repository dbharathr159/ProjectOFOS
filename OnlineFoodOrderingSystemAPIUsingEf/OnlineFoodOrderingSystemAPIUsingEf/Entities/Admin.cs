using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating Admin Table Using CodeFirst Approach
    [Table("Admin")]
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int UserId { get; set; }

        [StringLength(20)]
        [Column(TypeName ="Varchar")]
        public string Password { get; set; }

        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string FirstName { get; set; }

        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string LastName { get; set; }

        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public string Email { get; set; }

        [Column(TypeName ="Bigint")]
        public decimal Mobile { get; set; }
    }
}
