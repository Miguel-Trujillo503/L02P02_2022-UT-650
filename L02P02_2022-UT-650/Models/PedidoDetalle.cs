using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_UT_650.Models
{
    [Table("pedido_detalle")]
    public class PedidoDetalle
    {
        [Key]
        public int Id { get; set; }

        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [Column("id_libro")]
        public int IdLibro { get; set; }

        [Column("created_at")]
        public DateTime FechaCreacion { get; set; }

        // Relaciones
        public PedidoEncabezado PedidoEncabezado { get; set; }
        public Libro Libro { get; set; }
    }
}
