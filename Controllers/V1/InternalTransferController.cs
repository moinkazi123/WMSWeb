using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
//using static WMSCOREAPI.Model.V1.Request.InboundQC.SaveQCDetailRequest;
using System.Data;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Utility.V1;
using WMSCOREAPI.Model.V1.Request;
using System.Text.Json;
using WMSCOREAPI.Route;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternalTransferController : ControllerBase
    {
        InternalTransferUtility obj = new InternalTransferUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.InternalTransfer.UOMLottable)]
        public async Task<ResponceList> UOMLOttablelist(UOMLottablelistrequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.UOMLottablelist(ReqPara);

                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InternalTransfer.UOMLottable, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InternalTransfer.ScanBarcode)]
        public async Task<BarcodeScan> ScanBarcode(ScanBarcoderequest ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "";
            string id = "";
            string trid = "";
            string code = "";
            string result = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds = await obj.ScanBarcoder(ReqPara);
                    type = ds.Tables[0].Rows[0]["scanType"].ToString();
                    id = ds.Tables[0].Rows[0]["ID"].ToString();
                    trid = ds.Tables[0].Rows[0]["ID"].ToString();
                    code = ds.Tables[0].Rows[0]["Value"].ToString();
                    result = ds.Tables[0].Rows[0]["Result"].ToString();
                    if (result == "success")
                    {
                        Response = ResponceResult.BarcodeScanSuccess(type, id, code);
                    }
                    else
                    {
                        Response = ResponceResult.BarcodeScanFailed(type, id, code, result);
                    }
                }
                else
                {
                    Response = ResponceResult.BarcodeScanFailed(type, id, code, "Scan Fail!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.BarcodeScanFailed(type, id, code, ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InternalTransfer.ScanBarcode, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InternalTransfer.SaveInternalTransfer)]
        public async Task<Responce> SaveTransfer(SaveInternalTransferDetailRequest ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.SaveInternalTransfer(ReqPara);
                    if (result == "success")
                    {
                        Response = ResponceResult.SuccessResponse(result);
                    }
                    else
                    {
                        Response = ResponceResult.ValidateResponse(result);
                    }
                }
                else
                {
                    Response = ResponceResult.ErrorResponse("Record Not Save..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InternalTransfer.SaveInternalTransfer, Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InternalTransfer.PalletTransfer)]
        public async Task<BarcodeScan> PalletTransfer(PalletTransferRequest ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "";
            string id = "";
            string trid = "";
            string code = "";
            string result = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds = await obj.PalletTransfer(ReqPara);
                    type = ds.Tables[0].Rows[0]["scanType"].ToString();
                    id = ds.Tables[0].Rows[0]["ID"].ToString();
                    trid = ds.Tables[0].Rows[0]["ID"].ToString();
                    code = ds.Tables[0].Rows[0]["Value"].ToString();
                    result = ds.Tables[0].Rows[0]["Result"].ToString();
                    if (result == "success")
                    {
                        Response = ResponceResult.BarcodeScanSuccess(type, id, code);
                    }
                    else
                    {
                        Response = ResponceResult.BarcodeScanFailed(type, id, code, result);
                    }
                }
                else
                {
                    Response = ResponceResult.BarcodeScanFailed(type, id, code, "Scan Fail!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.BarcodeScanFailed(type, id, code, ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InternalTransfer.PalletTransfer, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InternalTransfer.CheckIsPallet)]
        public async Task<ResponceList> CheckIsPallet(CheckIsPalletRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try

            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.CheckIsPallet(ReqPara);

                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                //exe.ErrorLog(ex.Message.ToString(), APIRoute.InternalTransfer.UOMLottable, Int64.Parse(ReqPara.CustomerID));
            }
            return Response;

        }
    }
}
