using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManager.Domain.Models;
using InventoryManager.Domain.Models.ApplicationUser;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {
        }
        DbSet<Item> Items {get;set;}
        DbSet<Position> Positions {get;set;}
        DbSet<Department> Departments {get;set;}
        DbSet<Employee> Employees {get;set;}
    }
}