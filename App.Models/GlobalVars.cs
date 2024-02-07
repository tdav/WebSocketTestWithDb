namespace App.Models
{
    public class Vars
    {
        public int CacheTimeOut { get; set; }
        public string ApiKey { get; set; }
        public SmsSetings SmsSetings { get; set; }
    }

    public class SmsSetings
    {
        public bool IsActive { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string TemplateText { get; set; }
    }


    public class JwtVars
    {
        public string ValidAudience { get; set; }
        public string ValidIssuer { get; set; }
        public string Secret { get; set; }
        public int TokenValidityInDays { get; set; }
        public int RefreshTokenValidityInDays { get; set; }
    }

    public class VarsOcppLog
    {
        public bool OcppJson { get; set; }
        public bool OcppMessage { get; set; }
    }
}
