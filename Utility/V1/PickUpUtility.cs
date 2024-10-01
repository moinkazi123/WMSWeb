using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
//using WMSCOREAPI.Models.V1.Request;
using System.Text.Json;
using static WMSCOREAPI.Models.V1.Request.PickUp;

namespace WMSCOREAPI.Utility.V1
{
    public class PickUpUtility
    {
        SqlParameter[] param;
        DBActivity obj;
        public PickUpUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> PickUpList(GetPickUpListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@uid", req.uid),
                        new SqlParameter("@WrId", req.WrId),
                        new SqlParameter("@custid", req.Custid),
                        new SqlParameter("@skey", req.skey)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_PickUpListV2", param));
        }
        public async Task<JsonElement> GetPickUpListVwOrder(GetPickUpListVwOrderRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@BtachId", req.batchId),
                        new SqlParameter("@Object", req.Object)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_PickUpVwOrderV2", param));
        }
        public async Task<JsonElement> PickUpSKUList(GetPickUpSKUListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@ODID", req.BatchID),
                        new SqlParameter("@TRID", req.TrID),
                        new SqlParameter("@objectname", req.Object),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@custid",  Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid",  Convert.ToInt64(req.WarehouseId))
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("WMS_SP_PickUpListNew", param));
        }
        public async Task<JsonElement> PickUpScanLog(GetPickUpScanLogRequest req)
        {
            param = new SqlParameter[]
                   {
                    new SqlParameter("@ODID", req.BatchID),
                    new SqlParameter("@UserID", Convert.ToInt64(req.UserId)),
                    new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                    new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                    new SqlParameter("@obj",  req.Object),
                    new SqlParameter("@tab",  req.Tab),
                    new SqlParameter("@lastSeqno", Convert.ToInt64  (req.lastSeqNo))
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_DyanmicPickUpPending", param));
        }
        public async Task<DataSet> ScanBarcode(PickUpBarcodeScanRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Int64.Parse(req.BatchID)),
                        new SqlParameter("@obj", req.Object),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@compid", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@stglocid", Int64.Parse(req.StgLocationId)),
                        new SqlParameter("@locid", Int64.Parse(req.LocationId)),
                        new SqlParameter("@pltid", Int64.Parse(req.PalletId)),
                        new SqlParameter("@skuid", Int64.Parse(req.SkuId)),
                        new SqlParameter("@barcode", req.Barcode),
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
                         new SqlParameter("@getIsBarcode", req.getIsBarcode)

                    };
            return obj.Return_DataSet("PickUpBarcodeScan", param);
        }
        public async Task<JsonElement> PickUpSKULottable(PickUpLottableRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Convert.ToInt64(req.BatchID)),
                        new SqlParameter("@locid", Convert.ToInt64(req.LocationId)),
                        new SqlParameter("@pltid", Convert.ToInt64(req.PalletId)),
                        new SqlParameter("@skuid", Convert.ToInt64(req.SkuId)),
                        new SqlParameter("@lot", req.lottable),
                        new SqlParameter("@isScan", req.isScan),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PickUpLottable", param));
        }
        public string PickUpSKUSave(PickUpSKUSaveRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Int64.Parse(req.BatchID)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@compid", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@obj", req.Object),
                        new SqlParameter("@stglocid", Int64.Parse(req.StgLocationId)),
                        new SqlParameter("@locid", Int64.Parse(req.LocationId)),
                        new SqlParameter("@pltid", Int64.Parse(req.PalletId)),
                        new SqlParameter("@skuid", Int64.Parse(req.SkuId)),
                        new SqlParameter("@lot", req.lottable),
                        new SqlParameter("@qty", decimal.Parse(req.Quantity)),
                        new SqlParameter("@uomid", Int64.Parse(req.Uomid)),
                        new SqlParameter("@type", req.type),
                        new SqlParameter("@trid", Int64.Parse(req.trid)),
                    };
            return obj.Return_ScalerValue("SavePickUpSKU", param);
        }
        public string FinalSave(PickUpFinalSave req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@oid", Int64.Parse(req.BatchID)),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId))
                    };
            return obj.Return_ScalerValue("UpdateRemQty", param);
        }
        public async Task<JsonElement> PickUpEditList(GetPickUpEditListRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@prodid", req.ProdId),
                        new SqlParameter("@bid", req.BatchId),
                        new SqlParameter("@uid", req.UserId)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getpickeditdata", param));
        }
        public string UpdatePickUp(UpdatePickUpRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@alcplnid", req.ID),
                        new SqlParameter("@newqty", req.NewQty),
                        new SqlParameter("@oldqty", req.OldQty),
                        new SqlParameter("@uid", req.UserId)
                    };
            return obj.Return_ScalerValue("updatePickupQty", param);
        }

        public async Task<JsonElement> SkuWisePickUpSKUList(SkuWisePickUpSKUList req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@ODID", req.BatchID),
                        new SqlParameter("@TRID", req.TrID),
                        new SqlParameter("@objectname", req.Object),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@custid",  Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid",  Convert.ToInt64(req.WarehouseId)),
                        new SqlParameter("@Skuid",  Convert.ToInt64(req.SkuId))
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("WMS_SP_SkuwisePickUpListNew", param));
        }

        public async Task<JsonElement> PickEditScanLog(PickEditScanLog req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@ODID", req.BatchID),
                        new SqlParameter("@tab", req.tab),
                        new SqlParameter("@pltid", Convert.ToInt64(req.PalletID)),
                        new SqlParameter("@prodid",  Convert.ToInt64(req.SKUID)),
                        new SqlParameter("@editseq",  Convert.ToInt64(req.editseq)),
                        new SqlParameter("@locationid",  Convert.ToInt64(req.locationid)),
                        new SqlParameter("@UserID",  Convert.ToInt64(req.UserID)),

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("WMS_SP_PickEditMobile", param));
        }

        public DataSet PickEditScanBarcode(PickEditScanBarcode req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Int64.Parse(req.BatchID)),
                        new SqlParameter("@obj", req.Object),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@compid", Int64.Parse(req.CompanyId)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@stglocid", Int64.Parse(req.StgLocationId)),
                        new SqlParameter("@locid", Int64.Parse(req.LocationId)),
                        new SqlParameter("@pltid", Int64.Parse(req.PalletId)),
                        new SqlParameter("@skuid", Int64.Parse(req.SkuId)),
                        new SqlParameter("@barcode", req.Barcode),
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
                        new SqlParameter("@getIsBarcode", req.getIsBarcode),
                         new SqlParameter("@IsEdit", req.IsEdit)
                    };
            return obj.Return_DataSet("SP_MobPickEditBarcodeSCan", param);
        }

        public async Task<JsonElement> PickEditLottableList(PickEditLottableList req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@bid", Convert.ToInt64(req.BatchID)),
                        new SqlParameter("@locid", Convert.ToInt64(req.LocationId)),
                        new SqlParameter("@pltid", Convert.ToInt64(req.PalletId)),
                        new SqlParameter("@skuid", Convert.ToInt64(req.SkuId)),
                         new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                          new SqlParameter("@lot", req.lottable)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("PickEditLottable", param));
        }

        public string SavePickUpEditDetails(SavePickUpEditDetails req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@pkQty", req.pkQty),
                        new SqlParameter("@skuID", req.skuID),
                        new SqlParameter("@TrID", req.TrID),
                        new SqlParameter("@oldTrID", req.oldTrID),
                        new SqlParameter("@batchId", req.batchId),
                        new SqlParameter("@CustId", req.CustId),
                        new SqlParameter("@IsSerial", req.IsSerial)
                    };
            return obj.Return_ScalerValue("SP_SavePickUpEditDetails", param);
        }

        public async Task<JsonElement> PickEditCompletedScanLog(PickEditCompletedScanLog req)
        {
            param = new SqlParameter[]
                   {
                    new SqlParameter("@ODID", req.BatchID),
                    new SqlParameter("@UserID", Convert.ToInt64(req.UserId)),
                    new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                    new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                    new SqlParameter("@obj",  req.Object)

                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_PickUpEditCompleted", param));
        }
    }

}

