using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Construction_Tool.Models
{
    [Table("PROJECT")]
    public class ProjectViewModel
    {
        [Key]
        [Column("ProjectID")]
        public int ProjectID { get; set; }
        [Column("OwnerID")]
        public int OwnerID { get; set; }
        [Column("ProjectName")]
        public string ProjectName { get; set; }
        [Column("ProjectDesc")]
        public string ProjectDesc { get; set; }
        [Column("ProjectCreatedOn")]
        public string ProjectCreatedOn { get; set; }
        [Column("ProjectLastEditedOn")]
        public string ProjectLastEditedOn { get; set; }
    }
}
