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
    /// 部门
    /// </summary>
    public class Department : FullAuditedEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门编码
        /// </summary>
        [Required]
        public string DeptCode { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        [Required]
        public int Level { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Required]
        public int Index { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 下属用户
        /// </summary>
        public virtual ICollection<User> Users { get; set; }
    }
}
