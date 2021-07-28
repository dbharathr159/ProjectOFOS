using OnlineFoodOrderingSystemAPIUsingEf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    //Creating Customer Table Using Code First Approach
    [Table("Customer")] 
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Primary Key
        public int CustomerId { get; set; }
        [StringLength(20)]
        [Column(TypeName ="Varchar")]
        public string FirstName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string LastName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string Email { get; set; }
        [Column(TypeName ="Bigint")]
        public decimal Mobile { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string Password { get; set; }
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string DeliveryAddress { get; set; }

        public static implicit operator Customer(List<CustomerViewModel> v)
        {
            throw new NotImplementedException();
        }
    }
}
