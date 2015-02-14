using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Zueira.Domain.Entities;

namespace Zueira.Data.EntityConfig
{
    public class ConteudoConfiguration : EntityTypeConfiguration<Conteudo>
    {
        public ConteudoConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("conteudos");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.id_tag).HasColumnName("id_tag");
            this.Property(t => t.texto).HasColumnName("texto");

            // Relationships
            this.HasRequired(t => t.tag)
                .WithMany(t => t.conteudos)
                .HasForeignKey(d => d.id_tag);

        }
    }
}
