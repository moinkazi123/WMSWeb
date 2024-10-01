namespace WMSCOREAPI.Model.V1.Request
{
    public class GetRepListDetails
    {
        public string wrid { get; set; }
        public string userid { get; set; }
        public string custid { get; set; }
        public string skey { get; set; }
    }

    public class GetRepscanlog
    {
        public string TransID { get; set; }
        public string wrid { get; set; }
        public string userid { get; set; }
        public string custid { get; set; }
        public string tab { get; set; }
    }

    public class GetRepscan
    {
        public string Barcode { get; set; }
        public string FromLocation { get; set; }
        public string Frompallet { get; set; }
        public string SkuID { get; set; }
        public string Topallet { get; set; }
        public string Tolocation { get; set; }
        public string userid { get; set; }
        public string CustId { get; set; }
        public string CompanyId { get; set; }
        public string Warehouse { get; set; }
        public string transId { get; set; }
    }

    public class SaveRepSku
    {
        public string transId { get; set; }
        public string SkuID { get; set; }
        public string fromLocID { get; set; }
        public string fromPalletID { get; set; }

        public string toLocID { get; set; }
        public string toPalletID { get; set; }
        public string qty { get; set; }
        public string Lottable { get; set; }
        public string UserID { get; set; }
        public string CompanyID { get; set; }
        public string Custid { get; set; }
        public string WarehouseId { get; set; }
    }

    public class UpdateStatusRep
    {
        public string transId { get; set; }
        public string Custid { get; set; }
        public string WarehouseId { get; set; }
        public string UserID { get; set; }



    }
}
