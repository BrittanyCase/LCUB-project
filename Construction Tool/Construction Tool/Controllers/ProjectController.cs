using Construction_Tool.Contexts;
using Construction_Tool.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Construction_Tool.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index(int id)
        {
            using (ProjectContext context = new ProjectContext(
                "DefaultConnection"))
            {
                return View(new TestViewModel() { sql = context.Projects.Sql });
            }
        }
    }
}
