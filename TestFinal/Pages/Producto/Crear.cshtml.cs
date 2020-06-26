using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestFinal.Data;
using TestFinal.Models;

namespace TestFinal.Pages.Producto
{
    public class CrearModel : PageModel
    {
        private readonly IProductoCRUD _productoCRUD;

        public CrearModel(IProductoCRUD productoCRUD)
        {
            _productoCRUD = productoCRUD;
        }

        [BindProperty]
        public enProducto nuevoProducto { get; set; }

       
        public IActionResult OnPost()
        {
            nuevoProducto = _productoCRUD.CrearProducto(nuevoProducto);
            return RedirectToPage("./Listar");
        }
    }
}
