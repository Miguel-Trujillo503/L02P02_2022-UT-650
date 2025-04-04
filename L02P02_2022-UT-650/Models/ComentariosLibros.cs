using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("comentarios_libros")]
    public class ComentariosLibros
    {
        [Key]
        public int Id { get; set; }

        [Column("id_libro")]
        public int IdLibro { get; set; }

        [Column("comentarios")]
        public string Comentario { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("created_at")]
        public DateTime FechaCreacion { get; set; }

        // Relación
        public Libro Libro { get; set; }
    }
}
