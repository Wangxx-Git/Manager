using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace Own.Manager.Authority
{

    /// <summary>
    /// 针对MVC的Action的权限
    /// </summary>
    public class ActionPermission : FullAuditedEntity
    {
        /// <summary>
        /// 请求地址
        /// </summary>
        [Required]
        public string ActionName { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        [Required]
        public string ControllerName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }
    }
}
