using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    public class UserInfo
    {
		// Khai báo thuộc tính user_id
		private int userId { get; set; }
		// Khai báo thuộc tính login_name
		private String loginName { get; set; }
		// Khai báo thuộc tính group_id
		private int groupId { get; set; }
		// Khai báo thuộc tính group_name
		private String groupName { get; set; }
		// Khai báo thuộc tính full_name
		private String fullName { get; set; }
		// Khai báo thuộc tính full_name_kana
		private String fullNameKana { get; set; }
		// Khai báo thuộc tính email
		private String email { get; set; }
		// Khai bao thuộc tính tel
		private String tel { get; set; }
		// Khai báo thuộc tính birthday
		private String birthday { get; set; }
		// Khai báo thuộc tính password
		private String password { get; set; }
		// Khai báo thuộc tính rePassword
		private String confirmPassword { get; set; }
		// Khai báo thuộc tính code_level
		private String codeLevel { get; set; }
		// Khai báo thuộc tính name_level
		private String nameLevel { get; set; }
		// Khai báo thuộc tính start_date
		private String startDate { get; set; }
		// Khai báo thuộc tính end_date
		private String endDate { get; set; }
		// Khai báo thuộc tính total
		private String total { get; set; }
	}
}
