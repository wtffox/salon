namespace beauty_salon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_import
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime StartTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ClientName { get; set; }
    }
}
