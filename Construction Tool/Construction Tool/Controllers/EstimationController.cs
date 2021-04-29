using Construction_Tool.Models;
using Construction_Tool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Construction_Tool.Controllers
{
    [Authorize]
    public class EstimationController : Controller
    {
        DBModels dbModel = new DBModels();
        // GET: Index
        public ActionResult Index()
        {
            List<project> projectList = new List<project>();
            List<material> projectMaterials = new List<material>();
            List<item> projectItems = new List<item>();
            List<EstimationViewModel> evmList = new List<EstimationViewModel>();
            return View();
            try
            {
                projectList = dbModel.projects.ToList();
                //projectMaterials = dbModel.materials.ToList().Select(x => x.)
            }
            catch (Exception e) { }
        }
    }
}