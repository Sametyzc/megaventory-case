using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Dto
{
    public class SalesOrderDto
    {
        public class Create : GeneralCreateDto
        {
            public MvSalesOrder mvSalesOrder { get; set; }
        }

        public class MvSalesOrder
        {
            public int SalesOrderTypeId { get; set; }
            public int SalesOrderClientID { get; set; }
            public int SalesOrderInventoryLocationID { get; set; }
            public string SalesOrderStatus { get; set; }
            public List<MvSalesOrderRow> SalesOrderDetails { get; set; }
        }
        public class MvSalesOrderRow
        {
            public int SalesOrderRowProductID { get; set; }
            public int SalesOrderRowTaxID { get; set; }
            public int SalesOrderRowDiscountID { get; set; }
            public string SalesOrderRowProductSKU { get; set; }
            public double SalesOrderRowQuantity { get; set; }
            public double SalesOrderRowShippedQuantity { get; set; }
            public double SalesOrderRowInvoicedQuantity { get; set; }
            public double SalesOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }
        }
    }
}
