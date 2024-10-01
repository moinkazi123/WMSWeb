using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class MobileProdIssueUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public MobileProdIssueUtility()
        {
            obj = new DBActivity();

        }
        public async Task<JsonElement> MobileProdIssuelist(GetMobileProdIssuelistRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@wrid",Int64.Parse(req.wrid)),
                        new SqlParameter("@userid",Int64.Parse(req.userid)),
                        new SqlParameter("@custid",Int64.Parse(req.custid)),
                        new SqlParameter("@skey",req.skey),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_mob_MobileProdIssuelist", param));

        }
        public async Task<JsonElement> MobProdIssuelottablelist(GetMobProdIssuelottablelistRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@SkuID",Int64.Parse(req.SkuID)),
                        new SqlParameter("@CustomerId",Int64.Parse(req.CustomerId)),
                        new SqlParameter("@WarehouseId",Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@CompanyId",Int64.Parse(req.CompanyId)),
                        new SqlParameter("@PalletId",Int64.Parse(req.PalletId)),
                        new SqlParameter("@LocationId",Int64.Parse(req.LocationId)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_MobProdIssuelottablelist", param));

        }
        public string MobilePrdIssueSave(MobilePrdIssueSaveRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@UserId",Int64.Parse(req.UserId)),
                        new SqlParameter("@CustomerId",Int64.Parse(req.CustomerId)),
                        new SqlParameter("@FromLocation",Int64.Parse(req.FromLocation)),
                        new SqlParameter("@FromPallet ",Int64.Parse(req.FromPallet )),
                        new SqlParameter("@SkuId",Int64.Parse(req.SkuId)),
                        new SqlParameter("@lot1",req.lot1),
                        new SqlParameter("@lot2 ",req.lot2 ),
                        new SqlParameter("@lot3",req.lot3),
                        new SqlParameter("@Quantity",req.Quantity),
                        new SqlParameter("@ToLocation",Int64.Parse(req.ToLocation)),
                        new SqlParameter("@ToPallet",Int64.Parse(req.ToPallet)),
                        new SqlParameter("@pltname",req.palletname),
                        new SqlParameter("@WarehouseId",Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@ProdReqId",Int64.Parse(req.ProdReqId)),

                    };
            return obj.Return_ScalerValue("SP_MobilePrdIssueSave", param);
        }
        public async Task<JsonElement> MobilePrdIssueScanBarcode(MobilePrdIssueScanBarcodeRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode",req.Barcode),
                        new SqlParameter("@Frompallet",Int64.Parse(req.Frompallet)),
                        new SqlParameter("@FromLocation",Int64.Parse(req.FromLocation)),
                        new SqlParameter("@skuid",Int64.Parse(req.skuid)),
                        new SqlParameter("@Topallet",Int64.Parse(req.Topallet)),
                        new SqlParameter("@Tolocation",Int64.Parse(req.Tolocation)),
                        new SqlParameter("@userid",Int64.Parse(req.userid)),
                        new SqlParameter("@custid",Int64.Parse(req.custid)),
                        new SqlParameter("@CompanyId",Int64.Parse(req.CompanyId)),
                        new SqlParameter("@Warehouse",Int64.Parse(req.Warehouse)),
                        new SqlParameter("@ProdReqID",Int64.Parse(req.ProdReqID)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobProdissueScan", param));

        }
    }
}
