using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    [Table("articulo")]
    public class Articulo
    {
        [Key]
        public int idarticulo {get;set;}
        public int idcategoria {get;set;}
        public string codigo {get;set;}
        public string nombre {get;set;}
        public decimal precio_venta {get;set;}
        public int stock {get;set;}
        public string descripcion {get;set;}
        public bool condicion {get;set;}
        public Categoria Categoria { get; set; }
    }
}