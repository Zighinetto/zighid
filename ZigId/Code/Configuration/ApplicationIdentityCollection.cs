using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ZigId.Code.Configuration
{
    class ApplicationIdentityCollection : ConfigurationElementCollection
    {
        public Identity this[int index]
        {
            get { return (Identity)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(Identity ApplicationIdentity)
        {
            BaseAdd(ApplicationIdentity);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new Identity();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Identity)element).UserId;
        }

        public void Remove(Identity ApplicationIdentity)
        {
            BaseRemove(ApplicationIdentity.UserId);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }
}
