using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Comum.Entity
{
    public abstract class TreinaWebEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public TreinaWebEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavesPrimaria();
            ConfigurarChavesEstrangeira();
        }

        protected abstract void ConfigurarChavesEstrangeira();

        protected abstract void ConfigurarChavesPrimaria();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarNomeTabela();
    
    }
}
