using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration
{
    public class CalendarioTrabalhoMap : IEntityTypeConfiguration<CalendarioTrabalho>
    {
        public void Configure(EntityTypeBuilder<CalendarioTrabalho> builder)
        {
            builder.ToTable("calendario_trabalho");

            builder.HasIndex(e => e.DeleteUsuarioId)
                .HasName("fk_calendario_trabalho_usuario3_idx");

            builder.HasIndex(e => e.InsertUsuarioId)
                .HasName("fk_calendario_trabalho_usuario1_idx");

            builder.HasIndex(e => e.UpdateUsuarioId)
                .HasName("fk_calendario_trabalho_usuario2_idx");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

            builder.Property(e => e.DeleteUsuarioId)
                .HasColumnName("delete_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.DomManhaFim).HasColumnName("dom_manha_fim");

            builder.Property(e => e.DomManhaInicio).HasColumnName("dom_manha_inicio");

            builder.Property(e => e.DomTardeFim).HasColumnName("dom_tarde_fim");

            builder.Property(e => e.DomTardeInicio).HasColumnName("dom_tarde_inicio");

            builder.Property(e => e.Excluido)
                .IsRequired()
                .HasColumnName("excluido")
                .HasColumnType("char(1)")
                .HasDefaultValueSql("N");

            builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

            builder.Property(e => e.InsertUsuarioId)
                .HasColumnName("insert_usuario_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Nome)
                .HasColumnName("nome")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.QuaManhaFim).HasColumnName("qua_manha_fim");

            builder.Property(e => e.QuaManhaInicio).HasColumnName("qua_manha_inicio");

            builder.Property(e => e.QuaTardeFim).HasColumnName("qua_tarde_fim");

            builder.Property(e => e.QuaTardeInicio).HasColumnName("qua_tarde_inicio");

            builder.Property(e => e.QuiManhaFim).HasColumnName("qui_manha_fim");

            builder.Property(e => e.QuiManhaInicio).HasColumnName("qui_manha_inicio");

            builder.Property(e => e.QuiTardeFim).HasColumnName("qui_tarde_fim");

            builder.Property(e => e.QuiTardeInicio).HasColumnName("qui_tarde_inicio");

            builder.Property(e => e.SabManhaFim).HasColumnName("sab_manha_fim");

            builder.Property(e => e.SabManhaInicio).HasColumnName("sab_manha_inicio");

            builder.Property(e => e.SabTardeFim).HasColumnName("sab_tarde_fim");

            builder.Property(e => e.SabTardeInicio).HasColumnName("sab_tarde_inicio");

            builder.Property(e => e.SegManhaFim).HasColumnName("seg_manha_fim");

            builder.Property(e => e.SegManhaInicio).HasColumnName("seg_manha_inicio");

            builder.Property(e => e.SegTardeFim).HasColumnName("seg_tarde_fim");

            builder.Property(e => e.SegTardeInicio).HasColumnName("seg_tarde_inicio");

            builder.Property(e => e.SexManhaFim).HasColumnName("sex_manha_fim");

            builder.Property(e => e.SexManhaInicio).HasColumnName("sex_manha_inicio");

            builder.Property(e => e.SexTardeFim).HasColumnName("sex_tarde_fim");

            builder.Property(e => e.SexTardeInicio).HasColumnName("sex_tarde_inicio");

            builder.Property(e => e.TerManhaFim).HasColumnName("ter_manha_fim");

            builder.Property(e => e.TerManhaInicio).HasColumnName("ter_manha_inicio");

            builder.Property(e => e.TerTardeFim).HasColumnName("ter_tarde_fim");

            builder.Property(e => e.TerTardeInicio).HasColumnName("ter_tarde_inicio");

            builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

            builder.Property(e => e.UpdateUsuarioId)
                .HasColumnName("update_usuario_id")
                .HasColumnType("int(11)");
        }
    }
}
