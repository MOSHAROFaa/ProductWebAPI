using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductWebAPI.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")] 
        public int Id { get; set; }


        [Column("product_name")]
        public string ProductName { get; set; }


        [Column("product_desc")]
        public string ProductDesc { get; set; }


        [Column("product_code")]
        public string ProductCode { get; set; }


        [Column("product_price")]
        public decimal ProductPrice { get; set; }
    }
}
