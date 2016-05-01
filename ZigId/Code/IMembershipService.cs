using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ZigId.Code
{
    public interface IMembershipService
    {

        /// <summary>
        /// Creates a password hash at configuration time that will match the given plaintext password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string CreatePasswordHash(string password);

        /// <summary>
        /// Validates the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>Whether the given username and password is correct.</returns>
        bool ValidateUser(string userName, string password);

        /// <summary>
        /// Determines if additional authentication is required
        /// </summary>
        /// <param name="userName">User to authenticate</param>
        /// <returns>Whether the user requires an additional OTP authentication via companion app</returns>
        bool RequiresOtpAuthentication(string userName);

        /// <summary>
        /// Validates the user against the OTP token.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="otpToken">The token.</param>
        /// <returns>Whether the given token is correct for the user.</returns>
        bool ValidateOtpToken(string userName, string otpToken);
    }
}