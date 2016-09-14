namespace Exam.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Major")]
    public partial class Major
    {
        public int Id { get; set; }

        public int AcademyId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
