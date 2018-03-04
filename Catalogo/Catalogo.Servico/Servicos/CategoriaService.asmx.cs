using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Catalogo.DataAccess;

namespace Catalogo.Servico.Servicos
{
    /// <summary>
    /// Descrição resumida de CategoriaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoriaService : System.Web.Services.WebService
    {
        IDataAccess<Categoria> dao = DAOFactory.getCategoriaDAO();

        [WebMethod]
        public Categoria retornarById(int idCat)
        {
            Categoria cat = dao.retornar(idCat);
            if(cat == null)
            {
                cat = new Categoria { idCat = -1, nomeCat = "Id inexistente ou Falha na Conexao" };
            }

            return cat;
        }

        [WebMethod]
        public List<Categoria> retornarAll()
        {
            return dao.retornarAll();
        }

        [WebMethod]
        public bool incluir(Categoria cat)
        {
            return dao.incluir(cat);
        }

        [WebMethod]
        public bool atualizar(Categoria cat)
        {
            return dao.atualizar(cat);
        }

        [WebMethod]
        public bool deletar(Categoria cat)
        {
            return dao.deletar(cat);
        }

        [WebMethod]
        public bool deletarById(int idCat)
        {
            return dao.deletarById(idCat);
        }
    }
}
