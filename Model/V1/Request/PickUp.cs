using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMSCOREAPI.Models.V1.Request
{
    public class PickUp
    {
        public class GetPickUpListRequest
        {
            public Int64 uid { get; set; }
            public Int64 WrId { get; set; }
            public Int64 Custid { get; set; }
            public string skey { get; set; }
        }
        public class GetPickUpListVwOrderRequest
        {
            public Int64 batchId { get; set; }
            public string Object { get; set; }

        }
        public class GetPickUpSKUListRequest
        {
            public string BatchID { get; set; }
            public string TrID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
        }
        public class GetPickUpScanLogRequest
        {
            public string BatchID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string Tab { get; set; }
            public string lastSeqNo { get; set; }
        }

        public class PickUpBarcodeScanRequest
        {
            public string BatchID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string CompanyId { get; set; }
            public string WarehouseId { get; set; }
            public string StgLocationId { get; set; }
            public string LocationId { get; set; }
            public string PalletId { get; set; }
            public string SkuId { get; set; }
            public string Barcode { get; set; }
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
            public string getIsBarcode { get; set; }
        }
        public class PickUpLottableRequest
        {
            public string BatchID { get; set; }
            public string LocationId { get; set; }
            public string PalletId { get; set; }
            public string SkuId { get; set; }
            public string UserId { get; set; }
            public string lottable { get; set; }
            public string isScan { get; set; }
        }

        public class PickUpSKUSaveRequest
        {
            public string BatchID { get; set; }
            public string WarehouseId { get; set; }
            public string CustomerId { get; set; }
            public string CompanyId { get; set; }
            public string UserId { get; set; }
            public string Object { get; set; }
            public string StgLocationId { get; set; }
            public string LocationId { get; set; }
            public string PalletId { get; set; }
            public string SkuId { get; set; }
            public string lottable { get; set; }
            public string Quantity { get; set; }
            public string Uomid { get; set; }
            public string type { get; set; }
            public string trid { get; set; }
        }
        public class PickUpFinalSave
        {
            public string BatchID { get; set; }
            public string WarehouseId { get; set; }
            public string CustomerId { get; set; }
            public string CompanyId { get; set; }
            public string UserId { get; set; }
            public string Object { get; set; }
        }
        public class GetPickUpEditListRequest
        {
            public Int64 ProdId { get; set; }
            public Int64 BatchId { get; set; }
            public Int64 UserId { get; set; }
        }
        public class UpdatePickUpRequest
        {
            public long ID { get; set; }
            public decimal NewQty { get; set; }
            public decimal OldQty { get; set; }
            public long UserId { get; set; }
        }
        public class SkuWisePickUpSKUList
        {
            public string BatchID { get; set; }
            public string TrID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }

            public string SkuId { get; set; }
        }

        public class PickEditScanLog
        {
            public string BatchID { get; set; }
            public string tab { get; set; }
            public string PalletID { get; set; }
            public string SKUID { get; set; }
            public string editseq { get; set; }
            public string locationid { get; set; }

            public string UserID { get; set; }
        }

        public class PickEditScanBarcode
        {
            public string BatchID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string CompanyId { get; set; }
            public string WarehouseId { get; set; }
            public string StgLocationId { get; set; }
            public string LocationId { get; set; }
            public string PalletId { get; set; }
            public string SkuId { get; set; }
            public string Barcode { get; set; }
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
            public string getIsBarcode { get; set; }
            public string IsEdit { get; set; }
        }
        public class PickEditLottableList
        {
            public string BatchID { get; set; }
            public string LocationId { get; set; }
            public string PalletId { get; set; }
            public string SkuId { get; set; }
            public string UserId { get; set; }
            public string lottable { get; set; }
        }
        public class SavePickUpEditDetails
        {
            public decimal pkQty { get; set; }
            public long skuID { get; set; }
            public long TrID { get; set; }
            public long oldTrID { get; set; }
            public long batchId { get; set; }
            public long CustId { get; set; }
            public string IsSerial { get; set; }
        }
        public class PickEditCompletedScanLog
        {
            public string BatchID { get; set; }
            public string Object { get; set; }
            public string UserId { get; set; }
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }

        }
    }
}
