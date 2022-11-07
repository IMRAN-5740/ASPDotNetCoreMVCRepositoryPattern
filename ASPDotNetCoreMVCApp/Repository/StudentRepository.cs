using ASPDotNetCoreMVCApp.Data;
using ASPDotNetCoreMVCApp.Interfaces.Repository;
using ASPDotNetCoreMVCApp.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVCApp.Repository
{
    public class StudentRepository : CommonRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
