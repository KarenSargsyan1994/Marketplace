using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private Guid Value { get; }
        public ClassifiedAdId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");

            Value = value;
        }

        public static implicit operator Guid(ClassifiedAdId self) => self.Value;
       
        public static implicit operator ClassifiedAdId(string value)
             => new ClassifiedAdId(Guid.Parse(value));

        public override string ToString() => Value.ToString();
       
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ClassifiedAdId)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
