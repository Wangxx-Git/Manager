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
    /// 菜单
    /// </summary>
    public class Menu : FullAuditedEntity
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单编码
        /// </summary>
        [Required]
        public string MenuCode { get; set; }

        /// <summary>
        /// 节点深度
        /// </summary>
        [Required]
        public int Level { get; set; }

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
        /// 小图标
        /// </summary>
        public string SmallIcon { get; set; }

        /// <summary>
        /// 大图标
        /// </summary>
        public string BigIcon { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Required]
        public int Index { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
