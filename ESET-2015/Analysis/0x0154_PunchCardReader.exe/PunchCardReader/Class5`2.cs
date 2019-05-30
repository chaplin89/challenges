// Decompiled with JetBrains decompiler
// Type: ns0.Class5`2
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
  internal sealed class Class5<T, U>
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T gparam_0;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly U gparam_1;

    [DebuggerHidden]
    public Class5(T gparam_2, U gparam_3)
    {
label_4:
      int num1 = -1354267767;
      while (true)
      {
        int num2 = -1354267765;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            this.gparam_0 = gparam_2;
            // ISSUE: reference to a compiler-generated field
            this.gparam_1 = gparam_3;
            num1 = -1354267766;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
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
label_4:
      int num1 = -1132206135;
      while (true)
      {
        int num2 = -1132206134;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_4;
          case 1:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_0);
            stringBuilder.Append(", attributes = ");
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_1);
            num1 = -1132206136;
            continue;
          case 3:
            stringBuilder.Append("{ mi = ");
            num1 = -1132206133;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      stringBuilder.Append(" }");
      return stringBuilder.ToString();
    }

    [DebuggerHidden]
    public override bool Equals(object object_0)
    {
      // ISSUE: variable of a compiler-generated type
      Class5<T, U> class5 = object_0 as Class5<T, U>;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class5 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class5.gparam_0))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return EqualityComparer<U>.Default.Equals(this.gparam_1, class5.gparam_1);
      }
      return false;
    }

    [DebuggerHidden]
    public override int GetHashCode()
    {
      // ISSUE: reference to a compiler-generated field
      int num1 = 293814479 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
label_3:
      int num2 = -1780339164;
      while (true)
      {
        int num3 = -1780339162;
        switch (num2 ^ num3)
        {
          case 0:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            num1 = -1521134295 * num1 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
            num2 = -1780339161;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return num1;
    }
  }
}
