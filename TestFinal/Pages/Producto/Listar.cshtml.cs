using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestFinal.Data;

namespace TestFinal.Pages.Producto
{
    public class ListarModel : PageModel
    {

        private readonly IProductoCRUD _productoCRUD;

        //Constructor
        public ListarModel(IProductoCRUD productoCRUD)
        {
            _productoCRUD = productoCRUD;
        }

        public IEnumerable<Models.enProducto> ListaProductos { get; set; } = new List<Models.enProducto>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        
        public void OnGet()
        {
            ListaProductos = _productoCRUD.ListarProductosNombre(SearchTerm);
        }
    }
}
