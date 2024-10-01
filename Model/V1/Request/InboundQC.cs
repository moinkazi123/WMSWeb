using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMSCOREAPI.Model.V1.Request
{
    public class InboundQC
    {
        public class QCDetailRequest
        {

            // public string OrderId { get; set; }
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }
            public string skey { get; set; }


        }
        public class QCHeadRequest
        {
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }

            public string grnID { get; set; }

            public string qcID { get; set; }
            public string OrderType { get; set; }

        }

        public class grnidreq
        {
            [DataMember(IsRequired = true, Order = 0)]
            public string grnid { get; set; }
        }
        public class InboundQCHistroyRequest
        {
            public string CustomerId { get; set; }
            public string UserId { get; set; }
            public string OrderId { get; set; }

        }

        public class QCRequest
        {
            public string CustomerId { get; set; }
            public string WarehouseId { get; set; }
            public string UserId { get; set; }
            public string OrderId { get; set; }
            public string ordertype { get; set; }

        }
        public class QCResponce
        {
            [DataMember(IsRequired = true, Order = 0)]
            public string Status { get; set; }

            [DataMember(IsRequired = true, Order = 1)]
            public string StatusCode { get; set; }

            [DataMember(Order = 2)]
            public string QCOrderDetails { get; set; }
        }


        public class SaveQCDetailRequest
        {
            public long grnid { get; set; }
            public long poid { get; set; }
            public string acceptqty { get; set; }
            public string rejectedQty { get; set; }
            public long prodID { get; set; }
            public long palletId { get; set; }
            public long UserId { get; set; }
            public long CustomerId { get; set; }
            public long companyID { get; set; }
            public string ObjectName { get; set; }
            public long reasonID { get; set; }
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


            public class SaveQCResponce
            {
                [DataMember(IsRequired = true, Order = 0)]
                public string Status { get; set; }

                [DataMember(IsRequired = true, Order = 1)]
                public string StatusCode { get; set; }

                [DataMember(Order = 2)]
                public string Description { get; set; }
                [DataMember(Order = 3)]
                public string grnID { get; set; }

            }
            public class QCReasonRequest
            {
                [DataMember(IsRequired = true, Order = 0)]
                public string CustomerId { get; set; }

                [DataMember(IsRequired = true, Order = 1)]
                public string CompanyID { get; set; }


            }

            public class QCgetScanLogRequest
            {
                public string GRNID { get; set; }
                public string skuid { get; set; }
                public string oid { get; set; }
                public string PalletID { get; set; }
                public string UserId { get; set; }
                public string CustId { get; set; }
                public string CompanyID { get; set; }
                public string warehouseid { get; set; }
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

            public class QCScanBarcodeRequest
            {

                [DataMember(IsRequired = true, Order = 0)]
                public string Barcode { get; set; }

                [DataMember(IsRequired = true, Order = 1)]
                public string CompanyID { get; set; }

                [DataMember(IsRequired = true, Order = 2)]
                public string CustomerId { get; set; }

                [DataMember(IsRequired = true, Order = 3)]
                public string UserId { get; set; }

                public string GRNID { get; set; }
                public string OrderId { get; set; }


            }

            public class InboundQCBarcodeScan
            {

                public string barcode { get; set; }

                public string orderID { get; set; }

                public string customerID { get; set; }

                public string userID { get; set; }
                public string PalletID { get; set; }

            }

            public class UpdatQCStatus
            {

                public string poID { get; set; }

                public string GRNID { get; set; }

            }

            public class SaveFinalQCStatus
            {

                public string poID { get; set; }

                public string GRNID { get; set; }
                public string UID { get; set; }

                public string CustID { get; set; }
            }

            public class GetQCsaveDetailScanlog
            {
                public string grnID { get; set; }

            }
            public class ReciveNotification
            {
                public string OrderReferenceNO { get; set; }
                public string MaterialDoc { get; set; }
                public string RecieptDate { get; set; }
                public string Fiscalyear { get; set; }
                public string DocDate { get; set; }

                public List<GoodRecieptItemSet> GoodRecieptItemSet;

                public List<ReturnMessageSet> ReturnMessageSet;
            }
            public class GoodRecieptItemSet
            {
                public string MovementIndicator { get; set; }
                public string OrderReferenceNO { get; set; }
                public string ItemNo { get; set; }
                public string CustomerNo { get; set; }
                public string SKUcode { get; set; }
                public string MoveType { get; set; }
                public string Plant { get; set; }
                public string WareHouseCode { get; set; }
                public string Quantity { get; set; }
                public string Uom { get; set; }
            }
            public class ReturnMessageSet
            {

            }

            public class Recivenotificationlog
            {
                public string materialdoc { get; set; }
                public string fiscalyear { get; set; }
                public string type { get; set; }
                public string number { get; set; }
                public string message { get; set; }
                public string Id { get; set; }
                public string docyear { get; set; }
            }

            public class MobGetQCSKUHistory
            {
                public string CustomerId { get; set; }
                public string UserId { get; set; }
                public string OrderId { get; set; }
                public string Skuid { get; set; }

            }
        }

    }
}
