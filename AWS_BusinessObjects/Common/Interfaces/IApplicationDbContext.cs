using AWS_BusinessObjects.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<T> Get<T>() where T : BaseAuditableEntity;
        DbSet<T> GetUser<T>() where T : IdentityUser;
        void SaveChanges();
    }
}
