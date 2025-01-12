﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Shared.Utilities.Extensions
{
    public static class IncludeMultiple
    {
        public static IQueryable<TEntity> MultipleInclude<TEntity>
           (this IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes)
           where TEntity : class, IEntity, new()
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
