namespace base_dao_api.Utilities.Constants
{
    public static class ErrorDescriptions
    {
        public const string EntityNotFound = "Entity not found!";

        public const string NotAuthorized = "User is not authorized to perform this transaction!";

        public const string PoolShouldBeOpen = "Pool must be OPEN to perform this transaction!";

        public const string FunderWithdrawn = "Pool funder has already WITHDRAWN!";

    }
}
