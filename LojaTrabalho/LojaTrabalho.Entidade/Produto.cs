using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaTrabalho.Entidade
{
    public class Produto
    {
        public long Id { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

    }
}
}
