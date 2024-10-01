using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.OutboundQC;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutboundQCController : ControllerBase
    {
        OutboundQCUtility obj = new OutboundQCUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondQCList)]
        public async Task<ResponceList> OutbondQCList(GetQCOutListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.OutbondQCList(ReqPara);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.OutboundQC.OutbondQCList, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.BarcodeScan)]
        public async Task<BarcodeScan> ScanBarcode(OutboundQCScanBarcodeRequest ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "", id = "", trid = "", code = "", result = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds = await obj.OutbondGetBarcodeScan(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.BarcodeScan, Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondGetQCLottableList)]
        public async Task<ResponceList> OutbondMobQCLottableList(QCgetLottableListRequest req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.OutbondMobQCLottableList(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.OutboundQC.OutbondGetQCLottableList, Int64.Parse(req.PickUpID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondMobQCScanLog)]
        public async Task<ResponceList> OutbondMobQCScanLog(QCgetOutbondScanLogRequest req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.OutbondMobQCScanLog(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.OutboundQC.OutbondMobQCScanLog", 0);
            }
            return Response;
        }
        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondMobQCHistory)]
        public async Task<ResponceList> OutbondMobQCHistory(QCHistroyRequest req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.OutbondMobQCHistory(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.OutboundQC.OutbondMobQCHistory", Int64.Parse(req.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondMobQCSaveDetails)]
        public async Task<Responce> OutbondMobQCSaveDetails(SaveOutboundQCDetailRequest req)
        {
            Responce Response = new Responce();
            try
            {
                if (req != null)
                {
                    string result = obj.OutbondMobQCSaveDetails(req);
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
                    return Response;
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(),APIRoute.OutboundQC.OutbondMobQCSaveDetails, req.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondMobQCSaveScanLog)]
        public async Task<ResponceList> OutbondMobQCSaveScanLog(GetQCScannedProdList req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.MobQCSvaeScanLog(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.OutboundQC.OutbondMobQCSaveScanLog, Int64.Parse(req.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.OutbondMobQCUpdateStatus)]
        public async Task<Responce> UpdatQCOutboundStatus(UpdatQCOutboundStatus Req)
        {
            Responce Response = new Responce();
            try
            {
                if (Req != null)
                {
                    string result = obj.UpdateQCStatus(Req);
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
                    return Response;
                }
            }
            catch (System.Exception ex)
            {
                Response = ResponceResult.ErrorResponse(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(),APIRoute.OutboundQC.OutbondMobQCUpdateStatus, Int64.Parse(Req.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.GetQCSOList)]
        public async Task<ResponceList> QCSOListRequest(GetQCSOListRequest req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.QCSOListRequest(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.OutboundQC.GetQCSOList", Int64.Parse(req.OrderId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.OutboundQC.SkuwiseOutbondMobQCHistory)]
        public async Task<ResponceList> SkuwiseOutbondMobQCHistory(SkuwiseOutbondMobQCHistory req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.SkuwiseOutbondMobQCHistory(req);
                    Response = ResponceResult.SuccessResponseList(result);
                }
                else
                {
                    Response = ResponceResult.ErrorResponseList("No record found..!");
                }
            }
            catch (Exception ex)
            {
                Response = ResponceResult.ErrorResponseList(ex.Message.ToString());
                exe.ErrorLog(ex.Message.ToString(), APIRoute.OutboundQC.SkuwiseOutbondMobQCHistory, Int64.Parse(req.UserId));
            }
            return Response;
        }
    }
}
