
namespace project.Dto
{
    public class SupplierClientDto
    {
        public class Create : GeneralCreateDto
        {
            public MvSupplierClient mvSupplierClient { get; set; }
        }
        public class MvSupplierClient
        {
            public string SupplierClientName { get; set; }
            public string SupplierClientEmail { get; set; }
            public string SupplierClientShippingAddress1 { get; set; }
            public string SupplierClientPhone1 { get; set; }
        }
    }
}
