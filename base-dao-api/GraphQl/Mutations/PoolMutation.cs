using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class PoolMutation
    {
        private readonly IMapper _mapper;

        public PoolMutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<Pool> AddPool([Service] IUnitOfWork _unitOfWork,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>]  PoolPayload pool)
        {
            Pool res = _mapper.Map<Pool>(pool);

            res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == "PSTATUS-OPEN")).Select(x => x.Id).FirstOrDefault();

            _unitOfWork.Pool.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<Pool> UpdatePool([Service] IUnitOfWork _unitOfWork,
            Guid id,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>] PoolPayload pool)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Pool not found!"));
            }

            res.Title = pool.Title;
            res.Description = pool.Description;
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<Pool> UpdatePoolStatus([Service] IUnitOfWork _unitOfWork,
            Guid id,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>] PoolStatusPayload poolStatus)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Pool not found!"));
            }

            res.StatusId = poolStatus.StatusId;
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<Pool> DeletePool([Service] IUnitOfWork _unitOfWork,
            Guid id)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Pool not found!"));
            }

            res.IsDeleted = true;
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
