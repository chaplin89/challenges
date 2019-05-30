// Decompiled with JetBrains decompiler
// Type: ns0.GAttribute0
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;

namespace PuncherMachine
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method)]
  public class GAttribute0 : Attribute
  {
    public string string_0;

    public GAttribute0(string string_1)
    {
      this.string_0 = string_1;
    }
  }
}
