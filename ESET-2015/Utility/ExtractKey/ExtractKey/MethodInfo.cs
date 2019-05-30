using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtractKey
{
    internal sealed class MethodAttribute_0<Method, Attribute>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Method CurrentMethod;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Attribute CurrentAttribute;

        [DebuggerHidden]
        public MethodAttribute_0(Method currentMethod, Attribute currentAttribute)
        {
            this.CurrentMethod = currentMethod;
            this.CurrentAttribute = currentAttribute;
        }

        [SpecialName]
        public Method GetCurrentMethod()
        {
            return this.CurrentMethod;
        }

        [SpecialName]
        public Attribute GetCurrentAttribute()
        {
            return this.CurrentAttribute;
        }

        [DebuggerHidden]
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{ Mi =");
            stringBuilder.Append(this.CurrentMethod);
            stringBuilder.Append(", Attribute =");
            stringBuilder.Append(this.CurrentAttribute);
            stringBuilder.Append(" }");
            return stringBuilder.ToString();
        }

        [DebuggerHidden]
        public override bool Equals(object obj)
        {
            MethodAttribute_0<Method, Attribute> h = obj as MethodAttribute_0<Method, Attribute>;
            if (h != null)
                return EqualityComparer<Attribute>.Default.Equals(this.CurrentAttribute, h.CurrentAttribute) &&
                    EqualityComparer<Method>.Default.Equals(this.CurrentMethod, h.CurrentMethod);
            return false;
        }

        [DebuggerHidden]
        public override int GetHashCode()
        {
            return -1521134295 * (222243715 + EqualityComparer<Method>.Default.GetHashCode(this.CurrentMethod)) +
                EqualityComparer<Attribute>.Default.GetHashCode(this.CurrentAttribute);
        }
    }
}
