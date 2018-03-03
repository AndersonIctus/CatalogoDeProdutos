using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogo.DataAccess
{
    public class DAOFactory
    {
       private DAOFactory()
        { }

        public static IDataAccess<Categoria> getCategoriaDAO()
        {
            return new DAO.CategoriaDAO();
        }

        public static IDataAccess<Produto> getProdutoDAO()
        {
            return null; // new DAO.CategoriaDAO();
        }
    }
}