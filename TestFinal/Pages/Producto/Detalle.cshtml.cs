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
    public class DetalleModel : PageModel
    {

        public enProducto Producto { get; set; }

        private readonly IProductoCRUD _productoData;

        public DetalleModel(IProductoCRUD productoData)
        {
            _productoData = productoData;
        }

        public void OnGet(int productoId)
        {
            Producto = _productoData.OptenerId(productoId);
        }


    }
}