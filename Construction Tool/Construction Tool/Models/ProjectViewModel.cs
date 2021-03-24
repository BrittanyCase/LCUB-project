using System;
using System.ComponentModel.DataAnnotations;

namespace Construction_Tool.Models
{
    public class ProjectViewModel
    {
        [DisplayAttribute(Name = "Project Name:")]
        public string ProjectName { get; set; }
        [DisplayAttribute(Name = "Project Created On:")]
        public string ProjectCreatedOn { get; set; }
        [DisplayAttribute(Name = "Project Last Accessed On:")]
        public string ProjectLastAccessedOn { get; set; }
    }
}
