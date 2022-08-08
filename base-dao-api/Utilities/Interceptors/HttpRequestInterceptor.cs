﻿using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using System.Security.Claims;

namespace base_dao_api.Utilities.Interceptors
{
    public class HttpRequestInterceptor : DefaultHttpRequestInterceptor
    {
        public override ValueTask OnCreateAsync(HttpContext context,
            IRequestExecutor requestExecutor, IQueryRequestBuilder requestBuilder,
            CancellationToken cancellationToken)
        {
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.Country, "us"));

            context.User.AddIdentity(identity);

            return base.OnCreateAsync(context, requestExecutor, requestBuilder,
                cancellationToken);
        }
    }

}
