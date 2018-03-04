using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Catalogo.DataAccess;

namespace Catalogo.Servico.Servicos
{
    /// <summary>
    /// Descrição resumida de ProdutoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class ProdutoService : System.Web.Services.WebService
    {
        IDataAccess<Produto> dao = DAOFactory.getProdutoDAO();
        [WebMethod]
        public Produto retornarById(int idProd)
        {
            Produto prod = dao.retornar(idProd);
            if(prod == null)
            {
                prod = new Produto { idProd = -1, idCat = -1, nomeProd = "Id inexistente ou invalido", descProd = "", imagem = "" };
            }
            return prod;
        }

        [WebMethod]
        public List<Produto> retornarAll()
        {
            return dao.retornarAll();
        }

        [WebMethod]
        public bool incluir(Produto prod)
        {
            return dao.incluir(prod);
        }

        [WebMethod]
        public bool atualizar(Produto prod)
        {
            return dao.atualizar(prod);
        }

        [WebMethod]
        public bool deletar(Produto prod)
        {
            return dao.deletar(prod);
        }

        [WebMethod]
        public bool deletarById(int idProd)
        {
            return dao.deletarById(idProd);
        }
    }
}
