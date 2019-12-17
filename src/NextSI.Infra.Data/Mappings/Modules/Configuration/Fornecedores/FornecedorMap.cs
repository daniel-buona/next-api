using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NextSI.Domain.Models.Modules.Configuration;

namespace NextSI.Infra.Data.Mappings.Modules.Configuration.Fornecedores
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
                builder.ToTable("fornecedor");

                builder.HasIndex(e => e.DeleteUsuarioId)
                    .HasName("fk_fornecedor_usuario3_idx");

                builder.HasIndex(e => e.InsertUsuarioId)
                    .HasName("fk_fornecedor_usuario1_idx");

                builder.HasIndex(e => e.LogoId)
                    .HasName("fk_fornecedor_documento1_idx");

                builder.HasIndex(e => e.UpdateUsuarioId)
                    .HasName("fk_fornecedor_usuario2_idx");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.Bloqueado)
                    .IsRequired()
                    .HasColumnName("bloqueado")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("N");

                builder.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Classificacao)
                    .IsRequired()
                    .HasColumnName("classificacao")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("F");

                builder.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                builder.Property(e => e.CodMunicipio)
                    .HasColumnName("cod_municipio")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                builder.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("char(4)");

                builder.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.DataFundacao)
                    .HasColumnName("data_fundacao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.DeleteHora).HasColumnName("delete_hora");

                builder.Property(e => e.DeleteUsuarioId)
                    .HasColumnName("delete_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.DominioInteracao)
                    .HasColumnName("dominio_interacao")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                builder.Property(e => e.EmailAgenda)
                    .HasColumnName("email_agenda")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                builder.Property(e => e.EmailPrincipal)
                    .HasColumnName("email_principal")
                    .HasMaxLength(150)
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

                builder.Property(e => e.IdEstrangeiro)
                    .HasColumnName("id_estrangeiro")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Inscricao)
                    .HasColumnName("inscricao")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                builder.Property(e => e.InscricaoMunicipal)
                    .HasColumnName("inscricao_municipal")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.InsertHora).HasColumnName("insert_hora");

                builder.Property(e => e.InsertUsuarioId)
                    .HasColumnName("insert_usuario_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.LogoId)
                    .HasColumnName("logo_id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                builder.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Observacoes)
                    .HasColumnName("observacoes")
                    .HasColumnType("longtext");

                builder.Property(e => e.Pessoa)
                    .IsRequired()
                    .HasColumnName("pessoa")
                    .HasColumnType("char(1)");

                builder.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                builder.Property(e => e.SincronismoHora).HasColumnName("sincronismo_hora");

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

                builder.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("char(1)");

                builder.Property(e => e.TipoOrgao)
                    .HasColumnName("tipo_orgao")
                    .HasColumnType("char(1)");

                builder.Property(e => e.Unidade)
                    .HasColumnName("unidade")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                builder.Property(e => e.UpdateHora).HasColumnName("update_hora");

                builder.Property(e => e.UpdateUsuarioId)
                    .HasColumnName("update_usuario_id")
                    .HasColumnType("int(11)");
        }
    }
}
