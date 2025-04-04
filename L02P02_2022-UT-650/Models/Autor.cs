using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L02P02_2022_UT_650.Models
{
    [Table("autores")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Column("autor")]
        [Required]
        public string Nombre { get; set; }
    }
} 
