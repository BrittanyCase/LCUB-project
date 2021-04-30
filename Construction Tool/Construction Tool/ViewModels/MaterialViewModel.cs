using Construction_Tool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Construction_Tool.ViewModels
{
    public class MaterialViewModel
    {
        public List<item> ItemsList { get; set; }
        public int ProjectID { get; set; }
        [Range(1, 10000)]
        public int Quantity { get; set; }
        public string ItemID { get; set; }
    }
}