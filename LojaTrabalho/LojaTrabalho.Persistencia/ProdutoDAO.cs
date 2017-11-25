using LojaTrabalho.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaTrabalho.Persistencia
{
    public class ProdutoDAO
    {
        EntidadesContext contexto = new EntidadesContext();

        public void Salva(Produto produto)
        {
            contexto.Add(produto);
            contexto.SaveChanges();
            Console.WriteLine("Salvo com sucesso !");
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.Include(p => p.categoria).FirstOrDefault(p => p.Id == id);
        }


        public void Remove(Produto produto)
        {
            contexto.Remove(produto);
            contexto.SaveChanges();
        }

        public IList<Produto> BuscaPorNomePrecoProduto(string nome, decimal preco, string categoria)
        {
            var busca = from p in contexto.Produtos select p;

            if (!string.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if (preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                busca = busca.Where(p => p.categoria.Nome == categoria);
            }


            return busca.ToList();

        }
    }
