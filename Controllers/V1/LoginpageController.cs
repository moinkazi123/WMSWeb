using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using WMSCOREAPI.Models.V1.Request;
using WMSCOREAPI.Models.V1.Responce;
using WMSCOREAPI.Route;
using WMSCOREAPI.Utility.V1;


namespace WMSCOREAPI.Controllers.V1
{
    [Route("api/controller")]
    [ApiController]
    public class LoginpageController : ControllerBase
    {
        loginpageUtility Obj = new loginpageUtility();
        TokenAuthUtility tokenObj = new TokenAuthUtility();
        SysException exe = new SysException();

        [HttpPost]
        [Route(APIRoute.loginpage.GetLogin)]
        public async Task<ResponceList> LoginDetailList(GetloginRequest ReqPara)
        {
            ResponceList Response = new ResponceList();

            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await Obj.Getlogin(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.GetLogin, 0);
            }
            return Response;
        }

        [HttpPost]
        [Route(APIRoute.loginpage.LogInWithToken)]
        public async Task<ResponceList> LogInWithToken(CloseTokenAuthRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await tokenObj.CloseAuthToken(ReqPara);



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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.LogInWithToken, 0);
            }
            return Response;
        }

        [HttpPost]
       [Route(APIRoute.loginpage.ResetPassword)]
        public async Task<Responce> ResetPassword(Models.V1.Request.ResetPasswordRequest ReqPara)
        {
            Responce Response = new Responce();
            try
            {
                if (ReqPara != null)
                {
                    string result = Obj.ResetPassword(ReqPara);
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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.ResetPassword, Int64.Parse(ReqPara.UserID));
            }
            return Response;
        }
        [HttpPost]
      [Route(APIRoute.loginpage.ForgetPassword)]
        public async Task<ResponceList> ForgetPassword(ForgetPasswordRequest ReqPara)
        {
            ResponceList Response = new ResponceList();
            try
            {
                if (ReqPara != null)
                {
                    JsonElement result =  await Obj.ForgetPassword(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.ForgetPassword, 0);
            }
            return Response;
        }
        [HttpPost]
      [Route(APIRoute.loginpage.GetCompanyLogo)]
        public async Task<ResponceList> GetCompanyLogo(GetlogoRequest ReqPara)
        {
            ResponceList Response = new ResponceList();

            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await Obj.GetCompanyLogo(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.GetCompanyLogo, 0);
            }
            return Response;
        }

        [HttpPost]
       [Route(APIRoute.loginpage.GetCustLott)]
        public async Task<ResponceList> GetCustLott(GetCustLott ReqPara)
        {
            ResponceList Response = new ResponceList();

            try
            {
                if (ReqPara != null)
                {
                    JsonElement result = await Obj.GetCustLott(ReqPara);

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
                exe.ErrorLog(ex.Message.ToString(), APIRoute.loginpage.GetCustLott, 0);
            }
            return Response;
        }

    }
}
