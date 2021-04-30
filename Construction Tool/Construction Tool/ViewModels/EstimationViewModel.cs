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
        public List<material> Materials { get; set; }
        public List<item> Items { get; set; }
        public decimal MaterialsCost { get; set; }
        public decimal LaborCost { get; set; }
        public decimal TotalCost
        {
            get { return LaborCost + MaterialsCost; }
        }
        public decimal LaborHours { get; set; }
    }
}