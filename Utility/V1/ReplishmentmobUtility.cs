using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class ReplishmentmobUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public ReplishmentmobUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> GetRepListDetails(GetRepListDetails req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@wrid", req.wrid),
                        new SqlParameter("@userid", req.userid),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@skey", req.skey)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_mob_replishmentlist", param));
        }
        public async Task<JsonElement> GetRepscanlog(GetRepscanlog req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@TransID", req.TransID),
                        new SqlParameter("@wrid", req.wrid),
                        new SqlParameter("@userid", req.userid),
                        new SqlParameter("@custid", req.custid),
                        new SqlParameter("@tab", req.tab)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_scanlog_Replishment", param));
        }

        public async Task<JsonElement> GetRepscan(GetRepscan req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@FromLocation", req.FromLocation),
                        new SqlParameter("@Frompallet", req.Frompallet),
                        new SqlParameter("@skuid", req.SkuID),
                        new SqlParameter("@Topallet", req.Topallet),
                        new SqlParameter("@Tolocation", req.Tolocation),
                        new SqlParameter("@userid", req.userid),
                        new SqlParameter("@custid", req.CustId),
                        new SqlParameter("@CompanyId", req.CompanyId),
                        new SqlParameter("@Warehouse", req.Warehouse),
                        new SqlParameter("@transId", req.transId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("RepMobBarcodeScan", param));
        }

        public async Task<JsonElement> SaveRepSku(SaveRepSku req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@transId", req.transId),
                        new SqlParameter("@SKUID", req.SkuID),
                        new SqlParameter("@fromLocID", req.fromLocID),
                        new SqlParameter("@fromPalletID", req.fromPalletID),
                        new SqlParameter("@toLocID", req.toLocID),
                        new SqlParameter("@toPalletID", req.toPalletID),
                        new SqlParameter("@qty", req.qty),
                        new SqlParameter("@lot", req.Lottable),
                        new SqlParameter("@UserID", req.UserID),
                        new SqlParameter("@CompanyID", req.CompanyID),
                        new SqlParameter("@Custid", req.Custid),
                        new SqlParameter("@WarehouseId", req.WarehouseId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_mob_Replishment_UpdateStock", param));
        }

        public async Task<JsonElement> UpdateStatusRep(UpdateStatusRep req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@transId", req.transId),
                        new SqlParameter("@Custid", req.Custid),
                        new SqlParameter("@WarehouseId", req.WarehouseId),
                        new SqlParameter("@UserID", req.UserID)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("UpdateRepStatus", param));
        }
    }
}
