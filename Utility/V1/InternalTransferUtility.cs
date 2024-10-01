using Newtonsoft.Json.Linq;
using static WMSCOREAPI.Model.V1.Request.InboundQC.SaveQCDetailRequest;
using System.Data.SqlClient;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class InternalTransferUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public InternalTransferUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> UOMLottablelist(UOMLottablelistrequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@CustomerId", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@WarehouseId", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@LocationId", Int64.Parse(req.fromLocation)),
                        new SqlParameter("@PalletId", Int64.Parse(req.fromPallet)),
                        new SqlParameter("@SkuID", Int64.Parse(req.SkuID)),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Sp_MobIntlottablelist", param));
        }
        public async Task<DataSet> ScanBarcoder(ScanBarcoderequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode", req.Barcode),
                        new SqlParameter("@Frompallet", Int64.Parse(req.Frompallet)),
                        new SqlParameter("@FromLocation", Int64.Parse(req.FromLocation)),
                        new SqlParameter("@Topallet", Int64.Parse(req.Topallet)),
                        new SqlParameter("@Tolocation", Int64.Parse(req.Tolocation)),
                        new SqlParameter("@SkuID", Int64.Parse(req.SkuID)),
                        new SqlParameter("@UserID", Int64.Parse(req.UserID)),
                        new SqlParameter("@CustId", Int64.Parse(req.CustId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@Warehouse", Int64.Parse(req.Warehouse))
                    };
            return obj.Return_DataSet("IntTransBarcodeScan", param);
        }
        public string SaveInternalTransfer(SaveInternalTransferDetailRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@UserId", Int64.Parse(req.UserId)),
                        new SqlParameter("@CustomerId", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@WarehouseId", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@FromLocation", Int64.Parse(req.FromLocation)),
                        new SqlParameter("@FromPallet", Int64.Parse(req.FromPallet)),
                        new SqlParameter("@SkuId", Int64.Parse(req.SkuId)),
                        new SqlParameter("@Quantity", Decimal.Parse(req.Quantity)),
                        new SqlParameter("@ToLocation", Int64.Parse(req.ToLocation)),
                        new SqlParameter("@ToPallet", Int64.Parse(req.ToPallet)),
                        new SqlParameter("@lot", req.Lottable)
                    };
            return obj.Return_ScalerValue("SP_SaveIntTrans", param);
        }
        public async Task<DataSet> PalletTransfer(PalletTransferRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@palletid", Int64.Parse(req.PalletId)),
                        new SqlParameter("@UserId", Int64.Parse(req.UserID)),
                        new SqlParameter("@CustId", Int64.Parse(req.CustId)),
                        new SqlParameter("@CompanyId", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@WarehouseId", Int64.Parse(req.WarehouseId))
                    };
            return obj.Return_DataSet("Sp_InternalPalletTransfer", param);
        }

        public async Task<JsonElement> CheckIsPallet(CheckIsPalletRequest req)
        {
            param = new SqlParameter[]
            {
                new SqlParameter("@customerID",req.CustomerID)
            };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mobcheck_br_for_InternalTrans", param));
        }

    }
}
