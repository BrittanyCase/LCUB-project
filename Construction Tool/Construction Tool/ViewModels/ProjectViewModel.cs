using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Construction_Tool.Models
{
    public class ProjectViewModel
    {
        public project Project { get; set; }
        public string OwnerName { get; set; }
        public SelectList OwnersDropDown { get; set; }
    }
}