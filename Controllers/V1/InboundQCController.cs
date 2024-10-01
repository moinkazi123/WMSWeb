using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.InboundQC;
using static WMSCOREAPI.Model.V1.Request.InboundQC.SaveQCDetailRequest;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class InboundQCController : ControllerBase
    {
        InboundQCUtility obj = new InboundQCUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.InboundQC.MobQCList)]
        public async Task<ResponceList> GetQclist(QCDetailRequest ReqPara)
        {
            //long orderid = Convert.ToInt64(ReqPara.OrderId);           
            DataSet ds = new DataSet();
            DataSet dsuom = new DataSet();
            String jsonString = String.Empty;
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.QClist(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.MobQCList, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.MobgetQCID)]
        public async Task<ResponceList> getQCID(grnidreq req)
        {
            ResponceList Response = new ResponceList();

            try
            {
                if (req != null)
                {
                    JsonElement result =  await obj.MobgetQCID(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.MobgetQCID, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.MobGetQCHistory)]
        public async Task<ResponceList> GetGRNDetail(InboundQCHistroyRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result =  await obj.MobGetQCHistory(req);
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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.InboundQC.MobGetQCHistory", 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.InboundQC.InboundGetBarcodeScan)]
        public async Task<ResponceList> MobScaningPalletandProduct(QCScanBarcodeRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.MobScaningPalletandProduct(req);
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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.InboundQC.InboundGetBarcodeScan", 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.InboundQC.InboundQCBarcodeScan)]
        public async Task<ResponceList> InboundQCBarcodeScan(InboundQCBarcodeScan req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result =  await obj.InboundQCBarcodeScan(req);
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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.InboundQC.InboundQCBarcodeScan", 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.MobDeleteQCRecord)]
        public async Task<ResponceList> MobDeleteQCRecord(grnidreq req)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (req != null)
                {
                    JsonElement result = await obj.MobDeleteQCRecord(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.MobDeleteQCRecord, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.MobQCScanLog)]
        public async Task<ResponceList> MobQCScanLog(QCgetScanLogRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result =  await obj.MobQCScanLog(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.MobQCScanLog, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.GetQCReasoncode)]
        public async Task<ResponceList> GetQCReasoncode(QCReasonRequest req)
        {
            ResponceList Response = new ResponceList();
            try
            {

                if (req != null)
                {
                    JsonElement result =  await obj.GetQCReasoncode(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.GetQCReasoncode, 0);
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.InboundQC.InboundSaveMobQCDetail)]
        public async Task<Responce> InboundSaveMobQCDetail(SaveQCDetailRequest req)
        {

            Responce Response = new Responce();
            try
            {
                if (req != null)
                {
                    string result = obj.InboundSaveMobQCDetail(req);
                    if (result != "0")
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.InboundSaveMobQCDetail, 0);
            }
            return Response;
        }


        //[HttpPost("UpdateQCStatus")]
        //public Responce UpdateQC(UpdatQCStatus ReqPara)
        //{

        //    Responce Response = new Responce();
        //    try
        //    {
        //        if (ReqPara != null)
        //        {
        //            string result = obj.UpdateQCStatus(ReqPara);
        //            if (result == "success")
        //            {
        //                Response = ResponceResult.SuccessResponse(result);
        //                string rek = obj.ReciveNotification(ReqPara);
        //            }
        //            else
        //            {
        //                Response = ResponceResult.ValidateResponse(result);
        //            }
        //        }
        //        else
        //        {
        //            Response = ResponceResult.ErrorResponse("Record Not Save..!");
        //            return Response;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Response = ResponceResult.ErrorResponse(ex.Message.ToString());
        //        exe.ErrorLog(ex.Message.ToString(), "APIRoute.InboundQC.UpdateQCStatus", 0);
        //    }
        //    return Response;
        //}

        [HttpPost]
        [Route(APIRoute.InboundQC.SavefinalQCDetail)]
        public async Task<ResponceList> SavefinalQC(SaveFinalQCStatus ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =  await obj.UpdateQcMobile(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.InboundQC.SavefinalQCDetail", Int64.Parse(ReqPara.GRNID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.GetQCsaveDetailScan)]
        public async Task<ResponceList> GetQCsaveDetailScan(GetQCsaveDetailScanlog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetQCsaveDetailScan(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.GetQCsaveDetailScan, Int64.Parse(ReqPara.grnID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.InboundQC.MobGetQCSKUHistory)]
        public async Task<ResponceList> MobGetQCSKUHistory(MobGetQCSKUHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.MobGetQCSKUHistory(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.InboundQC.MobGetQCSKUHistory, Int64.Parse(ReqPara.OrderId));
            }
            return Response;
        }
    }
}
