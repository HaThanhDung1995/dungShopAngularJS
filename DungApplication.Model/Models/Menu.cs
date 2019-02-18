namespace DungApplication.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menu
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string url { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(10)]
        public string Targe { get; set; }

        public bool? Stat { get; set; }

        public int? MenuGroupId { get; set; }

        public virtual MenuGroup MenuGroup { get; set; }
    }
}
