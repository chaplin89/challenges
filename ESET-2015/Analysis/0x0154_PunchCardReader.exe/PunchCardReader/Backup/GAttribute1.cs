// Decompiled with JetBrains decompiler
// Type: ns0.GAttribute1
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System;

namespace ns0
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
  public class GAttribute1 : Attribute
  {
    public string string_0;

    public GAttribute1(string string_1)
    {
      this.string_0 = string_1;
    }
  }
}
