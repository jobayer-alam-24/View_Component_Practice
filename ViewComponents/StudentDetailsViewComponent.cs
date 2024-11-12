using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using View_Component_Practice.Models;

namespace View_Component_Practice.ViewComponents
{
    public class StudentDetailsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View(Student.GetStudentLists().FirstOrDefault(x => x.ID == id));
        }
    }
}