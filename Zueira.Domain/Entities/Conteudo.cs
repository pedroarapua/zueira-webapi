using System;
using System.Collections.Generic;

namespace Zueira.Domain.Entities
{
    public partial class Conteudo
    {
        public long id { get; set; }
        public int id_tag { get; set; }
        public string texto { get; set; }
        public virtual Tag tag { get; set; }
    }
}
