using System.ComponentModel.DataAnnotations;

namespace Parcial2.Models
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage = "El número de inventario es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número entero positivo.")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(200, ErrorMessage = "El nombre del producto no puede exceder los 200 caracteres.")]
        public string Nombre { get; set; }

        
        [RegularExpression(@"^(Frutas|Verduras|Lácteos)$", ErrorMessage = "El departamento debe ser Frutas, Verduras o Lácteos.")]
        public string Departamento { get; set; }
    }
}
