
namespace project.Dto
{
    public class DiscountDto
    {
        public class Create : GeneralCreateDto
        {
            public MvDiscount mvDiscount { get; set; }
        }

        public class MvDiscount
        {
            public string DiscountName { get; set; }
            public string DiscountDescription { get; set; }
            public double DiscountValue { get; set; }
        }
    }
}
