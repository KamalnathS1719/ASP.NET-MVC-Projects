using SessionManageMVC.Models;

namespace SessionManageMVC.Sessions
{
    public interface IStudentService
    {
        public Student Login(string username, string password);
    }
}
