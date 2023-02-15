using Core.Dto;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto);
        Task<IDataResult<AccessToken>> CreateAccessTokenAsync(User user);
    }
}