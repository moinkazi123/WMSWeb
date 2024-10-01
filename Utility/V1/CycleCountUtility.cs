using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
using WMSCOREAPI.Model.V1.Request;
using System.Text.Json;

namespace WMSCOREAPI.Utility.V1
{
    public class CycleCountUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public CycleCountUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> palletCheck(palletCheckrequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@CustomerId", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@WarehouseId", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_MobCheckpallet", param));
        }
        public async Task<JsonElement> lottablelist(lottablelistrequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@CustomerId", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@WarehouseId", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@SkuID", Int64.Parse(req.SkuID)),
                        new SqlParameter("@PalletId", Int64.Parse(req.PalletID)),
                        new SqlParameter("@LocationId", Int64.Parse(req.LocationId)),
                          new SqlParameter("@PlanId", Int64.Parse(req.PlanId)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_lottablelist", param));
        }
        public async Task<JsonElement> CycleCountPlanlist(CycleCountPlanlistRequest req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@UserID",Convert.ToInt64( req.UserID)),
                        new SqlParameter("@wrid",Convert.ToInt64(req.WarehouseID)),
                        new SqlParameter("@custid",Convert.ToInt64(req.custid)),
                        new SqlParameter("@skey", req.skey)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_Mobcyclecountlist", param));
        }
        public async Task<JsonElement> CycleCountPlanDetail(CycleCountPlanSkulist req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@oid",Convert.ToInt64( req.PlanID)),
                        new SqlParameter("@wrid",Convert.ToInt64(req.WarehouseID)),
                        new SqlParameter("@custid",Convert.ToInt64(req.custid)),
                        new SqlParameter("@flag",req.Flag),
                        new SqlParameter("@uid",Convert.ToInt64(req.UserID)),
                        new SqlParameter("@CompanyID",Convert.ToInt64(req.CompanyID)),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_CycleCountScanList", param));
        }
        public async Task<DataSet> CycleCountScanBarcode(CycleCountScanBarcoderequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode", req.Barcode),
                        new SqlParameter("@Pallet", Int64.Parse(req.Pallet)),
                        new SqlParameter("@Location", Int64.Parse(req.Location)),
                        new SqlParameter("@SkuID", Int64.Parse(req.SkuID)),
                        new SqlParameter("@UserID", Int64.Parse(req.UserID)),
                        new SqlParameter("@CustId", Int64.Parse(req.CustId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@Warehouse", Int64.Parse(req.Warehouse)),
                        new SqlParameter("@pactive", req.pactive),
                        new SqlParameter("@PlanID", Int64.Parse(req.PlanID)),
                    };
            return obj.Return_DataSet("sp_CycleCountBarcodeScan", param);

        }
        public async Task<JsonElement> CycleCountUpdateQty(CycleCountUpdateqnt req)
        {
            param = new SqlParameter[]
                    {
                       // new SqlParameter("@planid",Convert.ToInt64( req.planid)),@orid
                        new SqlParameter("@orid",Convert.ToInt64( req.planid)),
                       // new SqlParameter("@detailid",Convert.ToInt64( req.detailid)),
                        new SqlParameter("@uid",Convert.ToInt64( req.uid)),
                        new SqlParameter("@custid",Convert.ToInt64( req.custid)),
                        new SqlParameter("@locid",Convert.ToInt64( req.locid)),
                        new SqlParameter("@pltid",Convert.ToInt64( req.pltid)),
                        new SqlParameter("@qty",Convert.ToDecimal( req.qty)),
                        new SqlParameter("@remark",req.remark),
                        new SqlParameter("@prdid",Convert.ToInt64( req.prdid)),
                        new SqlParameter("@batchCode",req.batchCode),
                        new SqlParameter("@reasonid",Convert.ToInt64( req.reasonid)),
                        new SqlParameter("@compid",Convert.ToInt64( req.compid)),
                        new SqlParameter("@lottable1",req.lottable1),
                        new SqlParameter("@lottable2",req.lottable2),
                        new SqlParameter("@lottable3",req.lottable3),
                        new SqlParameter("@lottable4",req.lottable4),
                        new SqlParameter("@lottable5",req.lottable5),
                        new SqlParameter("@lottable6",req.lottable6),
                        new SqlParameter("@lottable7",req.lottable7),
                        new SqlParameter("@lottable8",req.lottable8),
                        new SqlParameter("@lottable9",req.lottable9),
                         new SqlParameter("@lottable10",req.lottable10),
                        new SqlParameter("@elot1",( req.eLot1)),
                        new SqlParameter("@elot2",( req.eLot2)),
                        new SqlParameter("@elot3",( req.eLot3)),
                        new SqlParameter("@elot4",( req.eLot4)),
                        new SqlParameter("@elot5",( req.eLot5)),
                        new SqlParameter("@elot6",( req.eLot6)),
                        new SqlParameter("@elot7",( req.eLot7)),
                        new SqlParameter("@elot8",( req.eLot8)),
                        new SqlParameter("@elot9",( req.eLot9)),
                        new SqlParameter("@elot10",( req.eLot10))

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_UpdatePlanQty", param));
        }

        public async Task<JsonElement> UpdateQntCheck(UpdateQntCheck req)
        {
            param = new SqlParameter[]
                     {
                        new SqlParameter("@planid",Convert.ToInt64( req.planid)),
                        new SqlParameter("@detailid",Convert.ToInt64( req.detailid)),
                        new SqlParameter("@locid",Convert.ToInt64( req.locid)),
                        new SqlParameter("@pallid",Convert.ToInt64( req.pltid)),
                        new SqlParameter("@qty",Convert.ToDecimal( req.qty)),
                        new SqlParameter("@uid",Convert.ToInt64( req.uid)),
                        new SqlParameter("@prdid",Convert.ToInt64(req.prdid))

                       };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UpdateQntCheck", param));
        }
        public async Task<JsonElement> Updateplan(Updateplanrequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@planid", Int64.Parse(req.planid)),
                        new SqlParameter("@custid", Int64.Parse(req.custid)),
                        new SqlParameter("@UserID", Int64.Parse(req.UserID)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_UpdateCycleCountPlanS", param));
        }

        public async Task<JsonElement> SearchLottList(SearchLottList req)
        {
            param = new SqlParameter[]
                    {
                         new SqlParameter("@Pallet", Int64.Parse(req.Pallet)),
                        new SqlParameter("@Location", Int64.Parse(req.Location)),
                        new SqlParameter("@SkuID", Int64.Parse(req.SkuID)),
                        new SqlParameter("@UserID", Int64.Parse(req.UserID)),
                        new SqlParameter("@CustId", Int64.Parse(req.CustId)),
                        new SqlParameter("@Warehouse", Int64.Parse(req.Warehouse)),
                          new SqlParameter("@PlanID", Int64.Parse(req.PlanID)),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SearchLottListMobile", param));
        }


    }
}
