using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("pedido_encabezado")]
    public class PedidoEncabezado
    {
        [Key]
        public int Id { get; set; }

        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [Column("cantidad_libros")]
        public int CantidadLibros { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        // Relación
        public Cliente Cliente { get; set; }
    }
}
