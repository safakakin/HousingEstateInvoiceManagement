using Core.Aspects.Autofac.Validation;
using Core.Dto;
using Core.Entities.Concrete;
using Core.Exceptions;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using Core.Utilities.Security.Hashing;
using InvoiceManagementSystem.Business.BusinessAspects;
using Mapster;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    [SecuretOperation("Admin")]
    public class UserManager : BaseManager<User, UserWriteDto, UserReadDto>, IUserService
    {
        public UserManager(IUserDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public override async Task<DataResult<UserReadDto>> AddAsync(UserWriteDto writeDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(writeDto.Password, out passwordHash, out passwordSalt);

            User entity = writeDto.Adapt<User>();

            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;

            User addedEntity = await Repository.AddAsync(entity);

            if (addedEntity == null)
                throw new BusinessException(LanguageMessage.FailureAdd);
            return new SuccessDataResult<UserReadDto>(addedEntity.Adapt<UserReadDto>(), LanguageMessage.SuccessAdd);
        }

        public override async Task<DataResult<UserReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public async override Task<DataResult<UserReadDto>> UpdateAsync(int id, UserWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        public override Task<DataResult<IPaginate<UserReadDto>>> GetListAsync(
            Expression<Func<User, bool>>? predicate = null,
            Func<IQueryable<User>, IOrderedQueryable<User>>? orderBy = null,
            Func<IQueryable<User>, IIncludableQueryable<User, object>>? include = null,
            int index = 0, int size = 10, bool enamleTracking = true,
            CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }

        public override async Task<DataResult<UserReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

    }
}
