using PBB.LMS.Debugging;

namespace PBB.LMS
{
    public class LMSConsts
    {
        public const string LocalizationSourceName = "LMS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d816f44cf41c477ab0c2a269a26bcfe0";
    }
}
