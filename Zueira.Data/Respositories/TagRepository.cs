using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zueira.Data.Services;
using Zueira.Domain.Entities;
using Zueira.Domain.Interfaces;

namespace Zueira.Data.Respositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
    }
}
