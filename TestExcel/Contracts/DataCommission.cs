namespace TestExcel.Contracts
{
    public struct ContractDataCommissionStruct
    {
        public Documents.DocumentZakrivashki documentZakrivashki { get; set; }
        public Documents.DocumentSalesData documentSalesData { get; set; }
    }

    //public class program2
    //{
    //    public static void processstruct(ContractDataCommissionStruct contract)
    //    {
    //        contract.documentSalesData.row = 10;
    //    }

    //    public static void main2()
    //    {
    //        var contract = new ContractDataCommissionStruct();
    //        contract.documentSalesData = new Documents.DocumentSalesData();
    //        processstruct(contract);
    //    }
    //}
}