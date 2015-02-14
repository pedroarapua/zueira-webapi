using System;
using System.Collections.Generic;

namespace Zueira.Domain.Entities
{
    public partial class Assunto
    {
        public Assunto()
        {
            this.tags = new List<Tag>();
        }

        public int id { get; set; }
        public string descricao { get; set; }
        public virtual ICollection<Tag> tags { get; set; }
    }
}
