using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catalogo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.DataAccess.Tests
{
    [TestClass()]
    public class DAOFactoryTests
    {
        [TestMethod()]
        public void getCategoriaDAOTest()
        {
            IDataAccess<Categoria> dao = DAOFactory.getCategoriaDAO();
            dao.incluir(new Categoria { idCat = 3, nomeCat = "Brinquedos" });

            Assert.AreNotEqual(null, dao);
        }

        [TestMethod()]
        public void getProdutoDAOTest()
        {
            IDataAccess<Produto> dao = DAOFactory.getProdutoDAO();
            dao.incluir(new Produto { idProd = 10, idCat = 3, nomeProd = "Note book ALIEN", descProd = "note book para GAMERS", imagem = "\\resources\\note_book_alien.jpeg" });

            Assert.AreNotEqual(null, dao);
        }
    }
}