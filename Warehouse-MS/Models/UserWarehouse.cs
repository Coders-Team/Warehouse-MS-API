﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse_MS.Models
{
    public class UserWarehouse
    {

        public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        public Warehouse Warehouse { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }

    }
}