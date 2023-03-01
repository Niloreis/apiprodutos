using Apiprodutos.Data.Contexts;
using Apiprodutos.Data.Entities;
using Apiprodutos.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apiprodutos.Data.Repositories
{
    public class ProdutosRepository : IRepository<Produto>
    {
        public void Add(Produto entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.produtos.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Update(Produto entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public void Delete(Produto entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.produtos.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public List<Produto> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.produtos
                    .Include(p=>p.Categoria)
                    .OrderBy(p => p.Nome)
                    .ToList();
            }
        }

        public Produto GetById(Guid? id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.produtos
                    .Where(p =>p.IdProduto == id)
                    .FirstOrDefault();

            }
        }
    }
}
