using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalogo.Aplicacao.Models
{
    public class Categoria
    {        
        [Required(ErrorMessage ="O ID deve ser preenchido.")]
        public int idCat { get; set; }

        [Required(ErrorMessage ="O Nome da Categoria deve ser preenchido.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="O Nome da Categoria deve ter de 3 a 20 caracteres.")]
        public string nomeCat { get; set; }

        public IEnumerable<Categoria> TodasCategorias()
        {
            var retorno = new Collection<Categoria>()
            {
                new Categoria{idCat = 1, nomeCat = "BLUSAS MASCULINAS"},
                new Categoria{idCat = 2, nomeCat = "BOLSAS E MOCHILAS"},
                new Categoria{idCat = 3, nomeCat = "CALÇADOS MASCULINOS"},
                new Categoria{idCat = 4, nomeCat = "CELULARES"},
                new Categoria{idCat = 5, nomeCat = "RELOGIOS"}
            };

            return retorno;
        }
    }

    
}
