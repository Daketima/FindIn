using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.Abstractions
{
    public abstract class Entity : IEntity
    {
        public long Id { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;

            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (GetType() != other.GetType())
                return false;
            if (Id == 0 || other.Id == 0)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if(ReferenceEquals(a, nul) && ReferenceEquals(b, null))
                return false;
            if(ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return true;
            
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b)
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
}
