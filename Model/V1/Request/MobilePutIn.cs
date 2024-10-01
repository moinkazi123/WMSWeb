namespace WMSCOREAPI.Model.V1.Request
{
    public class MobilePutIn
    {
        public string UserID { get; set; }

        //public string UserId { get; set; }
    }
    
    public class GetPalletLocationDetailsRequest
    {
        public string Barcode { get; set; }

        public string CompanyID { get; set; }

        public string CustomerID { get; set; }

        public string UserID { get; set; }

        public string PalletID { get; set; }

    }

    public class GetSkuLocationDetailsRequest
    {
        public string Barcode { get; set; }

        public string CompanyID { get; set; }

        public string CustomerID { get; set; }

        public string UserID { get; set; }

        public string SkuID { get; set; }

        public string orderID { get; set; }

        public string warehouseid { get; set; }

    }

    //public class GetLocationRequest
    //{
    //    //barcode, CompanyID, wrid, user_id
    //    public string barcode { get; set; }

    //    public string companyID { get; set; }

    //    public string wrid { get; set; }



    //}

    //public class GetGRNIDfromPalletIDRequest
    //{

    //    public string barcode { get; set; }

    //    public string CompanyID { get; set; }



    //}

    //public class GetPUTINStatusRequest
    //{
    //    //internal SqlDbType skuid;

    //    public string grnID { get; set; }

    //    public string uid { get; set; }



    //}



    public class GetPutInLastScanRequest
    {
        public string palletID { get; set; }
        public string SkuID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string qcid { get; set; }
        public string Lottable1 { get; set; }
        public string Lottable2 { get; set; }
        public string Lottable3 { get; set; }
        public string Lottable4 { get; set; }
        public string Lottable5 { get; set; }
        public string Lottable6 { get; set; }
        public string Lottable7 { get; set; }
        public string Lottable8 { get; set; }
        public string Lottable9 { get; set; }
        public string Lottable10 { get; set; }

    }

    public class ScanLogMobileNOQC
    {
        public string palletID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string Grnid { get; set; }

    }
    public class ScanMobileBarcodeNOQC
    {
        public string Barcode { get; set; }
        public string CompanyID { get; set; }
        public string CustomerID { get; set; }
        public string UserID { get; set; }
        public string palletID { get; set; }
        public string Grnid { get; set; }
        public string WarehouseId { get; set; }
    }

    public class GetPutAwayHistoryRequest
    {
        public string qcID { get; set; }
        public string custid { get; set; }
        public string uid { get; set; }

    }

    public class GetSuggestedLocationBySKURequest
    {
        public string prdid { get; set; }
        public string wareid { get; set; }

    }

    public class GetLocListNoQc
    {
        public string Grnid { get; set; }
        public string wareid { get; set; }
        public string palletid { get; set; }

    }

    public class GetPutInSKUListRequest
    {
        public string wrid { get; set; }

        public string userid { get; set; }
        public string custid { get; set; }

        public string skey { get; set; }
    }

    public class PutInScanNoQcNoPallet
    {
        public string SkuID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string Grnid { get; set; }
        public string Lottable1 { get; set; }
        public string Lottable2 { get; set; }
        public string Lottable3 { get; set; }
        public string Lottable4 { get; set; }
        public string Lottable5 { get; set; }
        public string Lottable6 { get; set; }
        public string Lottable7 { get; set; }
        public string Lottable8 { get; set; }
        public string Lottable9 { get; set; }
        public string Lottable10 { get; set; }

    }
    public class ScanMobBarcodeNoQcNoPallet
    {
        public string Barcode { get; set; }
        public string CompanyID { get; set; }
        public string CustomerID { get; set; }
        public string UserID { get; set; }
        public string SKUID { get; set; }
        public string Grnid { get; set; }
        public string warehouseid { get; set; }
        public string IsRejected { get; set; }
    }

    public class getPutInScanYes
    {
        public string palletID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string qcid { get; set; }

    }
    public class UpdateQtyPutinNoQC
    {
        public string SkuID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string Grnid { get; set; }
        public string Qty { get; set; }
        public string custid { get; set; }
        public string Object { get; set; }
        public string Lottable1 { get; set; }
        public string Lottable2 { get; set; }
        public string Lottable3 { get; set; }
        public string Lottable4 { get; set; }
        public string Lottable5 { get; set; }
        public string Lottable6 { get; set; }
        public string Lottable7 { get; set; }
        public string Lottable8 { get; set; }
        public string Lottable9 { get; set; }
        public string Lottable10 { get; set; }

    }
    public class HistoryPutinNoQC
    {
        public string qcID { get; set; }

    }

    public class UpdateQtyPutinWithQC
    {
        public string SkuID { get; set; }
        public string locationID { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string Qcid { get; set; }
        public string Qty { get; set; }
        public string custid { get; set; }
        public string Object { get; set; }
        public string Lottable1 { get; set; }
        public string Lottable2 { get; set; }
        public string Lottable3 { get; set; }
        public string Lottable4 { get; set; }
        public string Lottable5 { get; set; }
        public string Lottable6 { get; set; }
        public string Lottable7 { get; set; }
        public string Lottable8 { get; set; }
        public string Lottable9 { get; set; }
        public string Lottable10 { get; set; }

    }
    public class HistoryPutinWithQC
    {
        public string qcID { get; set; }
        public string custid { get; set; }
        public string uid { get; set; }

    }

    public class PutAwayHistoryWithOutQcWithPlt
    {
        public string GRNID { get; set; }
        public string custid { get; set; }
        public string uid { get; set; }

    }
    public class MobGetPutAwaySKUHistory
    {
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string Skuid { get; set; }

    }

    public class SKUHistoryNoQCYesPlt
    {
        public string GRNID { get; set; }

        public string Skuid { get; set; }

    }

    public class SKUHistoryWithQCNoPlt
    {
        public string QCID { get; set; }

        public string Skuid { get; set; }

    }
    public class MobPutAwayHistoryNoQCNoPlt
    {
        public string GRNID { get; set; }
        public string custid { get; set; }
        public string uid { get; set; }
    }

    public class SKUHistoryNoQCNoPlt
    {
        public string GrnID { get; set; }

        public string Skuid { get; set; }

    }

    public class ScanputinMobile
    {
        public string barcode { get; set; }

        public string customerID { get; set; }
        public string userID { get; set; }

        public string orderID { get; set; }
        public string obj { get; set; }

        public string ispallet { get; set; }
        public string Warehouse { get; set; }

    }
}
