namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        public tbl_user()
        {
            tbl_detail_user_japan = new HashSet<tbl_detail_user_japan>();
        }

        [Key]
        public int user_id { get; set; }
        [Display(Name ="Tên nhóm")]
        public int group_id { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập đầy đủ tên TK")]
        [StringLength(15)]
        [Display(Name ="Tên tài khoản")]
        public string login_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tên đầy đủ")]
        public string full_name { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên katakana")]
        public string full_name_kana { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Địa chỉ email")]
        public string email { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string tel { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime birthday { get; set; }

        public int rules { get; set; }

        [Required]
        [StringLength(255)]
        public string salt { get; set; }

        public virtual mst_group mst_group { get; set; }

        public virtual ICollection<tbl_detail_user_japan> tbl_detail_user_japan { get; set; }
    }
}
