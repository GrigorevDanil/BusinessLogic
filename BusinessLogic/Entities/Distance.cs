using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class Distance
    {

        private Distance()
        {

        }

        private Distance(Shop shop, Warehouse warehouse, int length)
        {
            ShopId = shop.Id;
            WarehouseId = warehouse.Id;
            Length = length;
        }

        public static Result<Distance> Create(Shop shop, Warehouse warehouse, int length)
        {
            return Result.Success(new Distance(shop, warehouse, length));
        }

        public int ShopId { get; }
        public virtual Shop? Shop { get; }
        public int WarehouseId { get; private set; }
        public virtual Warehouse? Warehouse { get; }
        public int Length { get; private set; }

        [NotMapped]
        public string WarehouseTitle => Warehouse!.Title;

        public void UpdateInfo(int warehouseId, int length)
        {
            WarehouseId = warehouseId;
            Length = length;
        }
    }
}
