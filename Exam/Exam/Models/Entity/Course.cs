namespace Exam.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        public int MajorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
