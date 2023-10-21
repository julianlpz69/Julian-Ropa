using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProveedor : IGenericRepository<Proveedor>
    {
        Task<IEnumerable<Proveedor>> ProveedoresNaturales();
    }
}