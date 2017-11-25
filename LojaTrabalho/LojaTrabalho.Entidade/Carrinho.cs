using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaTrabalho.Entidade
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }
        public string Endereco { get; set; }
        public long Id { get; set; }
                
    }
}
