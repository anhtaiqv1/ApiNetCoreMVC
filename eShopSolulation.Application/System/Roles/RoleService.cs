using eShopSolution.Data.Entities;
using eShopSolution.ViewModel.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles.Select(r => new RoleVm
            {
                Name = r.Name,
                Id = r.Id,
                Description = r.Description
            }).ToListAsync();
            return roles;

        }
    }
}
