using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace WMSCOREAPI.Models.V1.Request
{
    public class GetGRNSKUListRequest
    {
        public string poid { get; set; }
        public string grnid { get; set; }
        public string status { get; set; }
    }
    public class SaveGRNSKUListRequest
    {
        public string obj { get; set; }
        public string oid { get; set; }
        public string uid { get; set; }
        public string batch { get; set; }
        public string prodid { get; set; }
        public string pltid { get; set; }
        public string lot { get; set; }
        public string qty { get; set; }
        public string uomid { get; set; }
        public string noofpack { get; set; }
        public string allowextra { get; set; }
    }
    public class RemoveGRNSKURequest
    {
        public string gID { get; set; }
    }
    public class GetGRNTransportListRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string Object { get; set; }
    }
    public class SaveGRNTransportRequest
    {
        public string GRNId { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string Object { get; set; }
        public string AirwayBill { get; set; }
        public string ShippingType { get; set; }
        public string ShippingDate { get; set; }
        public string ExpDeliveryDate { get; set; }
        public string TransporterName { get; set; }
        public string TransporterNameId { get; set; }
        public string TransporterRemark { get; set; }
        public string DockNo { get; set; }
        public string DockId { get; set; }
        public string TruckNo { get; set; }
        public string LRNo { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string ContainerID { get; set; }
        public string Trailer { get; set; }
        public string Seal { get; set; }
        public string Carrier { get; set; }
    }
    public class GetGRNTransportDetailtRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string Object { get; set; }
    }
    public class GRNHeadRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }

        public string grnID { get; set; }
        public string OrderType { get; set; }
    }
    public class GRNDetailRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string ordertype { get; set; }

    }
    public class GRNOrderDetails
    {
        public string Id { get; set; }
        public string Grndate { get; set; }
        public string Batchcode { get; set; }
        public string Createdby { get; set; }
        public string SkuId { get; set; }
        public string ItemCode { get; set; }
        public string PalletName { get; set; }
        public string UOM { get; set; }

        public string UOMId { get; set; }
        public string POQty { get; set; }


        public string GRNQty { get; set; }
        public string Lottables { get; set; }


        public List<UomList> UomList;
    }


    public class GRNDetailResponce
    {
        [DataMember(IsRequired = true, Order = 0)]
        public string Status { get; set; }

        [DataMember(IsRequired = true, Order = 1)]
        public string StatusCode { get; set; }

        [DataMember(Order = 2)]
        public string GRNOrderDetails { get; set; }
    }
    public class UpdatGrnStatus
    {

        public string poID { get; set; }
    }
    public class SaveGRNDetailRequest
    {
        public long CustomerId { get; set; }
        public long WarehouseId { get; set; }
        public long companyID { get; set; }
        public long UserId { get; set; }
        public long poID { get; set; }
        public string obj { get; set; }
        public long grnID { get; set; }
        public string grnDate { get; set; }
        public string batchno { get; set; }
        public long prodID { get; set; }
        public long palletID { get; set; }

        public string RequestedQty { get; set; }

        public string GRNQty { get; set; }

        public string UOMId { get; set; }


        public string Lottables { get; set; }

        public string type { get; set; }
    }
    public class poidreq
    {
        [DataMember(IsRequired = true, Order = 0)]
        public string poid { get; set; }
    }
    public class GatePassDetailRequest
    {
        public string CustomerId { get; set; }
        public string WarehouseId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string grnID { get; set; }
    }

    //mobile 

    public class GetGRNListDetails
    {
        public string wrid { get; set; }
        public string userid { get; set; }
        public string custid { get; set; }
        public string skey { get; set; }
    }

    public class GetDropDownOption
    {
        public string Obj { get; set; }
        public string CompanyID { get; set; }
        public string warehouseID { get; set; }
        public string CustomerID { get; set; }
        public string OrderId { get; set; }

    }
    public class SaveGRNTransportDetails
    {
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public string OrderId { get; set; }
        public string Object { get; set; }
        public string AirwayBill { get; set; }
        public string ShippingType { get; set; }
        public string ShippingDate { get; set; }
        public string ExpDeliveryDate { get; set; }
        public string TransporterName { get; set; }

        public string ShippingNo { get; set; }
        public string LRNo { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string Trailer { get; set; }
        public string Seal { get; set; }
        public string Carrier { get; set; }

    }

    public class GetGRNIDfromPalletSKURequest
    {
        public string barcode { get; set; }
        public string CompanyID { get; set; }
        public string OrderID { get; set; }

        public string ObjectName { get; set; }
        public string UserId { get; set; }
        public string CustId { get; set; }
        public string PalletId { get; set; }
        public string islottablevalue { get; set; }




    }

    public class GetGRNScanLog
    {
        public string OrderID { get; set; }
        public string ObjectName { get; set; }
        public string CustId { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
    }
    public class GetGRNRecevingSKUScan
    {
        public string grnID { get; set; }
        public string OrderID { get; set; }
        public string skuID { get; set; }
        public string ObjectName { get; set; }
        public string CustId { get; set; }
        public string userID { get; set; }
        public string warehouseID { get; set; }
        public string Lottable1 { get; set; }
        public string Lottable2 { get; set; }
        public string Lottable3 { get; set; }
        public string PalletID { get; set; }
    }

    public class GetReceivingHistory
    {
        /* public string scanqty { get; set; }
         public string productID { get; set; }
         public string palletID { get; set; }
         public string id { get; set; }*/
        public string Poid { get; set; }
        public string grnid { get; set; }
        public string CustId { get; set; }
        public string userID { get; set; }


    }

    public class UpdateReceivingProdQuantity
    {
        public string oid { get; set; }
        public string wrid { get; set; }
        public string user_id { get; set; }
        public string skuid { get; set; }
        public string palletid { get; set; }
        public string qty { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]


        public string acceptextra { get; set; }
        public string custid { get; set; }
        public string objname { get; set; }
        public string grn { get; set; }

    }

    public class SaveGRN
    {
        public string oid { get; set; }
        public string objname { get; set; }
        public string grnid { get; set; }
        public string isDirectOrder { get; set; }
        public string Uid { get; set; }
        public string Custid { get; set; }

    }

    public class BarcodeScanLott
    {
        public string barcode { get; set; }
        public string CompanyID { get; set; }
        public string OrderID { get; set; }

        public string ObjectName { get; set; }
        public string UserId { get; set; }
        public string CustId { get; set; }
        public string PalletId { get; set; }
        public string SerialNo { get; set; }
        public string IsReject { get; set; }

    }
    public class UpdateSkuandpalletLott
    {

        public string OrderID { get; set; }
        public string GrnID { get; set; }
        public string UserId { get; set; }
        public string CustId { get; set; }
        public string CompanyID { get; set; }
        public string ObjectName { get; set; }
        public string PalletId { get; set; }
        public string PalletName { get; set; }

        public string SkuId { get; set; }
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

        public string SerialNo { get; set; }

    }

    public class UpdateGrnMobLott
    {

        public string oid { get; set; }
        public string wrid { get; set; }
        public string user_id { get; set; }
        public string skuid { get; set; }
        public string palletid { get; set; }
        public string qty { get; set; }
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

        public string eLot1 { get; set; }
        public string eLot2 { get; set; }
        public string eLot3 { get; set; }
        public string eLot4 { get; set; }
        public string eLot5 { get; set; }
        public string eLot6 { get; set; }
        public string eLot7 { get; set; }
        public string eLot8 { get; set; }
        public string eLot9 { get; set; }
        public string eLot10 { get; set; }
        public string rejectedQty { get; set; }
        public string getRemark { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]


        public string acceptextra { get; set; }
        public string custid { get; set; }
        public string objname { get; set; }
        public string grn { get; set; }
    }
    public class forceUpdateGrnQuantity
    {

        public string oid { get; set; }
        public string wrid { get; set; }
        public string user_id { get; set; }
        public string skuid { get; set; }
        public string palletid { get; set; }
        public string qty { get; set; }
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


        [DisplayFormat(ConvertEmptyStringToNull = false)]


        public string acceptextra { get; set; }
        public string custid { get; set; }
        public string objname { get; set; }
        public string grn { get; set; }
    }

    public class UpdateGrnLottable
    {

        public string oid { get; set; }
        public string skuid { get; set; }
        public string custid { get; set; }
        public string userid { get; set; }
        public string wrid { get; set; }

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

    public class SkuGrnHistory
    {

        public string POID { get; set; }
        public string grnid { get; set; }
        public string custid { get; set; }
        public string userid { get; set; }
        public string SKUID { get; set; }


    }

    public class CheckGrnID
    {
        public string OID { get; set; }
        public string whid { get; set; }
        public string custid { get; set; }

    }

    public class UpdateQtyGrnHistory
    {
        public string GRNID { get; set; }
        public string Skuid { get; set; }
        public string palletId { get; set; }
        public string Qty { get; set; }
        public string lottable1 { get; set; }
        public string lottable2 { get; set; }
        public string lottable3 { get; set; }
        public string lottable4 { get; set; }
        public string lottable5 { get; set; }
        public string lottable6 { get; set; }
        public string lottable7 { get; set; }
        public string lottable8 { get; set; }
        public string lottable9 { get; set; }
        public string lottable10 { get; set; }
        public string IsReject { get; set; }

    }
}

