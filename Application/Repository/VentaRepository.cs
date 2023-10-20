using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class VentaRepository : GenericRepository<Venta>, IVenta
    {
        private readonly TiendaRopaDBcontext _context;

        public VentaRepository(TiendaRopaDBcontext context):base(context)
        {
            _context = context;
        }
    }
}