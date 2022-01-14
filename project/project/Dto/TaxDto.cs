
namespace project.Dto
{
    public class TaxDto
    {
        public class Create : GeneralCreateDto
        {
            public MvTax mvTax { get; set; }
        }

        public class MvTax
        {
            public string TaxName { get; set; }
            public string TaxDescription { get; set; }
            public double TaxValue { get; set; }
        }
    }
}
