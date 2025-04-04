using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("clientes")]

    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("direccion")]
        public string Direccion { get; set; }

        [Column("created_at")]
        public DateTime FechaCreacion { get; set; }
    }
}
