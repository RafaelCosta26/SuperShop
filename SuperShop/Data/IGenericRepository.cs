﻿using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id); 
    }
}
