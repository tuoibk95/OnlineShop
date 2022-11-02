namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_detail_user_japan
    {
        [Key]
        public int tbl_user_japan_id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(15)]
        public string code_level { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime end_date { get; set; }

        public int total { get; set; }

        public virtual mst_japan mst_japan { get; set; }

        public virtual tbl_user tbl_user { get; set; }
    }
}
