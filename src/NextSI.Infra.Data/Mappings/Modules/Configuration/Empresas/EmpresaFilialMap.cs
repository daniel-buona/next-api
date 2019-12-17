using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Empresas
{
    public class EmpresaFilialMap : IEntityTypeConfiguration<EmpresaFilial>
    {
        public void Configure(EntityTypeBuilder<EmpresaFilial> builder)
        {

                builder.ToTable("empresa_filial");

                builder.HasIndex(e => e.DeleteUsuarioId)
                    .HasName("fk_empresa_usuario3_idx");

                builder.HasIndex(e => e.InsertUsuarioId)
                    .HasName("fk_empresa_usuario1_idx");

                builder.HasIndex(e => e.LogoCabecalhoId)
                    .HasName("fk_empresa_documento_logo_cabecalho_id_idx");

                builder.HasIndex(e => e.LogoRodapeId)
                    .HasName("fk_empresa_documento_logo_rodape_id_idx");

                builder.HasIndex(e => e.UpdateUsuarioId)
                    .HasName("fk_empresa_usuario2_idx");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.ArquivoLicenca)
                    .HasColumnName("arquivo_licenca")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                builder.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.CodMunicipio)
                    .HasColumnName("cod_municipio")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                builder.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                builder.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

                builder.Property(e => e.DeleteUsuarioId)
                    .HasColumnName("delete_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.DominioInteracao)
                    .HasColumnName("dominio_interacao")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                builder.Property(e => e.EmailPrincipal)
                    .HasColumnName("email_principal")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                builder.Property(e => e.Excluido)
                    .IsRequired()
                    .HasColumnName("excluido")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("N");

                builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

                builder.Property(e => e.InsertUsuarioId)
                    .HasColumnName("insert_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.LogoCabecalhoId)
                    .HasColumnName("logo_cabecalho_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.LogoId)
                    .HasColumnName("logo_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.LogoMarcacaoId)
                    .HasColumnName("logo_marcacao_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.LogoRodapeId)
                    .HasColumnName("logo_rodape_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Padrao)
                    .IsRequired()
                    .HasColumnName("padrao")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("N");

                builder.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.Telefone1)
                    .HasColumnName("telefone1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Telefone2)
                    .HasColumnName("telefone2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Telefone3)
                    .HasColumnName("telefone3")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Telefone4)
                    .HasColumnName("telefone4")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.TextoRodape)
                    .HasColumnName("texto_rodape")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.UltimoPing).HasColumnName("ultimo_ping");

                builder.Property(e => e.UltimoSincronismo).HasColumnName("ultimo_sincronismo");

                builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

                builder.Property(e => e.UpdateUsuarioId)
                    .HasColumnName("update_usuario_id")
                    .HasColumnType("int(11)");

        }
    }
}
