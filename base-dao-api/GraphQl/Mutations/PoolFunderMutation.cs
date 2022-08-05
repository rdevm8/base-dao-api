using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class PoolFunderMutation
    {
        private readonly IMapper _mapper;

        public PoolFunderMutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<PoolFunder> AddPoolFunder([Service] IUnitOfWork _unitOfWork,
            Guid id,
            [UseFluentValidation, UseValidator<PoolFunderPayloadValidator>]  PoolFunderPayload poolFunder)
        {
            Pool pool = (await _unitOfWork.Pool.GetAsync(
                filter: x => x.Id == id,
                include: x => x.Include(y => y.Status)
                )).FirstOrDefault();

            if (pool == null)
            {
                throw new GraphQLException(new Error("Pool not found!"));
            }
            else
            {
                if (pool.Status.DetailCd != "PSTATUS-OPEN")
                {
                    throw new GraphQLException(new Error("Cannot add pool funder when Pool is already on going"));
                }
            }

            PoolFunder res = _mapper.Map<PoolFunder>(poolFunder);
            res.PoolId = pool.Id;
            res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == "PFSATUS-IN")).Select(x => x.Id).FirstOrDefault();

            _unitOfWork.PoolFunder.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<PoolFunder> Withdraw([Service] IUnitOfWork _unitOfWork,
            Guid id)
        {
            PoolFunder res = await _unitOfWork.PoolFunder.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Pool Funder not found!"));
            }

            res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == "PFSATUS-OUT")).Select(x => x.Id).FirstOrDefault();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolFunder.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { "ROLE-SYSTEM" })]
        public async Task<PoolFunder> DeletePoolFunder([Service] IUnitOfWork _unitOfWork,
            Guid id)
        {
            PoolFunder res = await _unitOfWork.PoolFunder.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error("Pool Funder not found!"));
            }

            res.IsDeleted = true;
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolFunder.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
