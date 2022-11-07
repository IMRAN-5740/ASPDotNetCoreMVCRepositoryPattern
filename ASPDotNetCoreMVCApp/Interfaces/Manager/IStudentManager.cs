using ASPDotNetCoreMVCApp.Models;
using EF.Core.Repository.Interface.Manager;

namespace ASPDotNetCoreMVCApp.Interfaces.Manager
{
    public interface IStudentManager:ICommonManager<Student>
    {
        Student GetById(int id);
        bool IsExistRegNo(string regNo);
    }
}
