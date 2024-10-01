using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;
using WMSCOREAPI.Models.V1.Request;

namespace WMSCOREAPI.Utility.V1
{
    public class CommFunAPIUtility
    {
        SqlParameter[] param;
        DBActivity obj;

        public CommFunAPIUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> Get_PalletList(ReqPalletList reqPara)
        {

            param = new SqlParameter[]
                    {new SqlParameter("@companyId",Convert.ToInt64(reqPara.CompanyId)),
                    new SqlParameter("@userId",Convert.ToInt64(reqPara.userId)),
                    new SqlParameter("@whId",Convert.ToInt64(reqPara.whId)),
                    new SqlParameter("@custId",Convert.ToInt64(reqPara.custId)),
                    new SqlParameter("@PalletName",reqPara.PalletName),
                    new SqlParameter("@obj",reqPara.obj),
                    };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("Get_PalletList", param));

        }
        public async Task<JsonElement> getLottablevalue(lottablereq req)
        {
            param = new SqlParameter[]
                   {new SqlParameter("@ProdID",req.prodID),
                   new SqlParameter("@OrderID",req.orderID),
                   new SqlParameter("@Obj",req.obj)
                   };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_getvaluelot", param));

        }
        public async Task<JsonElement> SKUSuggestionList(SKUSuggestionRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@orderid", Int64.Parse(req.OrderId)),
                         new SqlParameter("@obj", req.skuobject),
                        new SqlParameter("@skey", req.skey),
                        new SqlParameter("@orderfor", req.orderobj),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetSKUSuggestion", param));
        }
        public async Task<JsonElement> POSKUUOMList(SKUUOMRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@SkuId", Int64.Parse(req.SkuId))
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetPOSKUUOM", param));
        }
        public async Task<JsonElement> ScanSuggestionList(ScanSuggestionRequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@custid", Int64.Parse(req.CustomerId)),
                        new SqlParameter("@wrid", Int64.Parse(req.WarehouseId)),
                        new SqlParameter("@uid", Int64.Parse(req.UserId)),
                        new SqlParameter("@orderid", Int64.Parse(req.OrderId)),
                         new SqlParameter("@obj", req.obj),
                        new SqlParameter("@currentpg", req.currentpg),
                        new SqlParameter("@recordlmt", req.recordlmt)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetScanSuggestion", param));
        }
        public async Task<JsonElement> Scaninbound(scanrequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@value",req.value),
                        new SqlParameter("@companyID",req.companyID),
                        new SqlParameter("@obj",req.obj),
                        new SqlParameter("@OrderID",req.orderID)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_chkinboundscanvalue", param));
        }
        public async Task<JsonElement> userListList(userlist req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@companyID", Int64.Parse(req.companyID))

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_AssingUserList", param));
        }

        public string saveAssingment(assinguserRequest req)
        {

            param = new SqlParameter[]
                    {

                        new SqlParameter("@type",req.type),
                        new SqlParameter("@userID",Convert.ToInt64(req.UserID)),
                        new SqlParameter("@assingmentdate", req.date),
                        new SqlParameter("@time",req.time),
                        new SqlParameter("@companyID",Convert.ToInt64(req.companyID)),
                        new SqlParameter("@customerID",Convert.ToInt64(req.customerID)),
                        new SqlParameter("@createdby",Convert.ToInt64(req.createdBy))
                    };
            return obj.Return_ScalerValue("sp_saveassingment", param);
        }

        public async Task<JsonElement>  LoginList(Login req)
        {
            param = new SqlParameter[]
                    {

                        //new SqlParameter("@usrId", req.usrId),
                        new SqlParameter("@usrname", req.Username),
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UserDetail", param));
        }
        public async Task<JsonElement> ScaninboundMobile(scanmobilerequest req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode",req.barcode),
                        new SqlParameter("@customerID",req.customerID),
                        new SqlParameter("@UserID",req.userID),
                        new SqlParameter("@OrderID",req.orderID),
                        new SqlParameter("@obj",req.obj),
                        new SqlParameter("@ispallet",req.ispallet)

                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_chkMobileinwarBarcode", param));
        }

        public async Task<JsonElement> ScanMobileSerialBarcode(ScanMobileSerialBarcode req)
        {
            param = new SqlParameter[]
                    {
                        new SqlParameter("@Barcode",req.Barcode),
                        new SqlParameter("@customerID",req.CustID),
                        new SqlParameter("@UID",req.UserID),
                        new SqlParameter("@WHID",req.WHID)


                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_Mob_Serialised", param));
        }

    }
}
