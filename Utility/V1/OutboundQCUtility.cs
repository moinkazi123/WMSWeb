using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text.Json;
using static WMSCOREAPI.Model.V1.Request.OutboundQC;

namespace WMSCOREAPI.Utility.V1
{
    public class OutboundQCUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public OutboundQCUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> OutbondQCList(GetQCOutListRequest req)
        {
            param = new SqlParameter[]
                 {
                    new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                    new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                    new SqlParameter("@userid", Convert.ToInt64(req.UserId)),
                    new SqlParameter("@skey",req.skey)
                 };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_OutboundQCList", param));
        }
        public async Task<DataSet> OutbondGetBarcodeScan(OutboundQCScanBarcodeRequest req)
        {
            param = new SqlParameter[]
                {
                        new SqlParameter("@barcode",req.Barcode),
                        new SqlParameter("@pickupid",req.PickupId),
                        new SqlParameter("@skuid",req.SkuId),
                        new SqlParameter("@userid",req.UserId),
                        new SqlParameter("@custid",req.CustId)
                };
            return obj.Return_DataSet("sp_OutboundBarcodeScan", param);
        }

        public async Task<JsonElement> OutbondMobQCLottableList(QCgetLottableListRequest req)
        {
            param = new SqlParameter[]
                   {
                       new SqlParameter("@pickipid", Convert.ToInt64(req.PickUpID)),
                        new SqlParameter("@ProdID", Convert.ToInt64(req.ProdID))
                   };
            return  await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_mob_OutQC_lottablelist", param));
        }
        public async Task<JsonElement> OutbondMobQCScanLog(QCgetOutbondScanLogRequest req)
        {
            param = new SqlParameter[]
                   {
                        new SqlParameter("@pickipid", Convert.ToInt64(req.PickUpID)),
                        new SqlParameter("@ProdID", Convert.ToInt64(req.ProdID)),
                        new SqlParameter("@CompanyID", Convert.ToInt64(req.CompanyID)),
                        new SqlParameter("@loattabels", req.Lottables)
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getMobOutboundQCScanLog", param));
        }
        public async Task<JsonElement> OutbondMobQCHistory(QCHistroyRequest req)
        {
            param = new SqlParameter[]
                   {
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetOutboundQCHistory", param));
        }
        public string OutbondMobQCSaveDetails(SaveOutboundQCDetailRequest req)
        {
            param = new SqlParameter[]
                  {
                        new SqlParameter("@pkid", req.PickupId),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@remark", req.Remark),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@prdid", req.ProdID),
                        new SqlParameter("@lot", req.Lottables),
                        new SqlParameter("@qty", req.AcceptQty),
                        new SqlParameter("@rejqty", req.RejectedQty),
                        new SqlParameter("@rid", req.reasonID),
                        new SqlParameter("@obj", req.Object)
                  };
            return obj.Return_ScalerValue("SP_SaveMobQCOutboundDetail", param);
        }
        public async Task<JsonElement> MobQCSvaeScanLog(GetQCScannedProdList req)
        {
            param = new SqlParameter[]
                   {
                        new SqlParameter("@pickupid", Convert.ToInt64(req.pickupid)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId))
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_getQCScannedProdList", param));
        }
        public string UpdateQCStatus(UpdatQCOutboundStatus req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@pkid", Convert.ToInt64(req.PickupID)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserID)),
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerID))
                    };
            return obj.Return_ScalerValue("sp_UpdateOutboundQCStatus", param);
        }
        public async Task<JsonElement> QCSOListRequest(GetQCSOListRequest req)
        {
            param = new SqlParameter[]
                   {
                        new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),
                        new SqlParameter("@custid", Convert.ToInt64(req.CustId))
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("GetQCSOList", param));
        }

        public async Task<JsonElement> SkuwiseOutbondMobQCHistory(SkuwiseOutbondMobQCHistory req)
        {
            param = new SqlParameter[]
                   {
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),
                        new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_SkuwiseOutboundQCHistory", param));
        }
    }
}
