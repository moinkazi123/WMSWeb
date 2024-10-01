using System.Runtime.Serialization;

namespace WMSCOREAPI.Model.V1.Request
{
    public class OutboundQC
    {
        public class GetQCOutListRequest
        {
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }
            public string skey { get; set; }
        }
        public class OutboundQCScanBarcodeRequest
        {
            [DataMember(IsRequired = true, Order = 0)]
            public string Barcode { get; set; }

            [DataMember(IsRequired = true, Order = 1)]
            public string PickupId { get; set; }

            [DataMember(IsRequired = true, Order = 3)]
            public string SkuId { get; set; }

            [DataMember(IsRequired = true, Order = 4)]
            public string UserId { get; set; }
            public string CustId { get; set; }
        }
        public class QCgetOutbondScanLogRequest
        {
            public string PickUpID { get; set; }
            public string ProdID { get; set; }
            public string CompanyID { get; set; }
            public string Lottables { get; set; }
        }

        public class QCgetLottableListRequest
        {
            public string PickUpID { get; set; }
            public string ProdID { get; set; }

        }
        public class QCHistroyRequest
        {
            public string CustomerId { get; set; }
            public string UserId { get; set; }
            public string OrderId { get; set; }
        }
        public class SaveOutboundQCDetailRequest
        {
            public long PickupId { get; set; }
            public string Remark { get; set; }
            public long AcceptQty { get; set; }
            public string RejectedQty { get; set; }
            public long ProdID { get; set; }
            public long UserId { get; set; }
            public long CustomerId { get; set; }
            public string Lottables { get; set; }
            public string reasonID { get; set; }
            public string Object { get; set; }

        }
        public class UpdatQCOutboundStatus
        {
            public string PickupID { get; set; }
            public string UserID { get; set; }
            public string CustomerID { get; set; }
        }
        public class GetQCScannedProdList
        {
            public string pickupid { get; set; }
            public string UserId { get; set; }
        }
        public class GetQCSOListRequest
        {
            public string OrderId { get; set; }
            public string CustId { get; set; }
        }

        public class SkuwiseOutbondMobQCHistory
        {
            public string CustomerId { get; set; }
            public string UserId { get; set; }
            public string OrderId { get; set; }
            public string Skuid { get; set; }
        }
    }
}
