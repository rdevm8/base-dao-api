using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using base_dao_api.Utilities.Extensions;
using System.Security.Claims;
using base_dao_api.Utilities.Constants;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class PoolFunderMutation
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PoolFunderMutation(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [Authorize(Roles = new[] { RoleCodes.System, RoleCodes.Admin, RoleCodes.Normal })]
        public async Task<PoolFunder> AddPoolFunder(ClaimsPrincipal _claimsPrincipal,
            Guid id,
            [UseFluentValidation, UseValidator<PoolFunderPayloadValidator>]  PoolFunderPayload poolFunder)
        {
            Pool pool = (await _unitOfWork.Pool.GetAsync(
                filter: x => x.Id == id,
                include: x => x.Include(y => y.Status).Include(z => z.PoolActivities)
                )).FirstOrDefault();

            if (pool == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }
            else
            {
                if (pool.Status.DetailCd != PoolCodes.Open)
                {
                    throw new GraphQLException(new Error(ErrorDescriptions.PoolShouldBeOpen));
                }

                if (_claimsPrincipal.GetUserRole() == RoleCodes.Normal && poolFunder.WalletAddress != _claimsPrincipal.GetUserWallet())
                {
                    throw new GraphQLException(new Error(ErrorDescriptions.NotAuthorized));
                }
            }

            PoolFunder res = (await _unitOfWork.PoolFunder.GetAsync(
                filter: x => x.PoolId == id && x.WalletAddress == poolFunder.WalletAddress,
                include: x => x.Include(y => y.Status)
                )).FirstOrDefault();

            if (res == null)
            {
                // NULL
                res = _mapper.Map<PoolFunder>(poolFunder);
                res.PoolId = pool.Id;
                res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolFunderCodes.In)).Select(x => x.Id).FirstOrDefault();
                res.CreatedBy = _claimsPrincipal.GetUserName();
                res.UpdatedBy = _claimsPrincipal.GetUserName();

                _unitOfWork.PoolFunder.Add(res);
            }
            else
            {
                // APPENDING
                res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolFunderCodes.In)).Select(x => x.Id).FirstOrDefault();
                res.AmtInvested += poolFunder.AmtInvested;
                res.UpdatedBy = _claimsPrincipal.GetUserName();
                res.UpdateDttm = DateTime.UtcNow;

            }

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.System, RoleCodes.Admin, RoleCodes.Normal })]
        public async Task<PoolFunder> Withdraw(ClaimsPrincipal _claimsPrincipal,
            Guid id)
        {
            PoolFunder res = (await _unitOfWork.PoolFunder.GetAsync(
                filter: x => x.Id == id,
                include: x => x.Include(y => y.Status).Include(y => y.Pool).ThenInclude(z => z.Status)
                )).FirstOrDefault();

            if (res == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }
            else
            {
                if (_claimsPrincipal.GetUserRole() == RoleCodes.Normal && res.WalletAddress != _claimsPrincipal.GetUserWallet())
                {
                    throw new GraphQLException(new Error(ErrorDescriptions.NotAuthorized));
                }
              
                if (res.Status.DetailCd != PoolFunderCodes.In)
                {
                    throw new GraphQLException(new Error(ErrorDescriptions.FunderWithdrawn));
                }

                if (res.Pool.Status.DetailCd != PoolCodes.Open)
                {
                    throw new GraphQLException(new Error(ErrorDescriptions.PoolShouldBeOpen));
                }
            }

            res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolFunderCodes.Out)).Select(x => x.Id).FirstOrDefault();
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolFunder.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.System })]
        public async Task<PoolFunder> DeletePoolFunder(ClaimsPrincipal _claimsPrincipal,
            Guid id)
        {
            PoolFunder res = await _unitOfWork.PoolFunder.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }

            res.IsDeleted = true;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolFunder.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
