using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using joke_Site_practice.Models;

namespace joke_Site_practice.Authorization
{
    public class JokesIsOwnerAuthorizationHandler: AuthorizationHandler<OperationAuthorizationRequirement, Joke>
    {
        UserManager<IdentityUser> _userManager;

        public JokesIsOwnerAuthorizationHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   Joke resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.DetailsOperationName &&
                requirement.Name != Constants.UpdateOperationName &&
                requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (resource.JokeUserId == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}