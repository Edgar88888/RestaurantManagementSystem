using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.DataAccess.Entities
{
    public class Order : BaseEntity
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }

        [ForeignKey("Waiter")]
        public int WaiterId { get; set; }
        public virtual ApplicationUser Waiter { get; set; }

        public virtual ICollection<OrderStorageItem> OrderStorageItems { get; set; }
    }
}
