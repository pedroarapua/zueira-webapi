﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zueira.Domain.Entities;

namespace Zueira.Domain.Interfaces
{
    public interface IAssuntoRepository : IRepositoryBase<Assunto>
    {
        IEnumerable<Assunto> GetByDescription(String descricao);
    }
}
