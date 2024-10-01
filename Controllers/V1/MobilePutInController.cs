using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using WMSCOREAPI.Model.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;

namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilePutInController : ControllerBase
    {
        MobilePutInUtility obj = new MobilePutInUtility();
        SysException exe = new SysException();



        [HttpPost]
        [Route(APIRoute.PutIn.getmobPalletAndLoctionDetails)]
        public async Task<ResponceList> GetPalletLocationDetails(GetPalletLocationDetailsRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.GetPalletLocationDetails(req);


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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getmobPalletAndLoctionDetails, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.getmobSKUAndLoctionDetails)]
        public async Task<ResponceList> GetSkuLocationDetails(GetSkuLocationDetailsRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.GetSkuLocationDetails(req);


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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getmobSKUAndLoctionDetails, 0);
            }
            return Response;

        }


        [HttpPost]
        [Route(APIRoute.PutIn.getPutInScan)]
        public async Task<ResponceList> GetPutInLastScanRequest(GetPutInLastScanRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.GetPutInLastScan(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getPutInScan, 0);
            }
            return Response;

        }


        [HttpPost]
        [Route(APIRoute.PutIn.getPutAwayHistory)]
        public async Task<ResponceList> GetPutAwayHistory(GetPutAwayHistoryRequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.GetPutAwayHistory(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getPutAwayHistory, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.getSuggestedLocationBySKU)]
        public async Task<ResponceList> GetSuggestedLocationBySKU(GetSuggestedLocationBySKURequest req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.GetSuggestedLocationBySKU(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getSuggestedLocationBySKU, 0);
            }
            return Response;

        }
        [HttpPost]
        [Route(APIRoute.PutIn.getmobilePutinList)]
        public async Task<ResponceList> GetPutinmobileList(GetPutInSKUListRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await obj.GetPutInmobilelist(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getmobilePutinList, 0);
            }
            return Response;
        }


        [HttpPost]
        [Route(APIRoute.PutIn.ScanMobileBarcodeNOQC)]
        public async Task<ResponceList> ScanMobileBarcodeNOQC(ScanMobileBarcodeNOQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.ScanMobileBarcodeNOQC(req);


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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.ScanMobileBarcodeNOQC, 0);
            }
            return Response;

        }


        [HttpPost]
        [Route(APIRoute.PutIn.ScanLogMobileNOQC)]
        public async Task<ResponceList> ScanLogMobileNOQC(ScanLogMobileNOQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.ScanLogMobileNOQC(req);


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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.ScanLogMobileNOQC, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.GetLocListNoQc)]
        public async Task<ResponceList> GetLocListNoQc(GetLocListNoQc req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.GetLocListNoQc(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.GetLocListNoQc, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.PutInScanNoQcNoPallet)]
        public async Task<ResponceList> PutInScanNoQcNoPallet(PutInScanNoQcNoPallet req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.PutInScanNoQcNoPallet(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.PutInScanNoQcNoPallet, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.ScanMobBarcodeNoQcNoPallet)]
        public async Task<ResponceList> ScanMobBarcodeNoQcNoPallet(ScanMobBarcodeNoQcNoPallet req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {
                    JsonElement result = await obj.ScanMobBarcodeNoQcNoPallet(req);


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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.ScanMobBarcodeNoQcNoPallet, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.getPutInScanYes)]
        public async Task<ResponceList> getPutInScanYes(getPutInScanYes req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result =await obj.getPutInScanYes(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.getPutInScanYes, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.UpdateQtyPutinNoQC)]
        public async Task<ResponceList> UpdateQtyPutinNoQC(UpdateQtyPutinNoQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result =await obj.UpdateQtyPutinNoQC(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.UpdateQtyPutinNoQC, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.HistoryPutinNoQC)]
        public async Task<ResponceList> HistoryPutinNoQC(HistoryPutinNoQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.HistoryPutinNoQC(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.HistoryPutinNoQC, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.UpdateQtyPutinWithQC)]
        public async Task<ResponceList> UpdateQtyPutinWithQC(UpdateQtyPutinWithQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.UpdateQtyPutinWithQC(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.UpdateQtyPutinWithQC, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.HistoryPutinWithQC)]
        public async Task<ResponceList> HistoryPutinWithQC(HistoryPutinWithQC req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.HistoryPutinWithQC(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.HistoryPutinWithQC, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.PutAwayHistoryWithOutQcWithPlt)]
        public async Task<ResponceList> PutAwayHistoryWithOutQcWithPlt(PutAwayHistoryWithOutQcWithPlt req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result =await  obj.PutAwayHistoryWithOutQcWithPlt(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.PutAwayHistoryWithOutQcWithPlt, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.MobGetPutAwaySKUHistory)]
        public async Task<ResponceList> MobGetPutAwaySKUHistory(MobGetPutAwaySKUHistory req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.MobGetPutAwaySKUHistory(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.MobGetPutAwaySKUHistory, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.SKUHistoryNoQCYesPlt)]
        public async Task<ResponceList> SKUHistoryNoQCYesPlt(SKUHistoryNoQCYesPlt req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result =await obj.SKUHistoryNoQCYesPlt(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.SKUHistoryNoQCYesPlt, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.SKUHistoryWithQCNoPlt)]
        public async Task<ResponceList> SKUHistoryWithQCNoPlt(SKUHistoryWithQCNoPlt req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.SKUHistoryWithQCNoPlt(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.SKUHistoryWithQCNoPlt, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.MobPutAwayHistoryNoQCNoPlt)]
        public async Task<ResponceList> MobPutAwayHistoryNoQCNoPlt(MobPutAwayHistoryNoQCNoPlt req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.MobPutAwayHistoryNoQCNoPlt(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.MobPutAwayHistoryNoQCNoPlt, 0);
            }
            return Response;

        }

        [HttpPost]
        [Route(APIRoute.PutIn.SKUHistoryNoQCNoPlt)]
        public async Task<ResponceList> SKUHistoryNoQCNoPlt(SKUHistoryNoQCNoPlt req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.SKUHistoryNoQCNoPlt(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.SKUHistoryNoQCNoPlt, 0);
            }
            return Response;

        }


        [HttpPost]
        [Route(APIRoute.PutIn.ScanputinMobile)]
        public async Task<ResponceList> ScanputinMobile(ScanputinMobile req)
        {
            ResponceList Response = new ResponceList();

            try
            {

                if (req != null)
                {

                    JsonElement result = await obj.ScanputinMobile(req);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.PutIn.ScanputinMobile, 0);
            }
            return Response;

        }


    }
}
