namespace DungApplication.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slide
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Describe { get; set; }

        [Required]
        [StringLength(500)]
        public string Img { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public bool? Stat { get; set; }
    }
}
