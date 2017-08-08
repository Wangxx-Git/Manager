using Own.Manager.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Manager.User
{
    public interface IUserAppService
    {
        PageOutputDto<ListPageUserOutput> ListPageUsers(ListPageUserInput input);
    }
}
