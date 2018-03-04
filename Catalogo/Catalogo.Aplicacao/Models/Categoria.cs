using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalogo.App.Models
{
    public class Categoria
    {        
        public int idCat { get; set; }

        [Required]
        public string nomeCat { get; set; }
    }
}