namespace App.Interfaces.Models
{
    public class FilterResult
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }
        public bool Result { get; set; }

        public FilterResult(string name, string description, string version, bool result)
        {
            Name = name;
            Description = description;
            Version = version;
            Result = result;
        }
    }
}
