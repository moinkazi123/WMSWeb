using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Models.V1.Request.PickUp;


namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/controller")]
    [ApiController]
    public class PickupController : ControllerBase
    {
        SysException exe = new SysException();
        PickUpUtility obj = new PickUpUtility();

        [HttpPost]
        [Route(APIRoute.PickUp.GetPickUpList)]
        public async Task<ResponceList> GetParameterList(GetPickUpListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickUpList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.GetPickUpList, ReqPara.uid);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.GetPickUpListVwOrder)]
        public async Task<ResponceList> GetPickUpListVwOrder(GetPickUpListVwOrderRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetPickUpListVwOrder(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.GetPickUpListVwOrder, ReqPara.batchId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.GetPickUpSKUList)]
        public async Task<ResponceList> GetPickUpSKUList(GetPickUpSKUListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickUpSKUList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.GetPickUpSKUList, Convert.ToInt64(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.GetPickUpScanLog)]
        public async Task<ResponceList> GetPickUpScanLog(GetPickUpScanLogRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickUpScanLog(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.GetPickUpScanLog, Convert.ToInt64(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.BarcodeScan)]
        public async Task<BarcodeScan> ScanBarcode(PickUpBarcodeScanRequest ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "", id = "", trid = "", code = "", result = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds =await obj.ScanBarcode(ReqPara);
                    type = ds.Tables[0].Rows[0]["scanType"].ToString();
                    id = ds.Tables[0].Rows[0]["ID"].ToString();
                    trid = ds.Tables[0].Rows[0]["trid"].ToString();
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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.PickUp.BarcodeScan", Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route("LottableList")]
        public async Task<ResponceList> PickUpLottable(PickUpLottableRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickUpSKULottable(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.LottableList, long.Parse(ReqPara.UserId));
            }
            return Response;
        }

        //[HttpPost]
        //[Route(APIRoute.PickUp.SaveSKU)]
        //public async Task<ResponceList> PickUpSKUSave(PickUpSKUSaveRequest ReqPara)
        //{
        //    Responce Response = new Responce();
        //    try
        //    {
        //        if (ReqPara != null)
        //        {
        //            string result = obj.PickUpSKUSave(ReqPara);
        //            if (result == "success")
        //            {
        //                Response = ResponceResult.SuccessResponse(result);
        //            }
        //            else
        //            {
        //                Response = ResponceResult.ValidateResponse(result);
        //            }
        //        }
        //        else
        //        {
        //            Response = ResponceResult.ErrorResponse("Record Not Save..!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response = ResponceResult.ErrorResponse(ex.Message.ToString());
        //        exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.SaveSKU, Int64.Parse(ReqPara.UserId));
        //    }
        //    return Response;
        //}

        [HttpPost]
        [Route(APIRoute.PickUp.FinalSave)]
        public async Task< Responce> FinalSave(PickUpFinalSave ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.FinalSave(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.FinalSave, Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.GetPickUpEditList)]
        public async Task<ResponceList> PickUpEditList(GetPickUpEditListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickUpEditList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.GetPickUpEditList, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.UpdatePickUp)]
        public async Task<Responce> UpdatePickUp(UpdatePickUpRequest ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.UpdatePickUp(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.UpdatePickUp, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.SkuWisePickUpSKUList)]
        public async Task<ResponceList> SkuWisePickUpSKUList(SkuWisePickUpSKUList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SkuWisePickUpSKUList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.SkuWisePickUpSKUList, Convert.ToInt64(ReqPara.UserId));
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.PickUp.PickEditScanLog)]
        public async Task<ResponceList> PickEditScanLog(PickEditScanLog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickEditScanLog(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.PickEditScanLog, Convert.ToInt64(ReqPara.UserID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.PickEditScanBarcode)]
        public async Task<BarcodeScan> PickEditScanBarcode(PickEditScanBarcode ReqPara)
        {
            BarcodeScan Response = new BarcodeScan();
            string type = "", id = "", code = "", result = "";
            try
            {
                if (ReqPara != null)
                {
                    DataSet ds = obj.PickEditScanBarcode(ReqPara);
                    type = ds.Tables[0].Rows[0]["scanType"].ToString();
                    id = ds.Tables[0].Rows[0]["ID"].ToString();
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.PickEditScanBarcode, Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.PickEditLottableList)]
        public async Task<ResponceList> PickEditLottableList(PickEditLottableList ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickEditLottableList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.PickEditLottableList, long.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.SavePickUpEditDetails)]
        public async Task<Responce> SavePickUpEditDetails(SavePickUpEditDetails ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.SavePickUpEditDetails(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(),APIRoute.PickUp.SavePickUpEditDetails, ReqPara.CustId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.PickUp.PickEditCompletedScanLog)]
        public async Task<ResponceList> PickEditCompletedScanLog(PickEditCompletedScanLog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.PickEditCompletedScanLog(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PickUp.PickEditCompletedScanLog, Convert.ToInt64(ReqPara.UserId));
            }
            return Response;
        }
    }

}

