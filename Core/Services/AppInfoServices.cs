using Core.Interfaces;
using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AppInfoServices(MainDbContext context) : IAppInfo
    {
        private readonly MainDbContext _context = context;

        public async Task<AppInfo> GetAppInfo()
        {
            return await _context.AppInfo.OrderByDescending(a => a.CreatedDate).FirstOrDefaultAsync();
        }
    }
}
