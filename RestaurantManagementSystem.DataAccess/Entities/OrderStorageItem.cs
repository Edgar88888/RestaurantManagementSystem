using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Entities
{
    public class OrderStorageItem
    {
        [ForeignKey("StorageItems")]
        public int StorageItemId { get; set; }
        public virtual StorageItem StorageItem { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Serving { get; set; }
    }
}
