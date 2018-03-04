using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalogo.App.Models
{
    public class Categoria
    {        
        [Required(ErrorMessage ="O ID deve ser preenchido.")]
        public int idCat { get; set; }

        [Required(ErrorMessage ="O Nome da Categoria deve ser preenchido.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="O Nome da Categoria deve ter de 3 a 20 caracteres.")]
        public string nomeCat { get; set; }
    }
}
