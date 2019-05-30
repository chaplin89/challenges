// Decompiled with JetBrains decompiler
// Type: ns0.Class1
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System.IO.Pipes;

namespace ns0
{
  internal class Class1
  {
    public Class1(NamedPipeClientStream namedPipeClientStream_1, byte[] byte_1)
    {
label_6:
      int num1 = -1637650133;
      while (true)
      {
        int num2 = -1637650134;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated method
            this.method_5(namedPipeClientStream_1);
            num1 = -1637650130;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            this.method_3(0);
            num1 = -1637650134;
            continue;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: reference to a compiler-generated method
            this.method_1(byte_1);
            num1 = -1637650136;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return;
label_5:;
    }

    public int method_6(int int_1)
    {
      Class1 class1 = this;
      // ISSUE: reference to a compiler-generated method
      int int_1_1 = class1.method_2() + int_1;
      // ISSUE: reference to a compiler-generated method
      class1.method_3(int_1_1);
      // ISSUE: reference to a compiler-generated method
      return this.method_2();
    }
  }
}
