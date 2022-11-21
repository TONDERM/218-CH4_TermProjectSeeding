using System.ComponentModel.DataAnnotations;

namespace SCP_Foundation.Models
{
    public class SCP
    {
        // EF will instruct the database to automatically generate this value
        public int SCPID { get; set; }

        [Display(Name = "ID Number")]
        [Required(ErrorMessage = "Please enter the SCP ID number.")]
        [StringLength(8, MinimumLength = 8)]
        public string IdNumber { get; set; }

        [StringLength(60, MinimumLength = 1)]
        public string Name { get; set; }

        [Display(Name = "Object Class")]
        [StringLength(60, MinimumLength = 1)]
        //public string ObjectClassId { get; set; }
        public string ObjectClass { get; set; }

        [Display(Name = "Threat Level")]
        [StringLength(60, MinimumLength = 1)]
        //public string ThreatLevelId { get; set; }
        public string ThreatLevel { get; set; }

        //[Required]
        //[StringLength(60)]
        //public string Classification { get; set; } = string.Empty;

        //[Required]
        //[StringLength(5000, MinimumLength = 10)]
        //public string Description { get; set; } = string.Empty;

        //[Required]
        //[StringLength(5000)]
        //public string Containment { get; set; } = string.Empty;

        //public string Slug =>
        //    Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
