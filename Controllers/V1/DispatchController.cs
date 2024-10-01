using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;
using static WMSCOREAPI.Model.V1.Request.Dispatch;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchController : ControllerBase
    {
        SysException exe = new SysException();
        DispatchUtility obj = new DispatchUtility();

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatchList)]
        public async Task<ResponceList> GetDispatchList(GetDispatchListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDispatchList(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatchList, ReqPara.uid);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatchVwOrder)]
        public async Task<ResponceList> GetDispatchVwOrder(GetDispatchOrderViewRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDispatchVwOrder(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatchVwOrder, ReqPara.DispatchId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatDetail)]
        public async Task<ResponceList> GetDispatDetail(GetDispatchDetailRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDispatchDetails(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatDetail, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.CarrierList)]
        public async Task<ResponceList> GetCarrierDetail(CarrierListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.CarrierDetail(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.CarrierList, long.Parse(ReqPara.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.saveDispatchbyso)]
        public Responce SaveDetails(SaveDispatchBySORequest req)
        {
            Responce Response = new Responce();
            try
            {
                if (req != null)
                {
                    string result = obj.SaveDispatchBySO(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.saveDispatchbyso, long.Parse(req.UserId));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.UpdateQty)]
        public Responce UpdateQty(UpdateQtyRequest ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.UpdateQty(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.UpdateQty, ReqPara.UserId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatchmobScan)]
        public async Task<ResponceList> GetDispatchmobScan(GetDispatchmobScan ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.GetDispatchmobScan(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatchmobScan, ReqPara.BatchId);
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.Dispatch.Dispatchmobvalidate)]
        public async Task<ResponceList> Dispatchmobvalidate(Dispatchmobvalidate ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.Dispatchmobvalidate(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.Dispatchmobvalidate, ReqPara.BatchId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatchmobSkuScan)]
        public async Task<ResponceList> GetDispatchmobSkuScan(GetDispatchmobSkuScan ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDispatchmobSkuScan(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatchmobSkuScan, ReqPara.BatchId);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.Dispatch.GetDispatchmobSkuSave)]
        public async Task<ResponceList> GetDispatchmobSkuSave(GetDispatchmobSkuSave ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDispatchmobSkuSave(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.Dispatch.GetDispatchmobSkuSave, ReqPara.BatchId);
            }
            return Response;
        }

    }
}
