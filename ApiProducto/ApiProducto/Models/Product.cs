namespace ApiProducto.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum MarketType
    { 
        Niños=0,
        Jovenes=1,
        Hombres=2,
        Mujeres=3, 
        Mayores=4
    }

    public enum CategoryType
    { 
        Ropa=0,
        Electronicos=1,
        Cosmeticos=2,
        Muebleria=3,
        Juegos=4,
        Deportes=5,
        Bebidas=6,
        Alimentos=7
    }

    public class Product
    {
        [Key]
        public int PoductId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="El nombre debe contener entre 5 - 80 caracteres",MinimumLength =5)]
        public string Name { get; set; }
        [Range(0,10000,ErrorMessage ="El precio oscila entre 0 - 10000")]
        public double Price{ get; set; }
        public MarketType Market{ get; set; }
        public CategoryType Category { get; set; }

    }
}