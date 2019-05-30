// Decompiled with JetBrains decompiler
// Type: ns0.Class7`2
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace PuncherMachine
{
    [CompilerGenerated]
  internal sealed class Class7<T, U>
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly T gparam_0;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly U gparam_1;

    [DebuggerHidden]
    public Class7(T gparam_2, U gparam_3)
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
      int num1 = -1548471464;
      while (true)
      {
        int num2 = -1548471460;
        switch (num1 ^ num2)
        {
          case 0:
            stringBuilder.Append(", Attribute = ");
            num1 = -1548471463;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_0);
            num1 = -1548471460;
            continue;
          case 3:
            goto label_6;
          case 4:
            stringBuilder.Append("{ Mi = ");
            num1 = -1548471459;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append((object) this.gparam_1);
            stringBuilder.Append(" }");
            num1 = -1548471458;
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
      Class7<T, U> class7 = object_0 as Class7<T, U>;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class7 != null && EqualityComparer<T>.Default.Equals(this.gparam_0, class7.gparam_0))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return EqualityComparer<U>.Default.Equals(this.gparam_1, class7.gparam_1);
      }
      return false;
    }

    [DebuggerHidden]
    public override int GetHashCode()
    {
      int num1 = 457180363;
label_3:
      int num2 = 1431679326;
      while (true)
      {
        int num3 = 1431679324;
        switch (num2 ^ num3)
        {
          case 0:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated field
            num1 = -1521134295 * num1 + EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
            num2 = 1431679325;
            continue;
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
