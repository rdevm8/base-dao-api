namespace base_dao_api.Utilities.Constants
{
 
    public static class PoolCodes
    {

        public const string Header  = "PSTATUS";

        public const string Open = "PSTATUS-OPEN";
        public const string Ongoing = "PSTATUS-ONGOING";
        public const string Closed = "PSTATUS-CLOSED";
    }

    public static class RoleCodes
    {
        public const string Header = "ROLE";

        public const string System = "ROLE-SYSTEM";
        public const string Admin = "ROLE-ADMIN";
        public const string Normal = "ROLE-NORMAL";
    }

    public static class PoolFunderCodes
    {
        public const string Header = "PFSTATUS";

        public const string In = "PFSATUS-IN";
        public const string Out = "PFSATUS-OUT";

    }

    public static class PoolActivityCodes
    {
        public const string Header = "PASTATUS";

        public const string FunderUpdate = "PASTATUS-FU";
        public const string StatusUpdate = "PASTATUS-SU";
        public const string DetailsUpdate = "PASTATUS-PU";
    }
}
