using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Manager.User.Dto
{
    public class ListPageUserInput : PageInputDto
    {
        public string UserName { get; set; }
        public string LoginName { get; set; }

        //public PagedAndSortedResultRequestDto PageDto
        //{
        //    get
        //    {
        //        return new PagedAndSortedResultRequestDto
        //        {
        //            Sorting = $" order by {Sort} {Order}",
        //            SkipCount = SkipCount,
        //            MaxResultCount = Rows
        //        };
        //    }
        //}

    }
}
