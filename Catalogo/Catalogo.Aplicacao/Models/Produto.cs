using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Catalogo.Aplicacao.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "O ID deve ser preenchido.")]
        public int idProd { get; set; }

        [Required(ErrorMessage = "O ID da categoria deve ser preenchido.")]
        public int idCat { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "O Nome deve ter netre 5 e 50 caracteres.")]
        [Required(ErrorMessage = "O Nome do Produto deve ser preenchido")]
        public string nomeProd { get; set; }

        [StringLength(200, MinimumLength = 5, ErrorMessage = "A descricao deve ter netre 5 e 200 caracteres.")]
        [Required(ErrorMessage = "A Descricao deve ser preenchida.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Um caminho para a imagem deve ser preenchida")]
        public string imagemPath { get; set; }  

        public IEnumerable<Produto> TodosProdutos()
        {
            var retorno = new Collection<Produto>()
            {
                new Produto{idProd = 1, idCat = 1, nomeProd = "Camisa POLO - 1", descricao="Camisa de Polo 01", imagemPath="/Content/images/CATEGORIAS/BLUSAS MASCULINAS/1.jpg"}, //BLUSAS MASCULINAS
                new Produto{idProd = 2, idCat = 1, nomeProd = "Camisa POLO - 2", descricao="Camisa de Polo 02", imagemPath="/Content/images/CATEGORIAS/BLUSAS MASCULINAS/2.jpg"},
                new Produto{idProd = 3, idCat = 2, nomeProd = "Mochila - 1",      descricao="Mochila 01",       imagemPath="/Content/images/CATEGORIAS/BOLSAS E MOCHILAS/1.jpg"}, //BOLSAS E MOCHILAS
                new Produto{idProd = 4, idCat = 2, nomeProd = "Mochila - 2",      descricao="Mochila 02",       imagemPath="/Content/images/CATEGORIAS/BOLSAS E MOCHILAS/2.jpg"},
                new Produto{idProd = 5, idCat = 3, nomeProd = "Calçado - 1",      descricao="Calçado 01",       imagemPath="/Content/images/CATEGORIAS/CALÇADOS MASCULINOS/1.jpg"}, //CALÇADOS MASCULINOS
                new Produto{idProd = 6, idCat = 4, nomeProd = "Celular - 1",      descricao="Celular 01",       imagemPath="/Content/images/CATEGORIAS/CELULARES/1.jpg"}, //CELULARES
                new Produto{idProd = 7, idCat = 4, nomeProd = "Celular - 2",      descricao="Celular 02",       imagemPath="/Content/images/CATEGORIAS/CELULARES/2.jpg"},
                new Produto{idProd = 8, idCat = 5, nomeProd = "Relogio - 1",      descricao="Relogio 01",       imagemPath="/Content/images/CATEGORIAS/RELOGIOS/1.jpg"}
            };

            return retorno;
        }
    }
}
