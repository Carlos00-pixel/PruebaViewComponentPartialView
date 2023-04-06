using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaViewComponentPartialView.Models
{
    [Table("INFO_PRODUCTOS")]
    public class Producto
    {
        [Key]
        [Column("IdInfoArte")]
        public int IdInfoArte { get; set; }

        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Precio")]
        public int Precio { get; set; }

        [Column("Imagen")]
        public string Imagen { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("IdArtista")]
        public int IdArtista { get; set; }

        [Column("Nick")]
        public string Nick { get; set; }
    }
}
