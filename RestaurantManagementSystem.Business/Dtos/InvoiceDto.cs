using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class InvoiceDto
    {
        public DateTime PaymentDate { get; set; }
        public List<StorageItemForInvoiceDto> Items { get; set; }
        public int TotalSum { get; set; }
    }
}
