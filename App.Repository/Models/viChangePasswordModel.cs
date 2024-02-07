namespace App.Repository.Models
{
    public class viChangePasswordModel
    {
        public string oldPassword { get; set; }

        public string newPassword { get; set; }
    }

    public class viChangePasswordSmModel
    {
        public string userId { get; set; }

        public string newPassword { get; set; }
    }
}
