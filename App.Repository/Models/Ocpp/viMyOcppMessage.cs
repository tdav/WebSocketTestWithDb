namespace App.Repository.Models.Ocpp
{
    public class viMyOcppMessage<T>
    {
        public string cmd { get; set; }
        public T payload { get; set; }

        public viMyOcppMessage(string cmd, T payload)
        {
            this.cmd = cmd;
            this.payload = payload;
        }
    }

    public class viMyOcppReponseMessage
    {
        public string cmd { get; set; }
        public bool iserror { get; set; }
        public string data { get; set; }

        public static string ToJson(string cmd, bool iserror, string data)
        {
            var res = new viMyOcppReponseMessage()
            {
                cmd = cmd,
                iserror = iserror,
                data = data
            };

            return Newtonsoft.Json.JsonConvert.SerializeObject(res);
        }
    }
}
