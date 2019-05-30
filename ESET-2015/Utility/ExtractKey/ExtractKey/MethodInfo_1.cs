using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractKey
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;
    [CompilerGenerated]
    internal sealed class MethodAttribute_1<Method, Attribute>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Method CurrentMethod;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Attribute CurrentAttribute;

        [DebuggerHidden]
        public MethodAttribute_1(Method gparam_0, Attribute gparam_1)
        {
            this.CurrentMethod = gparam_0;
            this.CurrentAttribute = gparam_1;
            return;
        }

        [SpecialName]
        public Method GetMethod()
        {
            return this.CurrentMethod;
        }

        [SpecialName]
        public Attribute GetAttribute()
        {
            return this.CurrentAttribute;
        }

        [DebuggerHidden]
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{ mi =");
            stringBuilder.Append(this.CurrentMethod);
            stringBuilder.Append(", attributes =");
            stringBuilder.Append(this.CurrentAttribute);
            stringBuilder.Append(" }");
            return stringBuilder.ToString();
        }

        [DebuggerHidden]
        public override bool Equals(object obj)
        {
            MethodAttribute_1<Method, Attribute> h = obj as MethodAttribute_1<Method, Attribute>;
            if (h != null)
                return EqualityComparer<Attribute>.Default.Equals(this.CurrentAttribute, h.CurrentAttribute) &&
                    EqualityComparer<Method>.Default.Equals(this.CurrentMethod, h.CurrentMethod);
            return false;
        }

        [DebuggerHidden]
        public override int GetHashCode()
        {
            int num1 = 293814479 + EqualityComparer<Method>.Default.GetHashCode(this.CurrentMethod);
            num1 = -1521134295 * num1 + EqualityComparer<Attribute>.Default.GetHashCode(this.CurrentAttribute);
            return num1;
        }
    }
}