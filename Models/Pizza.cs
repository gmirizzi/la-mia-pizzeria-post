using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizzas")]
    public class Pizza
    {
        public Pizza()
        {
    
        }

        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public string ImgPath { get; set; }
        [Required]
        public string Price { get; set; }
    }
}
