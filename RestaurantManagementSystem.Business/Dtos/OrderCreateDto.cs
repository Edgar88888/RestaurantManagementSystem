using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class OrderCreateDto
    {
        public int CustomerId { get; set; }
        public int WaiterId { get; set; }
        public List<OrderStorageItemCreateDto> OrderStorageItems { get; set; }

    }
}
