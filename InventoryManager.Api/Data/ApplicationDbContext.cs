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
        public  DbSet<Item> Items {get;set;}
        public  DbSet<Position> Positions {get;set;}
        public DbSet<Department> Departments {get;set;}
        public DbSet<Employee> Employees {get;set;}
    }
}