
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Own.Manager.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Own.Manager.User;

namespace Own.Manager.Authority
{
    public class UserAppService : ManagerAppServiceBase, IUserAppService
    {
        private readonly IRepository<User> _userRepository;
        public UserAppService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public PageOutputDto<ListPageUserOutput> ListPageUsers(ListPageUserInput input)
        {
            var query = _userRepository.GetAll();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.UserName), a => a.UserName.Contains(input.UserName))
                         .WhereIf(!string.IsNullOrWhiteSpace(input.LoginName), a => a.LoginName.Contains(input.LoginName));

            var rows = query.OrderByDescending(a => a.Id).PageBy(input.SkipCount, input.Rows).ToList().MapTo<List<ListPageUserOutput>>();
            //var rows = query.OrderByDescending(a => a.Id).PageBy(input.SkipCount, input.Rows).ToList().Select(a => a.MapTo<ListPageUserOutput>()).ToList();
            var total = query.Count();
            return new PageOutputDto<ListPageUserOutput> { Rows = rows, Total = total };
        }
    }
}
