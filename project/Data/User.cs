namespace UserLogin
{

    public class Credential {
        public string? Username { get; set; }
        private string? Email { get; set; }
        public string? Password { get; set; }
    }
    public class User : Credential
    {

        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? Phone { get; set; }

        public void Click()
        {
            Console.WriteLine(Password);
            return;
        }
    }
}