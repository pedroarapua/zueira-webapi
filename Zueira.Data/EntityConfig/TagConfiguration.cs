using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Zueira.Domain.Entities;

namespace Zueira.Data.EntityConfig
{
    public class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.id);

            this.Property(t => t.descricao)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("tags");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.id_assunto).HasColumnName("id_assunto");
            this.Property(t => t.descricao).HasColumnName("descricao");

            // Relationships
            this.HasRequired(t => t.assunto)
                .WithMany(t => t.tags)
                .HasForeignKey(d => d.id_assunto);

        }
    }
}
