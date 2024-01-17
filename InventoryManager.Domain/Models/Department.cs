using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; } = string.Empty;
    }
}