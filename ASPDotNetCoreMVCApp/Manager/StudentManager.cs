using ASPDotNetCoreMVCApp.Data;
using ASPDotNetCoreMVCApp.Interfaces.Manager;
using ASPDotNetCoreMVCApp.Models;
using ASPDotNetCoreMVCApp.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace ASPDotNetCoreMVCApp.Manager
{
    public class StudentManager : CommonManager<Student>, IStudentManager
    {
        public StudentManager(ApplicationDbContext context) : base(new StudentRepository(context))
        {

        }
        public Student GetById(int id)
        {
            var student = GetFirstOrDefault(c => c.Id == id);
            return student;
        }
        public bool IsExistRegNo(string regNo)
        {
            var student = GetFirstOrDefault(c => c.RegNo.ToLower() == regNo.ToLower());
            if(student != null)
            {
                return true;
            }
            return false;
        }
    }
}
