using REST_API.Data.VO;
using REST_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
