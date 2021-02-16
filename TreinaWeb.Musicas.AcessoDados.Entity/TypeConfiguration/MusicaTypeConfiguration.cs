using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Comum.Entity;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.Entity.TypeConfiguration
{
    public class MusicaTypeConfiguration : TreinaWebEntityAbstractConfig<Musica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnName("MUS_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("MUS_NOME")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.IdAlbum)
                .HasColumnName("ALB_ID")
                .IsRequired();
        }

        protected override void ConfigurarChavesEstrangeira()
        {
            HasRequired(p => p.Album)
                .WithMany(p => p.Musicas)
                .HasForeignKey(fk => fk.IdAlbum);
        }

        protected override void ConfigurarChavesPrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("MUS_MUSICAS");
        }
    }
}
