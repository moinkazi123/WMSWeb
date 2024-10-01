using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using static WMSCOREAPI.Model.V1.Request.Packing;

namespace WMSCOREAPI.Utility.V1
{
    public class PackingUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public PackingUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> GetPackingList(GetPackingListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@uid", req.uid),
                        new SqlParameter("@wrid", req.WrId),
                        new SqlParameter("@custid", req.Custid),
                        new SqlParameter("@skey", req.skey),
                        new SqlParameter("@obj", req.Object)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_PackingListV2", param));
        }
        public async Task<JsonElement> GetPackingSOList(GetPackingSOListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@uid", req.uid)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PackingSOList", param));
        }
        public async Task<JsonElement> GetSOSKUList(GetSOSKUListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchID),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@uid", req.UserId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PackingSKUList", param));
        }
        public async Task<JsonElement> GetSOSKULog(GetSOSKULogRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchID),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@uid", req.UserId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PackingScanLog", param));
        }
        public DataSet ScanBarcode(PackingBarcodeScanRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@barcode", req.Barcode),
                        new SqlParameter("@packlocId",req.PackLocId),
                        new SqlParameter("@cartonid", req.CartonId),
                        new SqlParameter("@skuid", req.SkuId),
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@compid", req.CompanyId)
                    };
            return obj.Return_DataSet("PackingBarcodeScan", param);
        }
        public async Task<JsonElement> GetSKUDetail(PackingSKUDetailRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@skuid", req.SkuId),
                        new SqlParameter("@tasktab", req.tasktab),
                        new SqlParameter("@Lot1", req.Lot1),
                        new SqlParameter("@Lot2", req.Lot2),
                        new SqlParameter("@Lot3", req.Lot3),
                        new SqlParameter("@Lot4", req.Lot4),
                        new SqlParameter("@Lot5", req.Lot5),
                        new SqlParameter("@Lot6", req.Lot6),
                        new SqlParameter("@Lot7", req.Lot7),
                        new SqlParameter("@Lot8", req.Lot8),
                        new SqlParameter("@Lot9", req.Lot9),
                        new SqlParameter("@Lot10", req.Lot10)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PackingSOSKUDetail", param));
        }
        public string SaveSKUDetails(SaveSKUDetailRequest req)
        {
            param = new SqlParameter[]
                  {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@locid", req.PackLocId),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@cid", req.CartonId),
                        new SqlParameter("@skuid", req.SkuId),
                        new SqlParameter("@uomid", req.UomId),
                        new SqlParameter("@uom", req.Uom),
                        new SqlParameter("@lot", req.lot),
                        new SqlParameter("@qty", req.Quantity),
                        new SqlParameter("@package", req.Package),
                        new SqlParameter("@wt", req.Weight),
                        new SqlParameter("@note", req.Note),
                        new SqlParameter("@compid", req.CompanyId),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@obj", req.Object),
                        new SqlParameter("@len", req.Length),
                        new SqlParameter("@wth", req.Width),
                        new SqlParameter("@ht", req.Height)
                  };
            return obj.Return_ScalerValue("SavePackingSKU", param);
        }
        public string SaveDetails(PackingSaveRequest req)
        {
            param = new SqlParameter[]
                  {
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@wrid", req.WarehouseId),
                        new SqlParameter("@uid", req.UserId)
                  };
            return obj.Return_ScalerValue("SavePacking", param);
        }

        public async Task<JsonElement> SkuwisePackingSKUList(SkuwisePackingSKUList req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@soid", req.SOID),
                        new SqlParameter("@qcid", req.QCID),
                        new SqlParameter("@custid", req.CustomerId),
                        new SqlParameter("@Skuid", req.SkuId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SkuWisePackingSKUList", param));
        }

        public async Task<JsonElement> MobUpdateQtyPacking(MobUpdateQtyPacking req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Palletid", req.Palletid),
                        new SqlParameter("@prodid", req.prodid),
                        new SqlParameter("@DisId", req.DisId),
                        new SqlParameter("@soid", req.soid),
                         new SqlParameter("@qty", req.qty),
                         new SqlParameter("@lot", req.lot),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("MobUpdateQtyPacking", param));
        }
    }
}
