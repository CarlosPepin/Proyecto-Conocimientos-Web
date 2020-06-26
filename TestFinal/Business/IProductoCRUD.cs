using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Models;

namespace TestFinal.Data
{
    public interface IProductoCRUD
    {
        IEnumerable<enProducto> ListarProductosNombre(string nombre);
        enProducto CrearProducto(enProducto nuevoProducto);
        //Para desplegar data en Detalle
        enProducto OptenerId(int id);
        enProducto Editar(enProducto ProductoEditado);
        enProducto Eliminar(int id);
        //int Commint();
        IEnumerable<enCategoria> ListarCategoriaNombre(string nombre);
        
    }
}
