namespace DungApplication.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VisitorStatistic
    {
        public int Id { get; set; }

        public DateTime VisitedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string IpAddress { get; set; }
    }
}
