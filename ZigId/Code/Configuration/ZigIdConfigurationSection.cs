using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ZigId.Code.Configuration
{
    class ZigIdConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("identity")]
        public ApplicationIdentityCollection Identities
        {
            get;
            set;
        }

    }
}