using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogo.DataAccess.DAO
{
    public class ProdutoDAO : IDataAccess<Produto>
    {
        private CatalogoEntities context = new CatalogoEntities();
        public ProdutoDAO() { }
        public bool atualizar(Produto model)
        {
            try
            {
                Produto prod = context.Produto.Find(model.idProd);
                prod.idCat = model.idCat;
                prod.nomeProd = model.nomeProd;
                prod.descProd = model.descProd;
                prod.imagem = model.imagem;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletar(Produto model)
        {
            try
            {
                context.Produto.Remove(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletarById(int idModel)
        {
            Produto prod = retornar(idModel);
            if (prod != null)
                return deletar(prod);

            return false;
        }

        public bool incluir(Produto model)
        {
            try
            {
                context.Produto.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Produto retornar(int idModel)
        {
            try
            {
                Produto prod = (from rProd in context.Produto where rProd.idProd == idModel select rProd).SingleOrDefault();
                return prod;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Produto> retornarAll()
        {
            try
            {
                List<Produto> lsProd = (from rProd in context.Produto select rProd).ToList<Produto>();
                return lsProd;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}