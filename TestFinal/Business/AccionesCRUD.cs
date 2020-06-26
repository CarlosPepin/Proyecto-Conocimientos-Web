using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Data;
using TestFinal.Models;

namespace TestFinal
{
    public class AccionesCRUD : IProductoCRUD
    {
        protected readonly AppHBRContext _dbContext;

        public AccionesCRUD(AppHBRContext dbContext)
        {
            _dbContext = dbContext;
        }

        public enProducto CrearProducto(enProducto nuevoProducto)
        {
            _dbContext.Productos.Add(nuevoProducto);
            _dbContext.SaveChanges();
            return nuevoProducto;
        }

        public enProducto Editar(enProducto ProductoEditado)
        {
            enProducto producto = _dbContext.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.idProducto == ProductoEditado.idProducto);
            
            producto.NombreProducto = ProductoEditado.NombreProducto;
            producto.Description = ProductoEditado.Description;
            producto.idCategoria = ProductoEditado.idCategoria;
            _dbContext.SaveChangesAsync();

            return producto;
        }

        public enProducto Eliminar(int id)
        {
            enProducto producto = _dbContext.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.idProducto == id);
            _dbContext.Productos.Remove(producto);
            _dbContext.SaveChangesAsync();

            return producto;
        }

        public IEnumerable<enCategoria> ListarCategoriaNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<enProducto> ListarProductosNombre(string nombre)
        {
            return _dbContext.Productos.Include(p => p.Categoria).Where(p => string.IsNullOrEmpty(nombre) || p.NombreProducto.ToLower().Contains(nombre.ToLower())).OrderBy(p => p.NombreProducto).ToList();
        }

        public enProducto OptenerId(int id)
        {
            return _dbContext.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.idProducto == id);
        }
    }
}



//public class ProductRepository : IProductRepository
//{
//    protected readonly AspnetRunContext _dbContext;
//    public ProductRepository(AspnetRunContext dbContext)
//    {
//        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
//    }
//    public async Task<IEnumerable<Product>> GetProductListAsync()
//    {
//        return await _dbContext.Products.ToListAsync();
//    }
//    public async Task<Product> GetProductByIdAsync(int id)
//    {
//        return await _dbContext.Products
//        .Include(p => p.Category)
//        .FirstOrDefaultAsync(p => p.Id == id);
//    }
//    public async Task<IEnumerable<Product>> GetProductByNameAsync(string name)
//    {
//        return await _dbContext.Products.Include(p => p.Category).Where(p => string.IsNullOrEmpty(name) || p.Name.ToLower().Contains(name.ToLower())).OrderBy(p => p.Name).ToListAsync();
//    }
//    public async Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
//    {
//        return await _dbContext.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
//    }
//    public async Task<Product> AddAsync(Product product)
//    {
//        _dbContext.Products.Add(product);
//        await _dbContext.SaveChangesAsync();
//        return product;
//    }
//    public async Task UpdateAsync(Product product)
//    {
//        _dbContext.Entry(product).State = EntityState.Modified;
//        await _dbContext.SaveChangesAsync();
//    }
//    public async Task DeleteAsync(Product product)
//    {
//        _dbContext.Products.Remove(product);
//        await _dbContext.SaveChangesAsync();
//    }
//    public async Task<IEnumerable<Category>> GetCategories()
//    {
//        return await _dbContext.Categories.ToListAsync();
//    }
//}