using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HZMStorage.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "mmm")]
        public string UserName { get; set; }
        [Required]
        public string PassWord { get; set; }
        public string UserCode { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateIp { get; set; }
        public string CreateUser { get; set; }
        public int LoginCount { get; set; }
        public string Picture { get; set; }
        public DateTime UpdateTime { get; set; }
        public short IsDelete { get; set; }
        public short Status { get; set; }
        public string DepartNum { get; set; }
        public string ParentCode { get; set; }
        public string RoleNum { get; set; }
        public string Remark { get; set; }
    }
}
