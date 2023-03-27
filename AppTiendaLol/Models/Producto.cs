using System.ComponentModel.DataAnnotations;

namespace AppTiendaLol.Models
{
    public class Producto
    {
        [Key]
        public int id_producto { get; set; }
        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }
        [Required]
        public DateTime fecha_ingreso { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public Double precio { get; set; }

    }
}
