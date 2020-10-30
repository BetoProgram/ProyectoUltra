using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Table("categoria")]
    public class Categoria
    {
        [Key]
        public int idcategoria {get;set;}
        public string nombre {get;set;}
        public string descripcion {get;set;}
        public bool condicion {get;set;}
        public IEnumerable<Articulo> Articulos { get; set; }
    }
}