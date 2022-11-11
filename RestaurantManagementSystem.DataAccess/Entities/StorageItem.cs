using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.DataAccess.Entities
{
    public class StorageItem : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool EnableInMenu { get; set; }
        public virtual ICollection<OrderStorageItem> OrderStorageItems { get; set; }

    }
}
