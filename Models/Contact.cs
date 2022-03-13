namespace ContactsApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Name")]
        public string ContactName { get; set; }

        [Display(Name = "Ph.No")]
        public int ContactNumber { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string ContactEmail { get; set; }
    }
}
