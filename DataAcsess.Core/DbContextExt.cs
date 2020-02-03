using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace Infrastructure.DataAcsess.Core
{
    public static class DbContextExt
    {

        public static TEntity ExecStoredProcedure<TEntity>(this DbContext dbContext,FormattableString procedureNameWithParameters) where TEntity : class
        {
            return dbContext.Set<TEntity>().FromSqlInterpolated(procedureNameWithParameters).FirstOrDefault();
        }



        public static IEnumerable<TEntity> ExecStoredProcedureList<TEntity>(this DbContext dbContext, FormattableString procedureNameWithParameters) where TEntity : class
        {
            return dbContext.Set<TEntity>().FromSqlInterpolated(procedureNameWithParameters);
        }

  
    }
}
