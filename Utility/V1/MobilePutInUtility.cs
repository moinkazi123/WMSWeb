using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class MobilePutInUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public MobilePutInUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> GetUserDetails(MobilePutIn req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@UserID", req.UserID)


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getuserprofiledetails", param));
        }


        public async Task<JsonElement> GetPalletLocationDetails(GetPalletLocationDetailsRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@companyID", req.CompanyID),
                        new SqlParameter("@custid", req.CustomerID),
                        new SqlParameter("@userID", req.UserID),
                        new SqlParameter("@palletID", req.PalletID)

                    };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanPalletandLocation", param));


        }


        public async Task<JsonElement> GetSkuLocationDetails(GetSkuLocationDetailsRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@companyID", req.CompanyID),
                        new SqlParameter("@custid", req.CustomerID),
                        new SqlParameter("@userID", req.UserID),
                        new SqlParameter("@SkuID", req.SkuID),
                        new SqlParameter("@OrderID", req.orderID),
                          new SqlParameter("@warehouseid", req.warehouseid)

                    };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanSkuandLocation", param));

        }

        public async Task<JsonElement> GetPutInLastScan(GetPutInLastScanRequest req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@SkuID", req.SkuID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@qcid", req.qcid),
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
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutInLastScan", param));
        }

        public async Task<JsonElement> GetPutAwayHistory(GetPutAwayHistoryRequest req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@qcID", req.qcID),
                          new SqlParameter("@custid", req.custid),
                        new SqlParameter("@uid", req.uid)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobPutAwayHistory", param));
        }


        public async Task<JsonElement> GetSuggestedLocationBySKU(GetSuggestedLocationBySKURequest req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@prdid", req.prdid),
                        new SqlParameter("@wareid", req.wareid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetSuggestLoc", param));
        }

        public async Task<JsonElement> GetPutInmobilelist(GetPutInSKUListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@wrid", req.wrid),
                        new SqlParameter("@userid", req.userid),
                         new SqlParameter("@custid", req.custid),
                        new SqlParameter("@skey", req.skey)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_PutinlistMobile", param));
        }

        public async Task<JsonElement> ScanMobileBarcodeNOQC(ScanMobileBarcodeNOQC req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@companyID", req.CompanyID),
                        new SqlParameter("@custid", req.CustomerID),
                        new SqlParameter("@userID", req.UserID),
                        new SqlParameter("@palletID", req.palletID),
                        new SqlParameter("@orderid", req.Grnid),
                        new SqlParameter("@wareid", req.WarehouseId)

                    };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanPalletandLocNoQC", param));


        }
        public async Task<JsonElement> ScanLogMobileNOQC(ScanLogMobileNOQC req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@PalletID", req.palletID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@grnid", req.Grnid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutInScanLogNoQc", param));
        }

        public async Task<JsonElement> GetLocListNoQc(GetLocListNoQc req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@orderid", req.Grnid),
                        new SqlParameter("@wareid", req.wareid),
                        new SqlParameter("@palletID", req.palletid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_StgLocNoQc", param));
        }

        public async Task<JsonElement> PutInScanNoQcNoPallet(PutInScanNoQcNoPallet req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@SkuID", req.SkuID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@Grnid", req.Grnid),
                        new SqlParameter("@Lottable1", req.Lottable1),
                        new SqlParameter("@Lottable2", req.Lottable2),
                        new SqlParameter("@Lottable3", req.Lottable3),
                        new SqlParameter("@Lottable4", req.Lottable4),
                        new SqlParameter("@Lottable5", req.Lottable5),
                        new SqlParameter("@Lottable6", req.Lottable6),
                        new SqlParameter("@Lottable7", req.Lottable7),
                        new SqlParameter("@Lottable8", req.Lottable8),
                        new SqlParameter("@Lottable9", req.Lottable9),
                        new SqlParameter("@Lottable10", req.Lottable10)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutInScanNoQCNoPlt", param));
        }

        public async Task<JsonElement> ScanMobBarcodeNoQcNoPallet(ScanMobBarcodeNoQcNoPallet req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@companyID", req.CompanyID),
                        new SqlParameter("@custid", req.CustomerID),
                        new SqlParameter("@userID", req.UserID),
                        new SqlParameter("@SkuID", req.SKUID),
                        new SqlParameter("@GrnID", req.Grnid),
                        new SqlParameter("@warehouseid", req.warehouseid),
                        new SqlParameter("@IsRejected", req.IsRejected)

                    };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_scanNoQcNoPallet", param));


        }

        public async Task<JsonElement> getPutInScanYes(getPutInScanYes req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@PalletID", req.palletID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@qcid", req.qcid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutInLastScanyes", param));
        }

        public async Task<JsonElement> UpdateQtyPutinNoQC(UpdateQtyPutinNoQC req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@SkuID", req.SkuID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@Grnid", req.Grnid),
                        new SqlParameter("@Qty", req.Qty),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@Object", req.Object),
                        new SqlParameter("@Lottable1", req.Lottable1),
                        new SqlParameter("@Lottable2", req.Lottable2),
                        new SqlParameter("@Lottable3", req.Lottable3),
                        new SqlParameter("@Lottable4", req.Lottable4),
                        new SqlParameter("@Lottable5", req.Lottable5),
                        new SqlParameter("@Lottable6", req.Lottable6),
                        new SqlParameter("@Lottable7", req.Lottable7),
                        new SqlParameter("@Lottable8", req.Lottable8),
                        new SqlParameter("@Lottable9", req.Lottable9),
                        new SqlParameter("@Lottable10", req.Lottable10)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutinUpdateQtyNoQC", param));
        }

        public async Task<JsonElement> HistoryPutinNoQC(HistoryPutinNoQC req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@qcID", req.qcID),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetPutAwayHistoryNoQCNOPlt", param));
        }

        public async Task<JsonElement> UpdateQtyPutinWithQC(UpdateQtyPutinWithQC req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@SkuID", req.SkuID),
                        new SqlParameter("@LocationID", req.locationID),
                        new SqlParameter("@UserID", req.userID),
                        new SqlParameter("@warehouseID", req.warehouseID),
                        new SqlParameter("@Qcid", req.Qcid),
                        new SqlParameter("@Qty", req.Qty),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@Object", req.Object),
                        new SqlParameter("@Lottable1", req.Lottable1),
                        new SqlParameter("@Lottable2", req.Lottable2),
                        new SqlParameter("@Lottable3", req.Lottable3),
                        new SqlParameter("@Lottable4", req.Lottable4),
                         new SqlParameter("@Lottable5", req.Lottable5),
                         new SqlParameter("@Lottable6", req.Lottable6),
                         new SqlParameter("@Lottable7", req.Lottable7),
                         new SqlParameter("@Lottable8", req.Lottable8),
                         new SqlParameter("@Lottable9", req.Lottable9),
                         new SqlParameter("@Lottable10", req.Lottable10)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PutinUpdateQtyWithQC", param));
        }

        public async Task<JsonElement> HistoryPutinWithQC(HistoryPutinWithQC req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@qcID", req.qcID),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@uid", req.uid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobPutAwayHistoryWithQCNOPlt", param));
        }

        public async Task<JsonElement> PutAwayHistoryWithOutQcWithPlt(PutAwayHistoryWithOutQcWithPlt req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@GRNID", req.GRNID),
                         new SqlParameter("@custid", req.custid),
                        new SqlParameter("@uid", req.uid)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobPutAwayHistoryNoQCYesPlt", param));
        }

        public async Task<JsonElement> MobGetPutAwaySKUHistory(MobGetPutAwaySKUHistory req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                       new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),
                       new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_MobGetPutAwaySKUHistory", param));
        }

        public async Task<JsonElement> SKUHistoryNoQCYesPlt(SKUHistoryNoQCYesPlt req)
        {

            param = new SqlParameter[]
                    {

                       new SqlParameter("@GRNID", Convert.ToInt64(req.GRNID)),
                       new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobSKUHistoryNoQCYesPlt", param));
        }

        public async Task<JsonElement> SKUHistoryWithQCNoPlt(SKUHistoryWithQCNoPlt req)
        {

            param = new SqlParameter[]
                    {

                       new SqlParameter("@qcID", Convert.ToInt64(req.QCID)),
                       new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_SKUHistoryWithQCNoPlt", param));
        }

        public async Task<JsonElement> MobPutAwayHistoryNoQCNoPlt(MobPutAwayHistoryNoQCNoPlt req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@GRNID", req.GRNID),
                         new SqlParameter("@custid", req.custid),
                        new SqlParameter("@uid", req.uid)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobPutAwayHistoryNoQCNoPlt", param));
        }

        public async Task<JsonElement> SKUHistoryNoQCNoPlt(SKUHistoryNoQCNoPlt req)
        {

            param = new SqlParameter[]
                    {

                       new SqlParameter("@GRNID", Convert.ToInt64(req.GrnID)),
                       new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_SKUHistoryNoQCNoPlt", param));
        }

        public async Task<JsonElement> ScanputinMobile(ScanputinMobile req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode",req.barcode),
                        new SqlParameter("@customerID",req.customerID),
                        new SqlParameter("@UserID",req.userID),
                        new SqlParameter("@OrderID",req.orderID),
                        new SqlParameter("@obj",req.obj),
                        new SqlParameter("@ispallet",req.ispallet),
                         new SqlParameter("@WarehouseID",req.Warehouse),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_scanMobileinwarputin", param));
        }


    }
}
