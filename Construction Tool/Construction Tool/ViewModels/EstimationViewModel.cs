using Construction_Tool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Construction_Tool.ViewModels
{
    public class EstimationViewModel
    {
        public project Project { get; set; }
        public List<material> MaterialList { get; set; }
        public List<item> ItemList { get; set; }

    }
}