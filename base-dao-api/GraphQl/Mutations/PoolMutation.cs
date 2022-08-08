using AutoMapper;
using base_dao_api.GraphQl.Mutations.Payloads;
using base_dao_api.GraphQl.Validators;
using base_dao_api.Models;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using FluentValidation.Results;
using AppAny.HotChocolate.FluentValidation;
using HotChocolate.AspNetCore.Authorization;
using base_dao_api.Utilities.Constants;
using System.Security.Claims;
using base_dao_api.Utilities.Extensions;
using Microsoft.EntityFrameworkCore;

namespace base_dao_api.GraphQl.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class PoolMutation
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PoolMutation(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        [Authorize(Roles = new[] { RoleCodes.Admin, RoleCodes.System })]
        public async Task<Pool> AddPool(ClaimsPrincipal _claimsPrincipal,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>]  PoolPayload pool)
        {
            Pool res = _mapper.Map<Pool>(pool);

            res.StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolCodes.Open)).Select(x => x.Id).FirstOrDefault();
            res.CreatedBy = _claimsPrincipal.GetUserName();
            res.UpdatedBy = _claimsPrincipal.GetUserName();

            _unitOfWork.PoolActivity.Add(new PoolActivity
            {
                PoolId = res.Id,
                StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolActivityCodes.StatusUpdate)).Select(x => x.Id).FirstOrDefault(),
                Description = PoolActivityDescriptions.Added,
                CreatedBy = _claimsPrincipal.GetUserName(),
                UpdatedBy = _claimsPrincipal.GetUserName(),
            });

            _unitOfWork.Pool.Add(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.Admin, RoleCodes.System })]
        public async Task<Pool> UpdatePool(ClaimsPrincipal _claimsPrincipal, 
            Guid id,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>] PoolPayload pool)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }

            res.Title = pool.Title;
            res.Description = pool.Description;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolActivity.Add(new PoolActivity
            {
                PoolId = res.Id,
                StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolActivityCodes.DetailsUpdate)).Select(x => x.Id).FirstOrDefault(),
                Description = PoolActivityDescriptions.DetailsUpdated,
                CreatedBy = _claimsPrincipal.GetUserName(),
                UpdatedBy = _claimsPrincipal.GetUserName(),
            });

            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.Admin, RoleCodes.System })]
        public async Task<Pool> UpdatePoolStatus(ClaimsPrincipal _claimsPrincipal, 
            Guid id,
            [UseFluentValidation, UseValidator<PoolPayloadValidator>] PoolStatusPayload poolStatus)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }

            res.StatusId = poolStatus.StatusId;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolActivity.Add(new PoolActivity
            {
                PoolId = res.Id,
                StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolActivityCodes.StatusUpdate)).Select(x => x.Id).FirstOrDefault(),
                Description = PoolActivityDescriptions.StatusUpdated,
                CreatedBy = _claimsPrincipal.GetUserName(),
                UpdatedBy = _claimsPrincipal.GetUserName(),
            });


            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }

        [Authorize(Roles = new[] { RoleCodes.System })]
        public async Task<Pool> DeletePool(ClaimsPrincipal _claimsPrincipal,
            Guid id)
        {
            Pool res = await _unitOfWork.Pool.GetAsync(id);

            if (res == null)
            {
                throw new GraphQLException(new Error(ErrorDescriptions.EntityNotFound));
            }

            res.IsDeleted = true;
            res.UpdatedBy = _claimsPrincipal.GetUserName();
            res.UpdateDttm = DateTime.UtcNow;

            _unitOfWork.PoolActivity.Add(new PoolActivity
            {
                PoolId = res.Id,
                StatusId = (await _unitOfWork.CodeDetail.GetAsync(x => x.DetailCd == PoolActivityCodes.StatusUpdate)).Select(x => x.Id).FirstOrDefault(),
                Description = PoolActivityDescriptions.Deleted,
                CreatedBy = _claimsPrincipal.GetUserName(),
                UpdatedBy = _claimsPrincipal.GetUserName(),
            });

            _unitOfWork.Pool.Update(res);

            await _unitOfWork.SaveAsync();
            return res;
        }
    }
}
