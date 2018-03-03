using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Catalogo.DataAccess.DAO
{
    public class CategoriaDAO : IDataAccess<Categoria>
    {
        private CatalogoEntities context = new CatalogoEntities();
        public CategoriaDAO() { }

        public bool incluir(Categoria model)
        {
            try
            {
                context.Categoria.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool atualizar(Categoria model)
        {
            try
            {
                Categoria cat = context.Categoria.Find(model.idCat);
                cat.nomeCat = model.nomeCat;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletar(Categoria model)
        {
            try
            {
                context.Categoria.Remove(model);
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
            Categoria cat = retornar(idModel);
            if (cat != null)
                return deletar(cat);

            return false;
        }

        public Categoria retornar(int idModel)
        {
            try
            {
                Categoria cat = (from rCat in context.Categoria where rCat.idCat == idModel select rCat).SingleOrDefault();
                return cat;                
            }
            catch (Exception)
            { 
                //Debug.Write(ex.Message);
                return null;
            }
        }

        public List<Categoria> retornarAll()
        {
            try
            {
                List<Categoria> cat = (from rCat in context.Categoria select rCat).ToList<Categoria>();
                return cat;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}