namespace DungApplication.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupportOnline")]
    public partial class SupportOnline
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Skype { get; set; }

        [StringLength(250)]
        public string Gmail { get; set; }

        [StringLength(250)]
        public string Facebook { get; set; }

        public bool? Stat { get; set; }

        [StringLength(250)]
        public string Department { get; set; }
    }
}
