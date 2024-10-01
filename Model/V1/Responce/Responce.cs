using Newtonsoft.Json.Linq;
//using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Web;

namespace WMSCOREAPI.Models.V1.Responce
{
    public class Responce
    {
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public JObject Result { get; set; }
    }
    public class ResponceList
    {
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public JsonElement Result { get; set; }
    }
    public class Responcestring
    {
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string Result { get; set; }
    }
    public class BarcodeScan
    {
        public string scanType { get; set; }
        public string code { get; set; }
        public string id { get; set; }
        public string trid { get; set; }

        public List<validation_result> validation_result;
    }
    public class validation_result
    {
        public string status { get; set; }
        public string result { get; set; }
    }
}



