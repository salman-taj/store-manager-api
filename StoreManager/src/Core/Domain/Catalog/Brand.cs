using StoreManager.Domain.Common;
using StoreManager.Domain.Common.Contracts;
using StoreManager.Domain.Contracts;

namespace StoreManager.Domain.Catalog
{
    public class Brand : AuditableEntity, IMustHaveTenant
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Tenant { get; set; }

        public Brand(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Brand Update(string name, string description)
        {
            if (name != null && !Name.NullToString().Equals(name)) Name = name;
            if (description != null && !Description.NullToString().Equals(description)) Description = description;
            return this;
        }
    }
}