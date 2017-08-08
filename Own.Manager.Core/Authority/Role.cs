using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace Own.Manager.Authority
{
    public class Role : FullAuditedEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色编码
        /// </summary>
        [Required]
        public string RoleCode { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public virtual ICollection<ActionPermission> ActionPermissions { get; set; }
    }
}
