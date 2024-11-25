
using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class ProductWarehouse
    {


        private ProductWarehouse()
        {

        }

        private ProductWarehouse(Product product, Warehouse warehouse, int quantity)
        {
            ProductId = product.Id;
            WarehouseId = warehouse.Id;
            Quantity = quantity;
        }

        public static Result<ProductWarehouse> Create(Product product, Warehouse warehouse, int quantity)
        {
            return Result.Success(new ProductWarehouse(product, warehouse, quantity));
        }


        public int ProductId { get; private set; }
        public virtual Product? Product { get; }
        public int WarehouseId { get; }
        public virtual Warehouse? Warehouse { get; }
        public int Quantity { get; private set; }
        [NotMapped]
        public string ProductTitle => Product!.Title;
        public void UpdateInfo(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
