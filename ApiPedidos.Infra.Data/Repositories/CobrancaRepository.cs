﻿using ApiPedidos.Domain.Entities;
using ApiPedidos.Domain.Interfaces.Repositories;
using ApiPedidos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Infra.Data.Repositories
{
    public class CobrancaRepository : BaseRepository<Cobranca, Guid>, ICobrancaRepository
    {
        private readonly DataContext? _dataContext;

        public CobrancaRepository(DataContext? dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
