using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Utility.V1;
using WMSCOREAPI.Models.V1.Request;
using WMSCOREAPI.Route;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/controller")]
    [ApiController]
    public class GRNController : ControllerBase
    {
        GRNActivity obj = new GRNActivity();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.GRN.GetGRNListDetails)]
        public async Task<ResponceList> GetGRNListDetails(GetGRNListDetails ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.GetGRNListDetails(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetGRNListDetails, Int64.Parse(ReqPara.userid));
            }
            return Response;
            }

        [HttpPost]
        [Route(APIRoute.GRN.GetDropDownOption)]
        public async Task<ResponceList>  DropDownOption(GetDropDownOption ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetDropDownOption(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), "APIRoute.GRN.GetDropDownOption", Int64.Parse(ReqPara.Obj));

            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.GRN.MobSaveGateDetails)]
        public  Responce MobSaveGateDetails(SaveGRNTransportDetails ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = obj.MobSaveGateDetails(ReqPara);
                    if (result == "success" || result == "found")
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.MobSaveGateDetails, Int64.Parse(ReqPara.UserId));
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.GRN.ScanPalletandSKUUDetails)]
        public async Task<ResponceList> GetGRNIDfromPalletSKU(GetGRNIDfromPalletSKURequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetGRNIDfromPalletSKU(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.ScanPalletandSKUUDetails, Int64.Parse(ReqPara.barcode));
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.GRN.GetGRNRecevingSKUScan)]
        public async Task<ResponceList> GetGRNRecevingSKUScan(GetGRNRecevingSKUScan ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =  await obj.GRNRecevingSKUScan(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetGRNRecevingSKUScan, Int64.Parse(ReqPara.grnID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.GetGRNScanLog)]
        public async Task<ResponceList> GetGRNRScanLog(GetGRNScanLog ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.GetGRNScanLog(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetGRNScanLog, Int64.Parse(ReqPara.userID));
            }
            return Response;
        }



        [HttpPost]
        [Route(APIRoute.GRN.GetReceivingHistory)]
        public async Task<ResponceList> ReceivingHistory(GetReceivingHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.GetReceivingHistory(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetReceivingHistory, Int64.Parse(ReqPara.Poid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.UpdateReceivingProdQuantity)]
        public async Task<ResponceList> UpdateReceivingQuantity(UpdateReceivingProdQuantity ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.UpdateReceivingQuantity(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetReceivingHistory, Int64.Parse(ReqPara.oid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.SaveGRN)]
        public async Task<ResponceList> SaveGRN(SaveGRN ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SaveGRN(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.GetReceivingHistory, Int64.Parse(ReqPara.oid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.BarcodeScanLott)]
        public async Task<ResponceList> BarcodeScanLott(BarcodeScanLott ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.BarcodeScanLott(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.BarcodeScanLott, Int64.Parse(ReqPara.barcode));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.UpdateSkuandpalletLott)]
        public async Task<ResponceList> UpdateSkuandpalletLott(UpdateSkuandpalletLott ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.UpdateSkuandpalletLott(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.UpdateSkuandpalletLott, Int64.Parse(ReqPara.OrderID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.UpdateGrnMobLott)]
        public async Task<ResponceList> UpdateGrnMobLott(UpdateGrnMobLott ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.UpdateGrnMobLott(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.UpdateGrnMobLott, Int64.Parse(ReqPara.oid));
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.GRN.forceUpdateGrnQuantity)]
        public async Task<ResponceList> forceUpdateGrnQuantity(forceUpdateGrnQuantity ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.forceUpdateGrnQuantity(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.forceUpdateGrnQuantity, Int64.Parse(ReqPara.oid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.UpdateGrnLottable)]
        public async Task<ResponceList> UpdateGrnLottable(UpdateGrnLottable ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.UpdateGrnLottable(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.UpdateGrnLottable, Int64.Parse(ReqPara.oid));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.SkuGrnHistory)]
        public async Task<ResponceList> SkuGrnHistory(SkuGrnHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.SkuGrnHistory(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.SkuGrnHistory, Int64.Parse(ReqPara.POID));
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.GRN.CheckGrnID)]
        public async Task<ResponceList> CheckGrnID(CheckGrnID ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.CheckGrnID(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.CheckGrnID, Int64.Parse(ReqPara.OID));
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.GRN.UpdateQtyGrnHistory)]
        public async Task<ResponceList> UpdateQtyGrnHistory(UpdateQtyGrnHistory ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =await obj.UpdateQtyGrnHistory(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.GRN.UpdateQtyGrnHistory, Int64.Parse(ReqPara.GRNID));
            }
            return Response;
        }
    }
}
