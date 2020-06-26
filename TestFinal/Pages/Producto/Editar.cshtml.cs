using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestFinal.Data;
using TestFinal.Models;

namespace TestFinal.Pages.Producto
{
    public class EditarModel : PageModel
    {
        

        private readonly IProductoCRUD productoData;
        [BindProperty]
        public enProducto Producto { get; set; }

        public EditarModel(IProductoCRUD productoData)
        {
            this.productoData = productoData;
        }

        public IActionResult OnGet(int productoId)
        {
            Producto = productoData.OptenerId(productoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            Producto = productoData.Editar(Producto);
            return RedirectToPage("./Listar");
        }
    }
}