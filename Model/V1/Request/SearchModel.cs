namespace WMSCOREAPI.Model.V1.Request
{
    public class GetSearchDropDownValues
    {
        public string CustomerId { get; set; }

    }

    public class GetSearchBarcodeScan
    {
        public string SearchType { get; set; }
        public string Barcode { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
    }

    public class GetSearchScanLog
    {
        public string SearchType { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string CompanyId { get; set; }
        public string SearchId { get; set; }
    }
}
