// Decompiled with JetBrains decompiler
// Type: ns0.Class6`2
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using ns1;
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
label_6:
      int num1 = 1299680130;
      while (true)
      {
        int num2 = 1299680131;
        switch (num1 ^ num2)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_1);
            num1 = 1299680128;
            continue;
          case 1:
            stringBuilder.Append("{ mi = ");
            num1 = 1299680134;
            continue;
          case 2:
            goto label_6;
          case 3:
            stringBuilder.Append(" }");
            num1 = 1299680135;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_0);
            stringBuilder.Append(", attributes = ");
            num1 = 1299680131;
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
      if (class6 != null)
      {
label_4:
        int num1 = -467182382;
        while (true)
        {
          int num2 = -467182384;
          switch (num1 ^ num2)
          {
            case 0:
              goto label_4;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (EqualityComparer<T>.Default.Equals(this.gparam_0, class6.gparam_0))
              {
                num1 = -467182383;
                continue;
              }
              goto label_6;
            default:
              goto label_5;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return EqualityComparer<U>.Default.Equals(this.gparam_1, class6.gparam_1);
      }
label_6:
      return false;
    }

    [DebuggerHidden]
    public override int GetHashCode()
    {
      int num1 = -2055213769;
label_3:
      int num2 = -1507605399;
      while (true)
      {
        int num3 = -1507605400;
        switch (num2 ^ num3)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            num1 = -1521134295 * num1 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
            num2 = -1507605400;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return -1521134295 * num1 + EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
    }
  }
}
