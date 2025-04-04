using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("categorias")]

    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Column("categoria")]
        [Required]
        public string Nombre { get; set; }
    }
}
