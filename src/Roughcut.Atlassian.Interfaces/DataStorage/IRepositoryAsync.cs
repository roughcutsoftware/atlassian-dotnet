﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Roughcut.Atlassian.Interfaces.DataStorage
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<List<T>> GetListAsync(string actionUrl);

        Task<T> GetByIdAsync(object id);
        IEnumerable<T> QueryAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity, bool isNewItem);
        Task DeleteAsync(object id);
        Task UpdateAsync(T entity);
    }
}