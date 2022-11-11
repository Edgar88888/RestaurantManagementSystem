using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class OrderStorageItemDto
    {
        public int StorageItemId { get; set; }
        public int OrderId { get; set; }
        public int Serving { get; set; }
        public StorageItemDto StorageItem { get; set; }
    }
}
