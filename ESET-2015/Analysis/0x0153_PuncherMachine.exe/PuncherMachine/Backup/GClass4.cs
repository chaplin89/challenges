// Decompiled with JetBrains decompiler
// Type: ns0.GClass4
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;

namespace ns0
{
  public class GClass4 : IComparable
  {
    public object object_0;
    public object object_1;
    public object object_2;

    public GClass4(object object_3, object object_4, object object_5)
    {
label_4:
      int num1 = -469079411;
      while (true)
      {
        int num2 = -469079409;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_4;
          case 1:
            this.object_1 = object_4;
            num1 = -469079412;
            continue;
          case 2:
            this.object_0 = object_3;
            num1 = -469079410;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this.object_2 = object_5;
    }

    int IComparable.CompareTo(object object_3)
    {
      return string.Compare(this.object_2 as string, ((GClass4) object_3).object_2 as string);
    }
  }
}
