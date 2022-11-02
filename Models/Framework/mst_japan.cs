namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mst_japan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mst_japan()
        {
            tbl_detail_user_japan = new HashSet<tbl_detail_user_japan>();
        }

        [Key]
        [StringLength(15)]
        public string code_level { get; set; }

        [Required]
        [StringLength(255)]
        public string name_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_detail_user_japan> tbl_detail_user_japan { get; set; }
    }
}
