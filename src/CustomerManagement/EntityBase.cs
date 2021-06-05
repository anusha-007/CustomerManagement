using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace CustomerManagement
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }

        public bool HasChanges { get; set; }

        public bool IsValid => Validate();
        public abstract bool Validate();  // abstract doesn't have implementation
    }
}