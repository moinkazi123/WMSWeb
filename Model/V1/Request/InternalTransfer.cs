namespace WMSCOREAPI.Model.V1.Request
{
    public class ScanBarcoderequest
    {
        public string Barcode { get; set; }
        public string Frompallet { get; set; }
        public string FromLocation { get; set; }
        public string Topallet { get; set; }
        public string Tolocation { get; set; }
        public string SkuID { get; set; }
        public string UserID { get; set; }
        public string CustId { get; set; }
        public string Warehouse { get; set; }
        public string CompanyId { get; set; }
    }
    public class UOMLottablelistrequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string fromLocation { get; set; }
        public string fromPallet { get; set; }
        public string SkuID { get; set; }
        public string UserID { get; set; }

    }
    public class SaveInternalTransferDetailRequest
    {
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string Remark { get; set; }
        public string FromLocation { get; set; }
        public string FromPallet { get; set; }
        public string SkuId { get; set; }
        public string Lottable { get; set; }
        public string Quantity { get; set; }
        public string ToLocation { get; set; }
        public string ToPallet { get; set; }
    }
    public class PalletTransferRequest
    {
        public string Barcode { get; set; }
        public string PalletId { get; set; }
        public string UserID { get; set; }
        public string CustId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
    }

    public class CheckIsPalletRequest
    {
        public string CustomerID { get; set; }
    }
}
