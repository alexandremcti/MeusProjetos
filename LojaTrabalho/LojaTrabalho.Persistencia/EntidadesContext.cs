using LojaTrabalho.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaTrabalho.Persistencia
{
    public class EntidadesContext : DbContext
    {
        public EntidadesContext() 
            : base("LojaTrabalhoConectionString")
        {

        }

        public DbSet<Carrinho> Carrinhos { get; set; }

        public DbSet<Produto> Produtos { get; set; }
       
    }
}
