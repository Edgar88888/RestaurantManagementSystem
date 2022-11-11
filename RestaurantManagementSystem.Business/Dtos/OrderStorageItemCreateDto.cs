using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class OrderStorageItemCreateDto
    {
        public int StorageItemId { get; set; }
        public int Serving { get; set; }
    }
}
