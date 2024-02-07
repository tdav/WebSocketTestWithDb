using App.Utils;
using App.Utils.Serializable;

namespace App.Models
{
    public class viCodeCallerInfo
    {
        public string MemberName { get; set; }
        public string FilePath { get; set; }
        public int LineNumber { get; set; }

        public static string CreateJson(string memberName, string filePath, int lineNumber)
        {
            var res = new viCodeCallerInfo();
            res.MemberName = memberName;
            res.FilePath = string.IsNullOrWhiteSpace(filePath) == false ? CFile.GetFileName(filePath) : "";
            res.LineNumber = lineNumber;

            return res.ToJson();
        }
    }
}
