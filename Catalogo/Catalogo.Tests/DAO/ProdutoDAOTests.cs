using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catalogo.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.DataAccess.DAO.Tests
{
    [TestClass()]
    public class ProdutoDAOTests
    {
        [TestMethod()]
        public void atualizarTest()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto nProd = dao.retornar(1);
            nProd.nomeProd = "Camisola";

            bool ret = dao.atualizar(nProd);
            Assert.AreEqual(true, ret);
        }

        [TestMethod()]
        public void retornarAllTest()
        {
            ProdutoDAO dao = new ProdutoDAO();
            List<Produto> lsProd = dao.retornarAll();

            Assert.AreEqual(3, lsProd.Count);
        }
    }
}