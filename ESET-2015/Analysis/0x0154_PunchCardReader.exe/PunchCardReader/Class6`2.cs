// Decompiled with JetBrains decompiler
// Type: ns0.Class6`2
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0
{
  [CompilerGenerated]
  internal sealed class Class6<T, U>
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T gparam_0;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly U gparam_1;

    [DebuggerHidden]
    public Class6(T gparam_2, U gparam_3)
    {
      // ISSUE: reference to a compiler-generated field
      this.gparam_0 = gparam_2;
      // ISSUE: reference to a compiler-generated field
      this.gparam_1 = gparam_3;
    }

    [SpecialName]
    public T method_0()
    {
      // ISSUE: reference to a compiler-generated field
      return this.gparam_0;
    }

    [SpecialName]
    public U method_1()
    {
      // ISSUE: reference to a compiler-generated field
      return this.gparam_1;
    }

    [DebuggerHidden]
    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("{ Mi = ");
label_6:
      int num1 = -2001615849;
      while (true)
      {
        int num2 = -2001615850;
        switch (num1 ^ num2)
        {
          case 0:
            stringBuilder.Append(" }");
            num1 = -2001615853;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_0);
            num1 = -2001615852;
            continue;
          case 2:
            stringBuilder.Append(", Attribute = ");
            num1 = -2001615854;
            continue;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_1);
            num1 = -2001615850;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return stringBuilder.ToString();
    }

    [DebuggerHidden]
    public override bool Equals(object object_0)
    {
      // ISSUE: variable of a compiler-generated type
      Class6<T, U> class6 = object_0 as Class6<T, U>;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class6 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class6.gparam_0))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return EqualityComparer<U>.Default.Equals(this.gparam_1, class6.gparam_1);
      }
      return false;
    }

    [DebuggerHidden]
    public override int GetHashCode()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return -1521134295 * (222243715 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0)) + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
    }
  }
}
