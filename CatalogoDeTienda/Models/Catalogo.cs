using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDeTienda.Models
{
    public enum EstadoType
    {
        Pendiente = 0,
        Comprado = 1,
        Agotado = 2,
    }
    public class Catalogo
    {
        [Key]
        public int RopaId { get; set; }
        [Required(ErrorMessage = "EL campo es requerido")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Deben haber entre 1 y 100 caracteres")]
        [Display(Name = "Tipo de prenda")]
        public string Prenda { get; set; }
        [Required(ErrorMessage = "EL campo es requerido")]
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Required(ErrorMessage = "EL campo es requerido")]
        [Display(Name = "Talla")]
        public string Talla { get; set; }
        [Required(ErrorMessage = "EL campo es requerido")]
        [Display(Name = "Costo")]
        public int Costo { get; set; }
        public EstadoType Estado { get; set; }

        [Url]
        [Required(ErrorMessage = "EL campo es requerido")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Deben haber entre 10 y 1000 caracteres")]
        [Display(Name = "Imagen de la Prenda")]
        public string Imagen { get; set; }
    }
}
