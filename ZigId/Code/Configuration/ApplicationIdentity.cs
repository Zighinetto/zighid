using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ZigId.Code.Configuration
{
    class Identity : ConfigurationElement
    {

        [ConfigurationProperty(name: "name", IsKey = true, IsRequired = true)]
        public string UserId { get; set; }

        [ConfigurationProperty(name: "password", IsKey = false, IsRequired = true)]
        public string PasswordHash { get; set; }

        [ConfigurationProperty(name: "otpSecret", IsKey = false, IsRequired = false)]
        public string OtpSecret { get; set; }

        [ConfigurationCollection(typeof(KeyValueConfigurationElement),AddItemName="add",ClearItemsName="clear",RemoveItemName="remove")]
        public KeyValueConfigurationCollection Attributes { get; set; }


        public IDictionary<string, string> OpenIdAttributes { get; set; }

    }
}