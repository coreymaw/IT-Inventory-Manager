using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Models
{
    public class Position
    {
        public int id { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}