namespace WMSCOREAPI.Model.V1.Request
{
    public class RfidTagging
    {
        public class GetRfidTaggingRequest
        {
            public long CurrentPage { get; set; }
            public long RecordLimit { get; set; }
            public long CustomerId { get; set; }
            public long WarehouseId { get; set; }
            public long UserId { get; set; }
            public string SearchKey { get; set; }
            public string ListType { get; set; }
            public string ActiveTab { get; set; }
        }

        public class GetRfidTaggingResponse
        {
            public string Status { get; set; }
            public string StatusCode { get; set; }
            public string Result { get; set; }
        }

        // UPDATE RFID - ASSIGN DEASSIGN
        public class UpdateRfidRequest
        {
            public string RfidLabel { get; set; }
            public long RecordId { get; set; }
            public string Code { get; set; }
            public long CodeId { get; set; }
        }

        public class UpdateRfidResponse
        {
            public string Status { get; set; }
            public string StatusCode { get; set; }
            public string Result { get; set; }
        }

        // MULTIPLE RFID UNASSIGN
        public class MultipleRfidUnassignRequest
        {
            public string RecordId { get; set; }
        }

        public class MultipleRfidUnassignResponse
        {
            public string Status { get; set; }
            public string StatusCode { get; set; }
            public string Result { get; set; }
        }

        // INSERT RFID RECORD
        public class InsertRfidRequest
        {
            public string RfidLabel { get; set; }
            public string RfidType { get; set; }
            public string Code { get; set; }
            public long CodeId { get; set; }
            public string Description { get; set; }
            public long UserId { get; set; }
        }


        public class InsertRfidResponse
        {
            public string Status { get; set; }
            public string StatusCode { get; set; }
            public string Result { get; set; }
        }
    }
}
