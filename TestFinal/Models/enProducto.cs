using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestFinal.Models
{
    public class enProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        [Required, StringLength(80)]
        public string NombreProducto { get; set; }
        [Required, StringLength(255)]
        public string Description { get; set; }
        public int idCategoria { get; set; }
        public enCategoria Categoria { get; set; }
    }
}
