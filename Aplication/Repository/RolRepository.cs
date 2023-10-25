using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data.Configuration;

namespace Aplication.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRolRespository
    {
        private readonly ShopOnlineContext _context;

        public RolRepository(ShopOnlineContext context) : base(context)
        {
            _context = context;
        }
    }
}