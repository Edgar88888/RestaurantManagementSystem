using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Dtos
{
    public class PaymentDto : BaseDto
    {
        public int Id { get; set; }
        public double Tips { get; set; }
        public int OrderId { get; set; }
        public OrderDto Order { get; set; }
    }

    public class PaymentAddDto
    {
        public int Id { get; set; }
        public double Tips { get; set; }
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
