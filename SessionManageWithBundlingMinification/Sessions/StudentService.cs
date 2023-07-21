using SessionManageMVC.Models;

namespace SessionManageMVC.Sessions
{
    public class StudentService : IStudentService
    {
        private List<Student> students;
        public StudentService()
        {
            students = new List<Student>()
            {
                new Student()
                {
                    Username = "Kamalnath",
                    Password = "12345"
                },
                new Student()
                {
                    Username = "KamalnathSL",
                    Password = "12345"
                }
            };
        }
        public Student Login(string username, string password)
        {
            return students.SingleOrDefault(x => x.Username == username && x.Password == password); 
        }
    }
}
