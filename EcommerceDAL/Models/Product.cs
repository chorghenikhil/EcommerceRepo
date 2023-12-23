using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceDAL.Models
{
    // Product Model
    public class Product
    {
        [Key]
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
       
        public  List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public bool IsDeleted { get; set; }

    }
}
