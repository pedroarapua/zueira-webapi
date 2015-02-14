using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zueira.Data.Context;
using Zueira.Domain.Entities;

namespace Zueira.Data
{
    class Class1
    {
        public static void Main(String[] args)
        {
            using (ZuandoTimesContext context = new ZuandoTimesContext()) {
                context.Assuntos.Add(new Assunto() { descricao = "Times de Futebols" });
                context.SaveChanges();
                context.Assuntos.ToList();
            }
        }
    }
}
