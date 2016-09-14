namespace Exam.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentNumber { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? AcademyId { get; set; }

        public int? MajorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public virtual Student Student1 { get; set; }

        public virtual Student Student2 { get; set; }
    }
}
