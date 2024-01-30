using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Sistemas
    {
        [Key]

        public int TicketId { get; set; }

        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        
        public int SistemaId { get; set; }

        public int PrioridadId { get; set; }

        public string? SolicitadoPor { get; set; }

        public string Asunto { get; set; } = "";
        
        public string? Descripcion { get; set; }

    }
}
