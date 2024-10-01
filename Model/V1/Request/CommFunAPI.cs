namespace WMSCOREAPI.Model.V1.Request
{
    public class CommFunAPI
    {
    }
    public class ReqPalletList
    {
        public Int64 CompanyId { get; set; }
        public Int64 userId { get; set; }
        public Int64 whId { get; set; }
        public Int64 custId { get; set; }
        public string PalletName { get; set; }
        public string obj { get; set; }
    }
    public class SKUSuggestionRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string skuobject { get; set; }
        public string skey { get; set; }
        public string orderobj { get; set; }
    }

    public class ScanSuggestionRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string obj { get; set; }
        public string currentpg { get; set; }
        public string recordlmt { get; set; }
    }
    public class SKUUOMRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }

        public string SkuId { get; set; }
    }

    public class scanrequest
    {
        public string value { get; set; }

        public string companyID { get; set; }
        public string obj { get; set; }
        public string orderID { get; set; }

    }
    public class lottablereq
    {

        public string prodID { get; set; }
        public string orderID { get; set; }
        public string obj { get; set; }
    }
    public class userlist
    {
        public string companyID { get; set; }
    }
    public class assinguserRequest
    {
        public string type { get; set; }

        public string UserID { get; set; }
        public string date { get; set; }

        public string time { get; set; }
        public string companyID { get; set; }
        public string customerID { get; set; }
        public string createdBy { get; set; }
    }
    public class Login
    {
        public string usrId { get; set; }
        public string usrPass { get; set; }
        public string Username { get; set; }
    }
    public class scanmobilerequest
    {
        public string barcode { get; set; }

        public string customerID { get; set; }

        public string userID { get; set; }
        public string obj { get; set; }
        public string ispallet { get; set; }
        public string orderID { get; set; }

    }

    public class ScanMobileSerialBarcode
    {
        public string Barcode { get; set; }
        public string CustID { get; set; }
        public string UserID { get; set; }
        public string WHID { get; set; }
    }
}
