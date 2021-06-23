using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace joke_Site_practice.Authorization
{
    public static class JokeOperations
    {
        public static OperationAuthorizationRequirement Create =
          new OperationAuthorizationRequirement { Name = Constants.CreateOperationName };
        public static OperationAuthorizationRequirement Details =
          new OperationAuthorizationRequirement { Name = Constants.DetailsOperationName };
        public static OperationAuthorizationRequirement Update =
          new OperationAuthorizationRequirement { Name = Constants.UpdateOperationName };
        public static OperationAuthorizationRequirement Delete =
          new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };
    }

    public class Constants
    {
        public static readonly string CreateOperationName = "Create";
        public static readonly string DetailsOperationName = "Details";
        public static readonly string UpdateOperationName = "Update";
        public static readonly string DeleteOperationName = "Delete";
    }
}