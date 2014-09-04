using DIPSky.Core.Domain.Customers;

namespace DIPSky.Services.Customers
{
    public class CustomerRegistrationRequest
    {
        public Customer Customer { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public PasswordFormat PasswordFormat { get; set; }
        public bool IsApproved { get; set; }

        public string Phone { get; set; }

        public CustomerRegistrationRequest(Customer customer, string email, string username,
            string password,
            PasswordFormat passwordFormat,
            bool isApproved = true)
        {
            this.Customer = customer;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.PasswordFormat = passwordFormat;
            this.IsApproved = isApproved;
        }

        public CustomerRegistrationRequest(Customer customer, string email, string username,
            string password, string phone,
            PasswordFormat passwordFormat,
            bool isApproved = true)
            : this(customer, email, username, password, passwordFormat, isApproved)
        {
            this.Phone = phone;
        }

        //public bool IsValid  
        //{
        //    get 
        //    {
        //        return (!CommonHelper.AreNullOrEmpty(
        //                    this.Email,
        //                    this.Password
        //                    ));
        //    }
        //}
    }
}
