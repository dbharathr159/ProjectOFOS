using Microsoft.EntityFrameworkCore;

namespace OnlineFoodOrderingSystemAPIUsingEf.Entities
{
    public class FoodOrderingContext:DbContext
    {
        public FoodOrderingContext()
        {

        }
        public FoodOrderingContext(DbContextOptions<FoodOrderingContext> options) : base(options)
        {

        }
        //Navigation for Admin Entity
        public virtual DbSet<Admin> Admin { get; set; }
        //Navigation for Customer Entity
        public virtual DbSet<Customer> Customers { get; set; }
        //Navigation for Menu Entity
        public virtual DbSet<Menu> Menu { get; set; }
        //Navigation for Orders Entity
        public virtual DbSet<Orders> Orderss { get; set; }
        //Navigation for OrderItems Entity
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        //Navigation for Payments Entity
        public virtual DbSet<Payment> Payments { get; set; }



//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=LAPTOP-2OFB2C2Q;Initial Catalog=MyProjectDB;Integrated Security=True");
//            }
//        }



    }
}
