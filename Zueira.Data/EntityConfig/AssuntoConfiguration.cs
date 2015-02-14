using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Zueira.Domain.Entities;

namespace Zueira.Data.EntityConfig
{
    public class AssuntoConfiguration : EntityTypeConfiguration<Assunto>
    {
        public AssuntoConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            this.Property(t => t.descricao)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("assuntos");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.descricao).HasColumnName("descricao");
        }
    }
}
