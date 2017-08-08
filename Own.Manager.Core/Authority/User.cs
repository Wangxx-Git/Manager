using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Own.Manager.Authority
{
    public class User : FullAuditedEntity
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        [Required]
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Required]
        public string PassWord { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }


        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
