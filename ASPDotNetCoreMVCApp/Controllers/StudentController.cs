using ASPDotNetCoreMVCApp.Data;
using ASPDotNetCoreMVCApp.Interfaces.Manager;
using ASPDotNetCoreMVCApp.Manager;
using ASPDotNetCoreMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVCApp.Controllers
{
    public class StudentController : Controller
    {
        //private ApplicationDbContext _context;
        //private IStudentManager _studentManager;
        //public StudentController(ApplicationDbContext context)
        //{
        //    _context = context;
        //    _studentManager = new StudentManager(_context);
        //}
        private StudentManager _studentManager;
        public StudentController(StudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        public IActionResult Index()
        {
            var students = _studentManager.GetAll();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            bool checkReg = _studentManager.IsExistRegNo(student.RegNo);
            if(!checkReg)
            {
                if (ModelState.IsValid)
                {
                    bool isChecked = _studentManager.Add(student);
                    if(isChecked)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            else
            {
                ViewBag.Message = "RegNo Already Exists try another";
                return View(student);
            }
           
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student=_studentManager.GetById(id);
            if(student==null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                bool isChecked = _studentManager.Update(student);
                if(isChecked)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                    return  View(student);
                }
            }
            return View(student);
        }

        public IActionResult Details(int id)
        {
            var student = _studentManager.GetById(id);
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _studentManager.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            if(ModelState.IsValid)
            {
                bool isCheked=_studentManager.Delete(student);
                if(isCheked)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(student);
                }
            }
            return View(student);
        }
    }
}
