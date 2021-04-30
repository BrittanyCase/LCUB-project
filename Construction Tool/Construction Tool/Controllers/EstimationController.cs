using Construction_Tool.Models;
using Construction_Tool.ViewModels;
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
    public class EstimationController : Controller
    {
        DBModels dbModel = new DBModels();
        // GET: Estimation
        public ActionResult Index(string search)
        {
            List<project> projectsList;
            List<EstimationViewModel> evmList;
            try
            {
                if (!string.IsNullOrEmpty(search))
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
                evmList = projectsList.Select(x => new EstimationViewModel()
                {
                    Project = x,
                    Materials = x.materials.ToList(),
                    MaterialsCost = x.materials.Select(y => y.item.ITEM_COST * y.QUANTITY).ToList().Sum(z => Convert.ToDecimal(z)),
                    LaborCost = dbModel.items.Find("labor").ITEM_COST,
                    Items = x.materials.ToList().Select(b => b.item).ToList()
            }).ToList();
                return View(evmList);
            }
            catch (Exception) { return View("Error503"); }
        }
        // GET: Materials
        [PreventFromUrl]
        public ActionResult Materials(int projectID, string search = null)
        {
            try
            {
                project project = dbModel.projects.Find(projectID);
                List<material> projectMaterials;
                if (!string.IsNullOrEmpty(search))
                {
                    projectMaterials = project.materials.ToList().Where(s => s.item.ITEM_DESC.Contains(search)).ToList();
                }
                else
                {
                    projectMaterials = project.materials.ToList();
                }
                List<item> projectItems = projectMaterials.Select(x => x.item).ToList();
                EstimationViewModel evm = new EstimationViewModel()
                {
                    Project = project,
                    Materials = projectMaterials,
                    MaterialsCost = projectMaterials.Select(y => y.item.ITEM_COST * y.QUANTITY ).ToList().Sum(z => Convert.ToDecimal(z)),
                    LaborCost = dbModel.items.Find("labor").ITEM_COST,
                    Items = projectItems
                };
                return View(evm);
            }
            catch (Exception) { return View("Error503"); }
        }
        // POST: Remove
        [PreventFromUrl]
        public ActionResult Remove(int projectID, string itemID)
        {
            try
            {
                material material = dbModel.materials.Find(projectID, itemID);
                dbModel.materials.Remove(material);
                dbModel.SaveChanges();
                return RedirectToAction("Materials", "Estimation", new { projectID = projectID });
            }
            catch (DbEntityValidationException)
            {
                return RedirectToAction("Materials", "Estimation", new { projectID = projectID });
            }
            catch (DbUpdateException)
            {
                return RedirectToAction("Materials", "Estimation", new { projectID = projectID });
            }
            catch(Exception)
            {
                return View("Error503");
            }
        }
        [PreventFromUrl]
        [HttpGet]
        // GET: Add
        public ActionResult Add(int projectID, string search = "")
        {
            List<item> itemsList;
            try
            {
                if (!string.IsNullOrEmpty(search))
                {
                    List<item> itemListNameSearch = dbModel.items.Where(s => s.ITEM_DESC.Contains(search)).ToList();
                    itemsList = itemListNameSearch;
                }
                else
                {
                    itemsList = dbModel.items.ToList();
                }
                MaterialViewModel mvm = new MaterialViewModel()
                {
                    ProjectID = projectID,
                    ItemsList = itemsList,
                };
                return View(mvm);
            }
            catch(Exception)
            {
                return View("Error503");
            }

        }
        [PreventFromUrl]
        // POST: Add
        public ActionResult Add(MaterialViewModel mvm)
        {
            try
            {
                project project = dbModel.projects.Find(mvm.ProjectID);
                item selectedItem = dbModel.items.Find(mvm.ItemID);
                if(dbModel.materials.Find(project.PROJECT_ID, selectedItem.ITEM_ID) == null)
                {
                    material material = new material()
                    {
                        PROJECT_ID = project.PROJECT_ID,
                        ITEM_ID = selectedItem.ITEM_ID,
                        QUANTITY = mvm.Quantity,
                    };
                    dbModel.materials.Add(material);
                    dbModel.SaveChanges();
                }
                else
                {
                    material material = dbModel.materials.Find(project.PROJECT_ID, selectedItem.ITEM_ID);
                    material.QUANTITY = mvm.Quantity;
                    dbModel.Entry(material).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Materials", "Estimation", new { projectID = mvm.ProjectID });
            }
            catch(DbUpdateException)
            {
                return RedirectToAction("Add", "Estimation", new { projectID = mvm.ProjectID });
            }
            catch(DbEntityValidationException)
            {
                return RedirectToAction("Add", "Estimation", new { projectID = mvm.ProjectID });
            }
            catch(Exception)
            {
                return View("Error503");
            }
        }
    }
}