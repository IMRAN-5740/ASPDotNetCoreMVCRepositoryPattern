using ASPDotNetCoreMVCApp.Models;
using EF.Core.Repository.Interface.Repository;

namespace ASPDotNetCoreMVCApp.Interfaces.Repository
{
    public interface IStudentRepository:ICommonRepository<Student>
    {

    }
}
