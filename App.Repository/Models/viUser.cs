namespace App.Repository.Models
{
    public class viUser
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public double BalanceSumma { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int Status { get; set; }
        public bool? Verified { get; set; }
    }

    public class viUserUpdateRequest
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
    }

    public class viUserInfo
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
    }


    public class viUserInfoV2
    {
        public Guid Id { get; set; }
        public string ChargePointName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
    }


    public class viUserBalance
    {
        public Guid Id { get; set; }
        public double BalanceSumma { get; set; }
        public bool Verified { get; set; }
    }

    public class viRegisterDriverUser
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
