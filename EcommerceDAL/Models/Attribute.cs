using System.ComponentModel.DataAnnotations;

namespace EcommerceDAL.Models
{

    public class Attribute
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        //public List<string> Values = new List<string>();
        public string Values { get; set; }
     //   public Product Product{ get; set; } = null!;
        public bool IsDeleted { get; set; }



    }
}
