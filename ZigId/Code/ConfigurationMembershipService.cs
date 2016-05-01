using DevOne.Security.Cryptography.BCrypt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using TwoStepsAuthenticator;
using ZigId.Code.Configuration;

namespace ZigId.Code
{
    public class ConfigurationMembershipService : IMembershipService
    {

        private const int NUM_ROUNDS = 160;

        TimeAuthenticator authenticator = new TimeAuthenticator();

        private readonly Dictionary<string, Identity> identities = new Dictionary<string, Identity>();

        public ConfigurationMembershipService()
        {
            ZigIdConfigurationSection section = (ZigIdConfigurationSection)ConfigurationManager.GetSection("zigId");

            foreach (Identity id in section.Identities)
            {
                identities.Add(id.UserId, id);
            }
        }

        public int MinPasswordLength
        {
            get;
            set;
        }

        public string CreatePasswordHash(string password)
        {
            return BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt(NUM_ROUNDS));
        }

        public bool ValidateUser(string userName, string password)
        {
            string hash;
            Identity user = identities[userName];
            if (user == null) throw new Exception("User not found: "+userName);
            hash = user.PasswordHash;

            return BCryptHelper.CheckPassword(password, hash);
        }

        public bool RequiresOtpAuthentication(string userName)
        {
            Identity user = identities[userName];
            if (user == null) throw new Exception("User not found: " + userName);

            return !String.IsNullOrEmpty(user.OtpSecret);
        }

        public bool ValidateOtpToken(string userName, string otpToken)
        {
            Identity user = identities[userName];
            if (user == null) throw new Exception("User not found: " + userName);
            if (String.IsNullOrEmpty(user.OtpSecret)) throw new Exception("User has no OTP enabled: " + userName);

            return authenticator.CheckCode(user.OtpSecret, otpToken, user);
        }

        
    }
}