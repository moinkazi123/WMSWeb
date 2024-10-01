using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text.Json;
using System.Web;
using WMSCOREAPI.Models.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class GRNActivity
    {
        SqlParameter[] param;
        DBActivity obj;
        public GRNActivity()
        {
            obj = new DBActivity();
        }
        //Mobile 
        public async Task<JsonElement> GetGRNListDetails(GetGRNListDetails req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@wrid", req.wrid),
                        new SqlParameter("@userid", req.userid),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@skey", req.skey)
                    };
            // return obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_MobMobileGrnList", param));  //android

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_getMobileInwarlist", param));
        }

        public async Task<JsonElement> GetDropDownOption(GetDropDownOption req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@Obj", req.Obj),
                         new SqlParameter("@CompanyID", req.CompanyID),
                          new SqlParameter("@warehouseID", req.warehouseID),
                          new SqlParameter("@CustomerID", req.CustomerID),
                          new SqlParameter("@OrderId", req.OrderId),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_getDropdownvaluesmobile", param));  //android
        }

        public string MobSaveGateDetails(SaveGRNTransportDetails req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@CustomerId", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@UserId", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@OrderId", Convert.ToInt64(req.OrderId)),
                        new SqlParameter("@Object", req.Object),
                        new SqlParameter("@AirwayBill", req.AirwayBill),
                        new SqlParameter("@ShippingType", req.ShippingType),
                        new SqlParameter("@ShippingDate", req.ShippingDate),
                        new SqlParameter("@ExpDeliveryDate", req.ExpDeliveryDate),
                        new SqlParameter("@TransporterName", req.TransporterName),

                       /* new SqlParameter("@TransporterNameId", Convert.ToInt64(req.TransporterNameId)),
                        new SqlParameter("@TransporterRemark", req.TransporterRemark),
                        new SqlParameter("@DockId", Convert.ToInt64(req.DockId)),
                        //new SqlParameter("@DockNo",  req.TruckNo),
                        new SqlParameter("@TruckNo", req.TruckNo),*/

                         new SqlParameter("@Other", req.ShippingNo),
                        new SqlParameter("@LRNo", req.LRNo),
                        new SqlParameter("@InTime", req.InTime),
                        new SqlParameter("@OutTime", req.OutTime),
                        new SqlParameter("@Trailer", req.Trailer),
                        new SqlParameter("@Seal", req.Seal),
                        new SqlParameter("@Carrier", req.Carrier),
                    };
            return obj.Return_ScalerValue("SP_SumbitGrnTransferDetails", param); //android
        }

        public async Task<JsonElement> GetGRNIDfromPalletSKU(GetGRNIDfromPalletSKURequest req)
        {

            string Lottable1 = "0";
            string Lottable2 = "0";
            string Lottable3 = "0";
            string avalue = "";
            long lotcnt = 0;
            long lotentrcnt = 0;
            string Status = "fail";
            if (req.islottablevalue != "No")
            {
                foreach (string item in req.islottablevalue.Split('|'))
                {



                }
            }

            param = new SqlParameter[]
                    {

                         new SqlParameter("@Barcode", req.barcode),
                         new SqlParameter("@Oid", req.OrderID),
                         new SqlParameter("@CompanyID", Int32.Parse(req.CompanyID)),
                        //new SqlParameter("@grnID", Int32.Parse(req.grnID)),
                         new SqlParameter("@ObjectName", req.ObjectName),
                         new SqlParameter("@UserId", Int32.Parse(req.UserId)),
                         new SqlParameter("@CustId", Int32.Parse(req.CustId)),
                         new SqlParameter("@PalletId", Int32.Parse(req.PalletId)),
                         new SqlParameter("@islottable",req.islottablevalue),
                         new SqlParameter("@Lottable1",Lottable1),
                         new SqlParameter("@Lottable2", Lottable2),
                         new SqlParameter("@Lottable3",Lottable3)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanPalletandSKUID", param)); //android
        }
        public async Task<JsonElement> GRNRecevingSKUScan(GetGRNRecevingSKUScan req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@oid", req.OrderID),
                        new SqlParameter("@grnID", req.grnID),
                        new SqlParameter("@skuID", req.skuID),
                        new SqlParameter("@custId", req.CustId),
                        new SqlParameter("@ObjName", req.ObjectName),
                        new SqlParameter("@userID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@Lottable1", req.Lottable1),
                        new SqlParameter("@Lottable2", req.Lottable2),
                        new SqlParameter("@Lottable3", req.Lottable3),
                        new SqlParameter("@palletid", req.PalletID),


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_RecevingSKUScan", param)); //android
        }

        public async Task<JsonElement> GetGRNScanLog(GetGRNScanLog req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@oid", req.OrderID),
                        new SqlParameter("@custId", req.CustId),
                        new SqlParameter("@ObjName", req.ObjectName),
                        new SqlParameter("@userID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_RecevingScanLog", param)); //android
        }

        public async Task<JsonElement> GetReceivingHistory(GetReceivingHistory req)
        {
            param = new SqlParameter[]
                    {

                             new SqlParameter("@POID", req.Poid),
                            new SqlParameter("@grnid", req.grnid),
                            new SqlParameter("@custid", req.CustId),
                            new SqlParameter("@userid", req.userID)
                      /*  new SqlParameter("@scanqty", req.scanqty),
                        new SqlParameter("@productID", req.productID),
                        new SqlParameter("@palletID", req.@palletID),
                        new SqlParameter("@id", req.id)*/
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("GetGRNPartDetailsNew", param));//SP_GetReceivingHistory android
        }

        public async Task<JsonElement> UpdateReceivingQuantity(UpdateReceivingProdQuantity req)
        {
            string uom = "";
            long olduomId = 0;

            param = new SqlParameter[]
                    {

                        new SqlParameter("@OID", req.oid),
                        new SqlParameter("@skuid", req.skuid),
                        new SqlParameter("@palletid", req.palletid),
                        new SqlParameter("@qty", req.qty),
                        new SqlParameter("@acceptextra", req.acceptextra),
                        new SqlParameter("@obj", req.objname),
                        new SqlParameter("@grn", req.grn),
                        new SqlParameter("@uid", req.user_id)
                    };
            // return obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_mob_updategrnqty", param));// update qty android
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UpdategrnMobile", param));
        }


        public async Task<JsonElement> SaveGRN(SaveGRN req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@oid", req.oid),
                        new SqlParameter("@obj", req.objname),
                        new SqlParameter("@grn", req.grnid),
                        new SqlParameter ("@isDirectOrder", req.isDirectOrder),
                         new SqlParameter("@Uid", req.Uid),
                        new SqlParameter("@Custid", req.Custid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_UpdateStatus", param)); // final save android
        }

        public async Task<JsonElement> BarcodeScanLott(BarcodeScanLott req)
        {
            param = new SqlParameter[]
                    {

                         new SqlParameter("@barcode", req.barcode),
                         new SqlParameter("@Oid", req.OrderID),
                         new SqlParameter("@companyID", Int32.Parse(req.CompanyID)),
                         new SqlParameter("@objectname", req.ObjectName),
                         new SqlParameter("@Userid", Int32.Parse(req.UserId)),
                         new SqlParameter("@custid", Int32.Parse(req.CustId)),
                         new SqlParameter("@PalletId", Int32.Parse(req.PalletId)),
                         new SqlParameter("@srno", req.SerialNo),
                         new SqlParameter("@IsRejectCheck", req.IsReject),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanPalletandSKUIDForLott", param)); //android
        }

        public async Task<JsonElement> UpdateSkuandpalletLott(UpdateSkuandpalletLott req)
        {
            param = new SqlParameter[]
                    {

                         new SqlParameter("@Oid", req.OrderID),
                         new SqlParameter("@grnID", req.GrnID),
                         new SqlParameter("@Userid", Int32.Parse(req.UserId)),
                         new SqlParameter("@custid", Int32.Parse(req.CustId)),
                         new SqlParameter("@companyID", Int32.Parse(req.CompanyID)),
                         new SqlParameter("@objectname", req.ObjectName),
                         new SqlParameter("@PalletId", Int32.Parse(req.PalletId)),
                         new SqlParameter("@palletname", req.PalletName),
                         new SqlParameter("@SKUId", Int32.Parse(req.SkuId)),
                         new SqlParameter("@Lottable1", req.Lottable1),
                         new SqlParameter("@Lottable2", req.Lottable2),
                         new SqlParameter("@Lottable3", req.Lottable3),
                         new SqlParameter("@Lottable4", req.Lottable4),
                         new SqlParameter("@Lottable5", req.Lottable5),
                         new SqlParameter("@Lottable6", req.Lottable6),
                         new SqlParameter("@Lottable7", req.Lottable7),
                         new SqlParameter("@Lottable8", req.Lottable8),
                         new SqlParameter("@Lottable9", req.Lottable9),
                         new SqlParameter("@Lottable10", req.Lottable10),

                              new SqlParameter("@srno", req.SerialNo),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UpdatePalletandSKUIDForLott", param)); //android
        }

        public async Task<JsonElement> UpdateGrnMobLott(UpdateGrnMobLott req)
        {
            param = new SqlParameter[]
                    {

                            new SqlParameter("@oid", req.oid),
                            new SqlParameter("@skuid", req.skuid),
                            new SqlParameter("@palletid", req.palletid),
                            new SqlParameter("@qty", req.qty),
                            new SqlParameter("@acceptextra", req.acceptextra),
                            new SqlParameter("@obj", req.objname),
                            new SqlParameter("@grn", req.grn),
                            new SqlParameter("@uid", req.user_id),
                            new SqlParameter("@Lottable1", req.Lottable1),
                            new SqlParameter("@Lottable2", req.Lottable2),
                            new SqlParameter("@Lottable3", req.Lottable3),
                            new SqlParameter("@Lottable4", req.Lottable4),
                            new SqlParameter("@Lottable5", req.Lottable5),
                            new SqlParameter("@Lottable6", req.Lottable6),
                            new SqlParameter("@Lottable7", req.Lottable7),
                            new SqlParameter("@Lottable8", req.Lottable8),
                            new SqlParameter("@Lottable9", req.Lottable9),
                            new SqlParameter("@Lottable10", req.Lottable10),
                            new SqlParameter("@eLot1", req.eLot1),
                            new SqlParameter("@eLot2", req.eLot2),
                            new SqlParameter("@eLot3", req.eLot3),
                            new SqlParameter("@eLot4", req.eLot4),
                            new SqlParameter("@eLot5", req.eLot5),
                            new SqlParameter("@eLot6", req.eLot6),
                            new SqlParameter("@eLot7", req.eLot7),
                            new SqlParameter("@eLot8", req.eLot8),
                            new SqlParameter("@eLot9", req.eLot9),
                            new SqlParameter("@eLot10", req.eLot10),
                            new SqlParameter("@rejqty", req.rejectedQty),
                            new SqlParameter("@remark", req.getRemark),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UpdategrnMobileLott", param)); //android
        }

        public async Task<JsonElement> forceUpdateGrnQuantity(forceUpdateGrnQuantity req)
        {
            param = new SqlParameter[]
                    {

                            new SqlParameter("@oid", req.oid),
                            new SqlParameter("@skuid", req.skuid),
                            new SqlParameter("@palletid", req.palletid),
                            new SqlParameter("@qty", req.qty),
                            new SqlParameter("@acceptextra", req.acceptextra),
                            new SqlParameter("@obj", req.objname),
                            new SqlParameter("@grn", req.grn),
                            new SqlParameter("@uid", req.user_id),
                            new SqlParameter("@Lottable1", req.Lottable1),
                            new SqlParameter("@Lottable2", req.Lottable2),
                            new SqlParameter("@Lottable3", req.Lottable3),
                            new SqlParameter("@Lottable4", req.Lottable4),
                            new SqlParameter("@Lottable5", req.Lottable5),
                            new SqlParameter("@Lottable6", req.Lottable6),
                            new SqlParameter("@Lottable7", req.Lottable7),
                            new SqlParameter("@Lottable8", req.Lottable8),
                            new SqlParameter("@Lottable9", req.Lottable9),
                            new SqlParameter("@Lottable10", req.Lottable10),

                    };
            return  await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ForceUpdateQty", param)); //android
        }

        public async Task<JsonElement> UpdateGrnLottable(UpdateGrnLottable req)
        {
            param = new SqlParameter[]
                    {

                            new SqlParameter("@OrderID", req.oid),
                            new SqlParameter("@Skuid", req.skuid),
                            new SqlParameter("@Custid", req.custid),
                            new SqlParameter("@userID", req.userid),
                            new SqlParameter("@warehouseID", req.wrid),

                            new SqlParameter("@Lott1", req.Lottable1),
                            new SqlParameter("@Lott2", req.Lottable2),
                            new SqlParameter("@Lott3", req.Lottable3),
                            new SqlParameter("@Lott4", req.Lottable4),
                            new SqlParameter("@Lott5", req.Lottable5),
                            new SqlParameter("@Lott6", req.Lottable6),
                            new SqlParameter("@Lott7", req.Lottable7),
                            new SqlParameter("@Lott8", req.Lottable8),
                            new SqlParameter("@Lott9", req.Lottable9),
                            new SqlParameter("@Lott10", req.Lottable10),


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("InsertNewLottGRN", param)); //android
        }

        public async Task<JsonElement> SkuGrnHistory(SkuGrnHistory req)
        {
            param = new SqlParameter[]
                    {

                             new SqlParameter("@POID", req.POID),
                            new SqlParameter("@grnid", req.grnid),
                           new SqlParameter("@custid", req.custid),
                            new SqlParameter("@userid", req.userid),
                            new SqlParameter("@SKUID", req.SKUID),


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobSkuWiseHistory", param)); //android
        }

        public async Task<JsonElement> CheckGrnID(CheckGrnID req)
        {
            param = new SqlParameter[]
                    {
                            new SqlParameter("@OID", req.OID),
                            new SqlParameter("@whid", req.whid),
                            new SqlParameter("@custid", req.custid),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_CheckGrnID", param)); //android
        }

        public async Task<JsonElement> UpdateQtyGrnHistory(UpdateQtyGrnHistory req)
        {
            param = new SqlParameter[]
                    {
                            new SqlParameter("@GRNID", req.GRNID),
                            new SqlParameter("@Skuid", req.Skuid),
                            new SqlParameter("@palletId", req.palletId),
                            new SqlParameter("@Qty", req.Qty),
                            new SqlParameter("@lottable1", req.lottable1),
                            new SqlParameter("@lottable2", req.lottable2),
                            new SqlParameter("@lottable3", req.lottable3),
                            new SqlParameter("@lottable4", req.lottable4),
                            new SqlParameter("@lottable5", req.lottable5),
                            new SqlParameter("@lottable6", req.lottable6),
                            new SqlParameter("@lottable7", req.lottable7),
                            new SqlParameter("@lottable8", req.lottable8),
                            new SqlParameter("@lottable9", req.lottable9),
                            new SqlParameter("@lottable10", req.lottable10),
                            new SqlParameter("@IsReject", req.IsReject),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("UpdateQty_GrnHistory", param)); //android
        }

    }
}
