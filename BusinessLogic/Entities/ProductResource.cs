using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class ProductResource
    {


        private ProductResource()
        {

        }

        private ProductResource(Product product, Resource resource, int quantity)
        {
            ProductId = product.Id;
            Product = product;
            ResourceId = resource.Id;
            Resource = resource;
            Quantity = quantity;
        }

        public static Result<ProductResource> Create(Product product, Resource resource, int quantity)
        {
            return Result.Success(new ProductResource(product, resource, quantity));
        }


        public int ProductId { get; }
        public virtual Product? Product { get; }
        public int ResourceId { get; private set; }
        public virtual Resource? Resource { get; }
        public int Quantity { get; private set; }

        [NotMapped]
        public string ResourceTitle => Resource!.Title;

        public void UpdateInfo(int resourceId, int quantity)
        {
            ResourceId = resourceId;
            Quantity = quantity;
        }
    }
}
