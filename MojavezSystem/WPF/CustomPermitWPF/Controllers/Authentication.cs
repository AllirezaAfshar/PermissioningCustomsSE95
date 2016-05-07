using System.Diagnostics.Eventing.Reader;

namespace CustomPermitWPF.Controllers
{
    public static class Authentication
    {
        public static bool Login(string username, string password)
        {
            return true;
            return username == "user" && password == "pass";
        }
    }
}