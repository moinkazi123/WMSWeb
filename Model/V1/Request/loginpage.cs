using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMSCOREAPI.Models.V1.Request
{

    public class GetloginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CloseTokenAuthRequest
    {
        public string Token { get; set; }
        public string UserID { get; set; }
        public string CompanyID { get; set; }
    }

    public class ResetPasswordRequest
    {
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string UserID { get; set; }
    }

    public class ForgetPasswordRequest
    {
        public string EmailID { get; set; }
        public string UserName { get; set; }
    }

    public class GetlogoRequest
    {
        public string CompanyID { get; set; }
    }

    public class GetCustLott
    {
        public string custid { get; set; }
        public string Userid { get; set; }
    }

}
