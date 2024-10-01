namespace WMSCOREAPI.Model.V1.Request
{
    public class TimeTracker
    {
        public class BarcodeScanLabour
        {

            public string Barcode { get; set; }
            public Int64 zoneID { get; set; }
            public Int64 actid { get; set; }
            public Int64 compid { get; set; }
            public Int64 custid { get; set; }
            public Int64 userid { get; set; }
            public string orderGroupName { get; set; }
            public Int64 orderid { get; set; }
        }

        public class LabourHistory
        {
            public Int64 uid { get; set; }
            public Int64 wrid { get; set; }
            public Int64 custid { get; set; }

        }

        public class SaveLabour
        {
            public Int64 labourId { get; set; }
            public Int64 zoneId { get; set; }
            public String orderGroupName { get; set; }
            public String popupflag { get; set; }
            public Int64 warehouseId { get; set; }
            public Int64 createdby { get; set; }
            public Int64 activityId { get; set; }
            public Int64 compid { get; set; }
            public Int64 custid { get; set; }

        }

        public class ScanLogLabour
        {
            public String order { get; set; }
            public Int64 zoneID { get; set; }
            public Int64 userid { get; set; }
            public Int64 custid { get; set; }

        }
        public class FinalSaveLabour
        {

            public Int64 zoneID { get; set; }
            public Int64 activityid { get; set; }
            public String orderno { get; set; }
            public Int64 custid { get; set; }

        }
    }
}
