using System.ComponentModel.DataAnnotations;

namespace EcommerceDAL.Models
{
    // Category Model
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
       
        public int? ParentId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
