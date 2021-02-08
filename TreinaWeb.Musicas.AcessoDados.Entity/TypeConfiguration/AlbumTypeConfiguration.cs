using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Comum.Entity;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.Entity.TypeConfiguration
{
    public class AlbumTypeConfiguration : TreinaWebEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");

            Property(P => P.Nome)
                .IsRequired()
                .HasColumnName("ALB_NOME")
                .HasMaxLength(100);

            Property(P => P.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");

            Property(P => P.Observacoes)
                .IsOptional()
                .HasColumnName("ALB_OBSERVACOES")
                .HasMaxLength(500);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
