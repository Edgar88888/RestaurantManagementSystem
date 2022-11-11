﻿
namespace RestaurantManagementSystem.Business.Dtos
{
    public class StorageItemDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool EnableInMenu { get; set; }
    }
}
