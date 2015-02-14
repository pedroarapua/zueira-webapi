using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Zueira.Data.EntityConfig;
using Zueira.Domain.Entities;

namespace Zueira.Data.Context
{
    public partial class ZuandoTimesContext : DbContext
    {
        static ZuandoTimesContext()
        {
            Database.SetInitializer<ZuandoTimesContext>(null);
        }

        public ZuandoTimesContext   ()
            : base("Name=ZuandoTimesContext")
        {
        }

        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Default para quando não especificado tipo de dado no banco
            modelBuilder.Properties<String>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AssuntoConfiguration());
            modelBuilder.Configurations.Add(new ConteudoConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
        }

        public object PluralizingTableNameConvention { get; set; }
    }
}
