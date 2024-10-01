using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data;
using WMSCOREAPI.Models.V1.Request;
using static WMSCOREAPI.Model.V1.Request.InboundQC;
using System.Text.Json;
using static WMSCOREAPI.Model.V1.Request.InboundQC.SaveQCDetailRequest;
using Microsoft.Extensions.Configuration;


namespace WMSCOREAPI.Utility.V1
{
    public class InboundQCUtility
    {
        SqlParameter[] param;
        DBActivity obj;

        public InboundQCUtility()
        {
            obj = new DBActivity();
        }
        public async Task<JsonElement> QClist(QCDetailRequest req)
        {
            param = new SqlParameter[]
                {
                       // new SqlParameter("@POID", Convert.ToInt64(orderid)),
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                        new SqlParameter("@userid", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@skey", req.skey)

                };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_Mob_InboundQCList", param));

        }

        //internal JsonElement QClist(long orderid)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<JsonElement> QCHead(QCHeadRequest req)
        {

            param = new SqlParameter[]
                   {
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                        new SqlParameter("@uid", req.UserId),
                        new SqlParameter("@grnID", Convert.ToInt64(req.grnID)),
                        new SqlParameter("@QCID", Convert.ToInt64(req.qcID)),
                        new SqlParameter("@ordertype", req.OrderType)
                   };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetQCHead", param));

        }
        public async Task<JsonElement> MobgetQCID(grnidreq req)
        {

            param = new SqlParameter[]
                   {
                        new SqlParameter("@grnID", Convert.ToInt64(req.grnid))

                   };

            //return obj.ConvertDataSetToJObject(obj.Return_DataSet("getQCbyGrn", param));
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getMobQCbyGrn", param));

        }
        public async Task<JsonElement> MobGetQCHistory(InboundQCHistroyRequest req)
        {

            param = new SqlParameter[]
                   {
                        //new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        //new SqlParameter("@wrid", Convert.ToInt64(req.WarehouseId)),
                        //new SqlParameter("@uid", req.UserId),
                        //new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),                        
                        //new SqlParameter("@ordertype", req.ordertype)


                          new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                       new SqlParameter("@orderid", Convert.ToInt64(req.OrderId))
                   };

            //return obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetQCDetails", param));
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetInboudQCHistory", param));

        }
        public async Task<JsonElement> MobDeleteQCRecord(grnidreq req)
        {

            param = new SqlParameter[]
                   {
                        new SqlParameter("@grnID", Convert.ToInt64(req.grnid))

                   };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getMobDeleteQCRecord", param));

        }

        public async Task<JsonElement> MobScaningPalletandProduct(QCScanBarcodeRequest req)
        {
            param = new SqlParameter[]
                {
                       new SqlParameter("@barcode",req.Barcode),
                        new SqlParameter("@companyID",req.CompanyID),
                        new SqlParameter("@custid",req.CustomerId),
                        new SqlParameter("@userid",req.UserId),
                        new SqlParameter("@grnid",req.GRNID),
                        new SqlParameter("@poid",req.OrderId)
                };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_ScanPalletandProduct", param));


        }

        public async Task<JsonElement> InboundQCBarcodeScan(InboundQCBarcodeScan req)
        {
            param = new SqlParameter[]
                {
                       new SqlParameter("@barcode",req.barcode),
                        new SqlParameter("@OrderID", req.orderID),
                        new SqlParameter("@customerID",req.customerID),
                        new SqlParameter("@UserID",req.userID),
                        new SqlParameter("@PalletID",req.PalletID),
                };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_InwMobQcBarcodeScan", param));


        }

        public async Task<JsonElement> MobQCScanLog(QCgetScanLogRequest req)
        {

            param = new SqlParameter[]
                   {
                        new SqlParameter("@Orderid", Convert.ToInt64(req.oid)),
                        new SqlParameter("@grnID", Convert.ToInt64(req.GRNID)),
                        new SqlParameter("@ProdID", Convert.ToInt64(req.skuid)),
                        new SqlParameter("@palletID", Convert.ToInt64(req.PalletID)),
                        new SqlParameter("@CompanyID", Convert.ToInt64(req.CompanyID)),
                        new SqlParameter("@customerID", Convert.ToInt64(req.CustId)),
                        new SqlParameter("@UserID", Convert.ToInt64(req.UserId)),
                        new SqlParameter("@warehouseID", Convert.ToInt64(req.warehouseid)),
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

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("getMobQCScanLog", param));

        }
        //public JObject InboundSaveMobQCDetail(SaveQCDetailRequest req)
        public string InboundSaveMobQCDetail(SaveQCDetailRequest req)
        {
            param = new SqlParameter[]
                {
                        new SqlParameter("@grnid",req.grnid),
                        new SqlParameter("@poid",req.poid),
                        new SqlParameter("@acceptqty",req.acceptqty),
                        new SqlParameter("@rejectedQty",req.rejectedQty),
                        new SqlParameter("@prodID",req.prodID),
                        new SqlParameter("@palletId",req.palletId),
                        new SqlParameter("@UserId",req.UserId),
                        new SqlParameter("@CustomerId",req.CustomerId),
                        new SqlParameter("@companyID",req.companyID),
                        new SqlParameter("@ObjectName",req.ObjectName),
                        new SqlParameter("@reasonID",req.reasonID),
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
            //return obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_SaveMobQCDetail", param));
            return obj.Return_ScalerValue("SP_SaveMobQCDetail", param);

        }

        public DataTable getLottables(long prodid)
        {
            DataTable dt = new DataTable();
            try
            {
                param = new SqlParameter[]
                   {
                        new SqlParameter("@ProdID", prodid)

                   };
                return obj.exeSP_DT_adapter("sp_lottables", param);

            }
            catch (Exception ex) { }
            finally { }
            return dt;
        }
        public async Task<JsonElement> GetQCReasoncode(QCReasonRequest req)
        {

            param = new SqlParameter[]
                   {
                        new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@compid", Convert.ToInt64(req.CompanyID)),
                   };

            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_GetQCMobReasonCode", param));

        }
        public string UpdateQCStatus(UpdatQCStatus req)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@OrderID", Convert.ToInt64(req.poID)),
                         new SqlParameter("@grnID", Convert.ToInt64(req.GRNID))


                    };
            return obj.Return_ScalerValue("sp_UpdateQCStatus", param);

        }
        public async Task<JsonElement> UpdateQcMobile(SaveFinalQCStatus req)
        {
            param = new SqlParameter[]
                    {

                        new SqlParameter("@OrderID", req.poID),
                        new SqlParameter("@grnID", req.GRNID),
                         new SqlParameter("@UID", req.UID),
                        new SqlParameter("@CustID", req.CustID)
                    };
            //return obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_SaveFinalQC", param));
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("sp_UpdateQCStatusMobile", param));
        }
        public async Task<JsonElement> GetQCsaveDetailScan(GetQCsaveDetailScanlog req)
        {
            param = new SqlParameter[]
                    {


                        new SqlParameter("@grnID", req.grnID)
                    };
            return await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_getInQCScannedProdList", param));
        }
        //public string ReciveNotification(UpdatQCStatus request)
        //{
        //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
        //    string result = "";
        //    ReciveNotification dn = new ReciveNotification();
        //    try
        //    {
        //        // Token
        //        string username = "C_BALAJI";
        //        string password = "Wittymoon502@";
        //        var clientcode = new RestClient("https://fiori-dev.da.com.bn/sap/opu/odata/sap/ZIWMS_GOOD_RECIEPT_SRV/GoodRecieptHeaderSet?sap-client=520");
        //        var reqcode = new RestRequest(Method.GET);
        //        reqcode.AddHeader("Content-Type", "application/json; charset=UTF-8");
        //        reqcode.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password)));
        //        reqcode.AddHeader("X-CSRF-Token", "fetch");
        //        IRestResponse rescode = clientcode.Execute(reqcode);
        //        string name = rescode.Headers[3].Name.ToString();
        //        string value = rescode.Headers[3].Value.ToString();

        //        dn = ReqJSON(request);
        //        string json = JsonConvert.SerializeObject(dn);

        //        // Dispatch Notification
        //        var client = new RestClient("https://fiori-dev.da.com.bn/sap/opu/odata/sap/ZIWMS_GOOD_RECIEPT_SRV/GoodRecieptHeaderSet?sap-client=520");
        //        var req = new RestRequest(Method.POST);
        //        req.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(username + ":" + password)));
        //        req.AddHeader(name, value);
        //        foreach (var ck in rescode.Cookies)
        //        {
        //            req.AddCookie(ck.Name, ck.Value);
        //        }
        //        req.AddHeader("Accept", "application/json");
        //        req.AddParameter("application/json; charset=UTF-8", json, ParameterType.RequestBody);
        //        IRestResponse res = client.Execute(req);
        //        //DataSet myDataSet = JsonConvert.DeserializeObject<DataSet>(res.Content.ToString());
        //        // res.Content=
        //        if (res.StatusDescription == "Created")
        //        {
        //            result = "success";
        //        }
        //        else
        //        {
        //            result = "fail";
        //        }

        //        JObject joResponse = JObject.Parse(res.Content);
        //        JObject ojObject = (JObject)joResponse["d"];
        //        string materialdoc = ojObject["MaterialDoc"].ToString();
        //        string fiscalyear = ojObject["Fiscalyear"].ToString();
        //        //string typesds = joResponse["Type"].ToString();
        //        string docyear = materialdoc + fiscalyear;
        //        long poid = Convert.ToInt64(request.poID);
        //        long grnID = Convert.ToInt64(request.GRNID);
        //        if (materialdoc != "")
        //        {
        //            insertReciveLog(materialdoc, fiscalyear, "", "", "", docyear, poid, grnID, result);
        //        }
        //        else
        //        {
        //            JObject jsreturn = (JObject)ojObject["ReturnMessageSet"];
        //            // JObject obj = JsonNode.Parse(json).AsObject();
        //            JArray jsonArray = (JArray)jsreturn["results"];
        //            // JObject  = (JObject)joResponse["d"];
        //            string type = jsonArray[0]["Type"].ToString();
        //            string Number = jsonArray[0]["Number"].ToString();
        //            string Message = jsonArray[0]["Message"].ToString();
        //            string ID = jsonArray[0]["ID"].ToString();
        //            insertReciveLog(materialdoc, fiscalyear, type, Number, Message, docyear, poid, grnID, result);
        //        }



        //        //JArray array = (JArray)ojObject["SaleDocumentNo"];
        //        // int id = Convert.ToInt32(array[0].toString());


        //    }
        //    catch (Exception ex)
        //    {
        //        insertReciveLog("0", "0", "0", "0", ex.Message, "0", 0, 0, "Failed");
        //        result = ex.Message;
        //    }
        //    return result;
        //}
        public string insertReciveLog(string materialdoc, string fiscalyear, string type, string number, string message, string docyear, long poid, long grnID, string result)
        {

            param = new SqlParameter[]
                    {
                        new SqlParameter("@MaterialDoc",materialdoc),
                         new SqlParameter("@FiscalYear",fiscalyear),
                         new SqlParameter("@type",type),
                         new SqlParameter("@Number",number),
                         new SqlParameter("@message",message),
                         new SqlParameter("@MaterialYear",docyear),
                         new SqlParameter("@POID",poid),
                         new SqlParameter("@GrnID",grnID),
                         new SqlParameter("@APIStatus",result),

                    };
            return obj.Return_ScalerValue("sp_insertRecivelog", param);

        }
        public ReciveNotification ReqJSON(UpdatQCStatus req)
        {
            ReciveNotification main = new ReciveNotification();
            DataSet ds = new DataSet();
            try
            {
                param = new SqlParameter[]
                    {
                        new SqlParameter("@OrderID", req.poID),
                        new SqlParameter("@grnID", req.GRNID),
                    };
                ds = obj.Return_DataSet("sp_GetReciptDetailsData", param);

                main.OrderReferenceNO = ds.Tables[0].Rows[0]["OrderReferenceNO"].ToString();
                main.MaterialDoc = ds.Tables[0].Rows[0]["MaterialDoc"].ToString();
                main.RecieptDate = ds.Tables[0].Rows[0]["RecieptDate"].ToString();
                main.Fiscalyear = ds.Tables[0].Rows[0]["Fiscalyear"].ToString();
                main.DocDate = ds.Tables[0].Rows[0]["DocDate"].ToString();
                //GoodRecieptItemSet


                List<GoodRecieptItemSet> oislst = new List<GoodRecieptItemSet>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    GoodRecieptItemSet ois = new GoodRecieptItemSet();
                    ois.MovementIndicator = ds.Tables[0].Rows[i]["MovementIndicator"].ToString();
                    ois.OrderReferenceNO = ds.Tables[0].Rows[i]["OrderReferenceNO"].ToString();
                    ois.ItemNo = ds.Tables[0].Rows[i]["ItemNo"].ToString();
                    ois.CustomerNo = ds.Tables[0].Rows[i]["CustomerNo"].ToString();
                    ois.SKUcode = ds.Tables[0].Rows[i]["SKUcode"].ToString();
                    ois.MoveType = ds.Tables[0].Rows[i]["MoveType"].ToString();
                    ois.Plant = ds.Tables[0].Rows[i]["Plant"].ToString();
                    ois.WareHouseCode = ds.Tables[0].Rows[i]["WareHouseCode"].ToString();
                    ois.Quantity = ds.Tables[0].Rows[i]["Quantity"].ToString();
                    ois.Uom = ds.Tables[0].Rows[i]["Uom"].ToString();
                    oislst.Add(ois);
                }
                main.GoodRecieptItemSet = oislst;
                //ReturnMessageSet
                List<ReturnMessageSet> rmslst = new List<ReturnMessageSet>();
                main.ReturnMessageSet = rmslst;

            }
            catch (Exception ex)
            {
            }
            return main;
        }

        public async Task<JsonElement> MobGetQCSKUHistory(MobGetQCSKUHistory req)
        {

            param = new SqlParameter[]
                   {
                          new SqlParameter("@custid", Convert.ToInt64(req.CustomerId)),
                        new SqlParameter("@uid", Convert.ToInt64(req.UserId)),
                       new SqlParameter("@orderid", Convert.ToInt64(req.OrderId)),
                       new SqlParameter("@Skuid", Convert.ToInt64(req.Skuid)),
             };


            return  await obj.ConvertDataSetToJObject(obj.Return_DataSet("SP_MobInboudQCHistorySKU", param));

        }

    }
}
