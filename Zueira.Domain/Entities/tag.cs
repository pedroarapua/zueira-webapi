using System;
using System.Collections.Generic;

namespace Zueira.Domain.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            this.conteudos = new List<Conteudo>();
        }

        public int id { get; set; }
        public int id_assunto { get; set; }
        public string descricao { get; set; }
        public virtual Assunto assunto { get; set; }
        public virtual ICollection<Conteudo> conteudos { get; set; }
    }
}
