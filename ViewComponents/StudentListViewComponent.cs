using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View_Component_Practice.Models;

namespace View_Component_Practice.ViewComponents
{
    public class StudentListViewComponent : ViewComponent
    {
        public List<Student> students;
        public IViewComponentResult Invoke()
        {
            students = Student.GetStudentLists();
            return View(students);
        }
    }
}