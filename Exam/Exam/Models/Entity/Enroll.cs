namespace Exam.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enroll")]
    public partial class Enroll
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        [StringLength(50)]
        public string ExamRoom { get; set; }

        public int? SeatNumber { get; set; }

        public double? Score { get; set; }
    }
}
