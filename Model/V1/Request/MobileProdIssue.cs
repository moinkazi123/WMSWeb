namespace WMSCOREAPI.Model.V1.Request
{
    public class GetMobileProdIssuelistRequest
    {
        public string wrid { get; set; }
        public string userid { get; set; }
        public string custid { get; set; }
        public string skey { get; set; }

    }
    public class GetMobProdIssuelottablelistRequest
    {
        public string SkuID { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string PalletId { get; set; }
        public string LocationId { get; set; }

    }
    public class MobilePrdIssueSaveRequest
    {
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string FromLocation { get; set; }
        public string FromPallet { get; set; }
        public string SkuId { get; set; }
        public string lot1 { get; set; }
        public string lot2 { get; set; }
        public string lot3 { get; set; }
        public string Quantity { get; set; }
        public string ToLocation { get; set; }
        public string ToPallet { get; set; }
        public string palletname { get; set; }
        public string ProdReqId { get; set; }
    }
    public class MobilePrdIssueScanBarcodeRequest
    {
        public string Barcode { get; set; }
        public string Frompallet { get; set; }
        public string FromLocation { get; set; }
        public string Topallet { get; set; }
        public string Tolocation { get; set; }
        public string skuid { get; set; }
        public string userid { get; set; }
        public string custid { get; set; }
        public string CompanyId { get; set; }
        public string Warehouse { get; set; }
        public string ProdReqID { get; set; }

    }
}
