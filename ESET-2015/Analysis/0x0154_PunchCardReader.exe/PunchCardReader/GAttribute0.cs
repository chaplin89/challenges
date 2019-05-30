// Decompiled with JetBrains decompiler
// Type: ns0.GAttribute0
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System;

namespace ns0
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
  public class GAttribute0 : Attribute
  {
    public string string_0;

    public GAttribute0(string string_1)
    {
label_4:
      int num1 = -2089711055;
      while (true)
      {
        int num2 = -2089711056;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_4;
          case 1:
            this.string_0 = string_1;
            num1 = -2089711054;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_5:
      return;
label_3:;
    }
  }
}
