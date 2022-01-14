
namespace project.Dto
{
    public class ProductDto
    {
        public class Create : GeneralCreateDto
        {
            public MvProduct mvProduct { get; set; }
        }

        public class MvProduct
        {
            public string ProductSKU { get; set; }
            public string ProductDescription { get; set; }
            public double ProductSellingPrice { get; set; }
            public double ProductPurchasePrice { get; set; }
        }
    }
}
