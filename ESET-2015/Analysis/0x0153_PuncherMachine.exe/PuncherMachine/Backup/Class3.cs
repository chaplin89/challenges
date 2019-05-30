// Decompiled with JetBrains decompiler
// Type: ns0.Class3
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System.IO.Pipes;

namespace ns0
{
  internal class Class3
  {
    public Class3(NamedPipeClientStream namedPipeClientStream_1, byte[] byte_1)
    {
      // ISSUE: reference to a compiler-generated method
      this.method_5(namedPipeClientStream_1);
      // ISSUE: reference to a compiler-generated method
      this.method_1(byte_1);
      // ISSUE: reference to a compiler-generated method
      this.method_3(0);
    }

    public int method_6(int int_1)
    {
      Class3 class3 = this;
      // ISSUE: reference to a compiler-generated method
      int int_1_1 = class3.method_2() + int_1;
      // ISSUE: reference to a compiler-generated method
      class3.method_3(int_1_1);
      // ISSUE: reference to a compiler-generated method
      return this.method_2();
    }
  }
}
