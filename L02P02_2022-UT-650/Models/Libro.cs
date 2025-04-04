using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("libros")]
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        public string Nombre { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("url_imagen")]
        public string UrlImagen { get; set; }

        [Column("id_autor")]
        public int IdAutor { get; set; }

        [Column("id_categoria")]
        public int IdCategoria { get; set; }

        [Column("precio")]
        public decimal Precio { get; set; }

        [Column("estado")]
        public char Estado { get; set; }

        // Relaciones
        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
