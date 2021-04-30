using Construction_Tool.Models;
using Construction_Tool.Views.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Construction_Tool.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        // GET: Project
        DBModels dbModel = new DBModels();
        public ActionResult Index(string search)
        {
            List<project> projectsList = new List<project>();
            List<OwnerListTable> ownersList = new List<OwnerListTable>();
            List<ProjectViewModel> pvmList = new List<ProjectViewModel>();
            try
            {
                if(!string.IsNullOrEmpty(search))
                {
                    // Name search
                    List<project> projectsListNameSearch = dbModel.projects.Where(s => s.PROJECT_NAME.Contains(search)).ToList();
                    // Owner search
                    List<project> projectListOwnerSearch = dbModel.projects.Where(s => s.owner.USER.Contains(search)).ToList();
                    projectsList = projectsListNameSearch.Union(projectListOwnerSearch).ToList();
                }
                else
                {
                    projectsList = dbModel.projects.ToList();
                }
                ownersList = dbModel.owners.ToList().Select(x => new OwnerListTable()
                {
                    OwnerID = x.OWNER_ID,
                    OwnerName = x.USER
                }).ToList();
                pvmList = projectsList.Select(x => new ProjectViewModel()
                {
                    Project = x,
                    OwnerName = x.owner.USER,
                    OwnersDropDown = new SelectList(ownersList, "OwnerID", "OwnerName")
                }).ToList();
                return View(pvmList);
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }
        // GET: Project/Details/5
        [PreventFromUrl]
        public ActionResult Details(int id)
        {
            project project = new project();
            List<OwnerListTable> ownersList = new List<OwnerListTable>();
            ProjectViewModel pvm = new ProjectViewModel();
            try
            {
                
                project = dbModel.projects.Find(id);
                if (project == null) { return View("Error404"); }
                ownersList = dbModel.owners.ToList().Select(x => new OwnerListTable()
                {
                    OwnerID = x.OWNER_ID,
                    OwnerName = x.USER
                }).ToList();
                pvm = new ProjectViewModel()
                {
                    Project = project,
                    OwnerName = project.owner.USER,
                    OwnersDropDown = new SelectList(ownersList, "OwnerID", "OwnerName")
                };
                return View(pvm);
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // GET: Project/Create
        [PreventFromUrl]
        public ActionResult Create()
        {
            try
            {
                
                List<OwnerListTable> ownersList = new List<OwnerListTable>();
                ownersList = dbModel.owners.ToList().Select(x => new OwnerListTable()
                {
                    OwnerID = x.OWNER_ID,
                    OwnerName = x.USER
                }).ToList();
                return View(new ProjectViewModel()
                {
                    Project = new project(),
                    OwnersDropDown = new SelectList(ownersList, "OwnerID", "OwnerName")
                });
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // POST: Project/Create
        [HttpPost]
        [PreventFromUrl]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectViewModel pvm)
        {
            try
            {
                
                project project = pvm.Project;
                try
                {
                    dbModel.projects.Add(project);
                    dbModel.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbEntityValidationException)
                {
                    return RedirectToAction("Create", new { id = pvm.Project.PROJECT_ID });
                }
                catch (DbUpdateException)
                {
                    return RedirectToAction("Create", new { id = pvm.Project.PROJECT_ID });
                }
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // GET: Project/Edit/5
        [PreventFromUrl]
        public ActionResult Edit(int id)
        {
            project project = new project();
            List<OwnerListTable> ownersList = new List<OwnerListTable>();
            ProjectViewModel pvm = new ProjectViewModel();
            
            try
            {
                
                ownersList = dbModel.owners.ToList().Select(x => new OwnerListTable()
                {
                    OwnerID = x.OWNER_ID,
                    OwnerName = x.USER
                }).ToList();
                project = dbModel.projects.Find(id);
                if(project== null) { return View("Error404"); }
                pvm = new ProjectViewModel()
                {
                    Project = project,
                    OwnerName = project.owner.USER,
                    OwnersDropDown = new SelectList(ownersList, "OwnerID", "OwnerName")
                };
                return View(pvm);
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // POST: Project/Edit/5
        [HttpPost]
        [PreventFromUrl]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectViewModel pvm)
        {
            try
            {
                
                project project = pvm.Project;
                dbModel.Entry(project).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    dbModel.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (DbEntityValidationException)
                {
                    return RedirectToAction("Edit", new { id = pvm.Project.PROJECT_ID });
                }
                catch (DbUpdateException)
                {
                    return RedirectToAction("Edit", new { id = pvm.Project.PROJECT_ID });
                }
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // GET: Project/Delete/5
        [PreventFromUrl]
        public ActionResult Delete(int id)
        {
            try
            {
                project project = new project();
                List<OwnerListTable> ownersList = new List<OwnerListTable>();
                ProjectViewModel pvm = new ProjectViewModel();

                
                project = dbModel.projects.Find(id);
                ownersList = dbModel.owners.ToList().Select(x => new OwnerListTable()
                {
                    OwnerID = x.OWNER_ID,
                    OwnerName = x.USER
                }).ToList();
                if (project == null) { return View("Error404"); }
                pvm = new ProjectViewModel()
                {
                    Project = project,
                    OwnerName = project.owner.USER,
                    OwnersDropDown = new SelectList(ownersList, "OwnerID", "OwnerName")
                };
                return View(pvm);
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }

        // POST: Project/Delete/5
        [HttpPost]
        [PreventFromUrl]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                try
                {
                    
                    project project = dbModel.projects.Find(id);
                    dbModel.projects.Remove(project);
                    dbModel.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    return RedirectToAction("Delete", new { id });
                }
                catch (DbUpdateException e)
                {
                    Console.Write(e.Message);
                    return RedirectToAction("Delete", new { id });
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error503");
            }
        }
    }
}
