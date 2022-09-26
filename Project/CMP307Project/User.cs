
namespace CMP307Project
{
    public class User           //User class for storing Username of logged in user
    {

        public User (string u)
        {
            username = u;
        }

        public User()
        {

        }

        public string username { get; set; }
    }
}
