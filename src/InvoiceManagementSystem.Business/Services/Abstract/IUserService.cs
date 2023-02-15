using Core.Entities.Concrete;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Services.Abstract
{
    public interface IUserService : IBaseService<User, UserWriteDto, UserReadDto>
    {
    }
}