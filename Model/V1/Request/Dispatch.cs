using System.ComponentModel.DataAnnotations;

namespace WMSCOREAPI.Model.V1.Request
{
    public class Dispatch
    {
        public class GetDispatchListRequest
        {
            public Int64 uid { get; set; }
            public Int64 WrId { get; set; }
            public Int64 Custid { get; set; }
            public string skey { get; set; }
        }
        public class GetDispatchOrderViewRequest
        {
            public Int64 DispatchId { get; set; }

        }
        public class GetDispatchDetailRequest
        {
            public Int64 BatchId { get; set; }
            public Int64 PackingNo { get; set; }
            public Int64 SOID { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public string tab { get; set; }
        }
        public class CarrierListRequest
        {
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }
            public string OrderID { get; set; }
        }
        public class SaveDispatchBySORequest
        {
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }
            public string BatchID { get; set; }
            public string SOID { get; set; }
            public string CarrierID { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string TrackingNO { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string DriverName { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string PickUpBy { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string ScheduleDateTime { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string ActualDateTime { get; set; }
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string LRNo { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string VehicleNo { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string TransportRemark { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string BOL { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string TransportName { get; set; }
            public string DispatchHeadId { get; set; }

            public string DocImage { get; set; }
            public string DocSignature { get; set; }
        }

        public class UpdateQtyRequest
        {
            public long DispatchId { get; set; }
            public long Soid { get; set; }
            public long ProdId { get; set; }
            public long CartonId { get; set; }
            public string Lottables { get; set; }
            public decimal DispatchQty { get; set; }
            public decimal Qty { get; set; }
            public long UserId { get; set; }
        }

        public class GetDispatchmobScan
        {
            public Int64 BatchId { get; set; }
            public Int64 PackingNo { get; set; }
            public Int64 SOID { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public string Barcode { get; set; }

        }

        public class Dispatchmobvalidate
        {
            public Int64 BatchId { get; set; }
            public Int64 PackingNo { get; set; }
            public Int64 SOID { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }

        }

        public class GetDispatchmobSkuScan
        {
            public Int64 BatchId { get; set; }
            public Int64 PackingNo { get; set; }
            public Int64 SOID { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public string Barcode { get; set; }

        }

        public class GetDispatchmobSkuSave
        {
            public Int64 BatchId { get; set; }
            public Int64 PackingNo { get; set; }
            public Int64 SOID { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 Skuid { get; set; }
            public string Lott { get; set; }

        }

    }
}
