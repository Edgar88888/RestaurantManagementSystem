using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class StorageItemForInvoiceDto
    {
        public string Name { get; set; }
        public int Serving { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
    }
}
