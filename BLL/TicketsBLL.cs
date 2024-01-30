using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tickets.DAL;
using Tickets.Models;

namespace Tickets.BLL
{
    public class TicketsBLL
    {
        private readonly TicketsContext _context;

        public TicketsBLL(TicketsContext context)
        {
            _context = context;
        }

        public bool Existe(int TicketId)
        {
            return _context.Sistemas.Any(S => S.TicketId == TicketId);
        }

        public bool Insertar(Sistemas Ticket)
        {
            _context.Sistemas.Add(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(Sistemas Ticket)
        {
            _context.Update(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Guardar(Sistemas Ticket) 
        {
            if (!Existe(Ticket.TicketId))
                return Insertar(Ticket);
            else
                return Modificar(Ticket);
        }

        public bool Eliminar(Sistemas Ticket)
        {
            _context.Sistemas.Remove(Ticket);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public Sistemas? Buscar(int SistemaId)
        {
            return _context.Sistemas
                .AsNoTracking()
                .FirstOrDefault(s => s.SistemaId == SistemaId);
        }

        public List<Sistemas> GetList(Expression<Func<Sistemas, bool>> Criterio)
        {
            return _context.Sistemas
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
    }
}
