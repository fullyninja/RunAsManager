using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RunAsManagerLib
{
    public class ImpersonationManager
    {
        const int LOGON32_LOGON_INTERACTIVE = 2;
        const int LOGON32_PROVIDER_DEFAULT = 0;

        /// <summary>
        /// Ran an application as the specified user.
        /// </summary>
        /// <param name="applicationPath"></param>
        /// <param name="username"></param>
        public void RunAs(string applicationPath, string username, string domain, string password)
        {
            IntPtr userToken = IntPtr.Zero;

            bool success = LogonUser(
                username,
                domain,
                password,
                LOGON32_LOGON_INTERACTIVE,
                LOGON32_PROVIDER_DEFAULT,
                out userToken
            );

            if (!success)
                throw new SecurityException("Logon failed.");

            var tempWinId = new WindowsIdentity(userToken);

            using (var impContent = tempWinId.Impersonate())
            {
                using (var proc = Process.Start(applicationPath))
                {
                }
            }
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(
           string lpszUsername,
           string lpszDomain,
           string lpszPassword,
           int dwLogonType,
           int dwLogonProvider,
           out IntPtr phToken
       );

    }
}
