using Infrastructure.DataAcsess.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex4.Dal
{
    public class SamuraiUnitOfWork : AbstractUnitOfWork<SamuraiUnitOfWork, SamuraiDbContext>
    {
        public SamuraiUnitOfWork(SamuraiDbContext dbContext, ILogger<SamuraiUnitOfWork> logger) : base(dbContext, logger)
        {
        }
    }
}
