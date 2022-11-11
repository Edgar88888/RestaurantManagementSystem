using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Entities
{
    public class MenuHistory 
    {
        public int Id { get; set; }
        public string Data { get;set; }

        [ForeignKey("MenuItem")]
        public int MenueItemId { get; set; }
        public virtual StorageItem MenuItem { get; set; }
    }
}
