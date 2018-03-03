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
    public class CategoriaDAOTests
    {
        [TestMethod()]
        public void incluirTest()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria
            {
                idCat = 10,
                nomeCat = "Eletrodomesticos"
            };

            bool ret = dao.incluir(cat);

            Assert.AreEqual(true, ret);
        }

        [TestMethod()]
        public void retornarTest()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.retornar(2);

            Assert.AreEqual(2, cat.idCat);
        }

        [TestMethod()]
        public void retornarAllTest()
        {
            CategoriaDAO dao = new CategoriaDAO();
            List<Categoria> lsCat = dao.retornarAll();

            Assert.AreEqual("Sapatos", lsCat[1].nomeCat);
        }

        [TestMethod()]
        public void atualizarTest()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = new Categoria
            {
                idCat = 3,
                nomeCat = "Eletronicos"
            };
            bool ret = dao.atualizar(cat);

            Assert.AreEqual(true, ret);
        }

        [TestMethod()]
        public void deletarTest()
        {
            CategoriaDAO dao = new CategoriaDAO();
            Categoria cat = dao.retornar(2);

            bool ret = dao.deletar(cat);

            Assert.AreEqual(true, ret);
        }

        [TestMethod()]
        public void deletarByIdTest()
        {
            CategoriaDAO dao = new CategoriaDAO();            
            bool ret = dao.deletarById(10);

            Assert.AreEqual(true, ret);
        }
    }
}