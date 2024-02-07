using System.IO;

namespace App.Interfaces
{
    public interface IJsonParser
    {
        string Parse(string json, string key);
        string Parse(Stream json, string key);
    }
}
