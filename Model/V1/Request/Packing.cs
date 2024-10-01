using System.ComponentModel.DataAnnotations;

namespace WMSCOREAPI.Model.V1.Request
{
    public class Packing
    {
        public class GetPackingListRequest
        {
            public Int64 uid { get; set; }
            public Int64 WrId { get; set; }
            public Int64 Custid { get; set; }
            public string skey { get; set; }
            public string Object { get; set; }
        }
        public class GetPackingSOListRequest
        {
            public Int64 BatchID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 uid { get; set; }
        }
        public class GetSOSKUListRequest
        {
            public Int64 BatchID { get; set; }
            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 UserId { get; set; }
        }
        public class GetSOSKULogRequest
        {
            public Int64 BatchID { get; set; }
            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 UserId { get; set; }
        }
        public class PackingBarcodeScanRequest
        {
            public string Barcode { get; set; }
            public Int64 PackLocId { get; set; }
            public Int64 CartonId { get; set; }
            public Int64 SkuId { get; set; }
            public Int64 BatchId { get; set; }
            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 UserId { get; set; }
            public Int64 CompanyId { get; set; }
        }
        public class PackingSKUDetailRequest
        {
            public Int64 SkuId { get; set; }
            public Int64 BatchId { get; set; }
            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public string tasktab { get; set; }
            public string Lot1 { get; set; }
            public string Lot2 { get; set; }
            public string Lot3 { get; set; }
            public string Lot4 { get; set; }
            public string Lot5 { get; set; }
            public string Lot6 { get; set; }
            public string Lot7 { get; set; }
            public string Lot8 { get; set; }
            public string Lot9 { get; set; }
            public string Lot10 { get; set; }
        }
        public class SaveSKUDetailRequest
        {
            public Int64 BatchId { get; set; }
            public Int64 QCID { get; set; }
            public Int64 SOID { get; set; }
            public Int64 PackLocId { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 CartonId { get; set; }
            public Int64 SkuId { get; set; }
            public Int64 UomId { get; set; }
            public string Uom { get; set; }
            public string lot { get; set; }
            public decimal Quantity { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public int Package { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public decimal Weight { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Note { get; set; }
            public Int64 CompanyId { get; set; }
            public Int64 UserId { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Object { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public decimal Length { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public decimal Width { get; set; }

            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public decimal Height { get; set; }
        }
        public class PackingSaveRequest
        {
            public Int64 BatchId { get; set; }
            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 WarehouseId { get; set; }
            public Int64 UserId { get; set; }
        }
        public class SkuwisePackingSKUList
        {

            public Int64 SOID { get; set; }
            public Int64 QCID { get; set; }
            public Int64 CustomerId { get; set; }
            public Int64 SkuId { get; set; }
        }

        public class MobUpdateQtyPacking
        {

            public Int64 Palletid { get; set; }
            public Int64 prodid { get; set; }
            public Int64 DisId { get; set; }
            public Int64 soid { get; set; }
            public Int64 qty { get; set; }
            public string lot { get; set; }
        }
    }
}
