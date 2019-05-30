// Decompiled with JetBrains decompiler
// Type: ns0.Class3
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;
using System.IO.Pipes;

namespace PuncherMachine
{
    internal class Class3
    {
        public Class3(NamedPipeClientStream namedPipeClientStream_1, byte[] byte_1)
        {
            this.np = namedPipeClientStream_1;
            this.bytearray = byte_1;
            this.int_0 = 0;
        }
        public NamedPipeClientStream np { get; set; }

        public int int_0 { get; set; }

        public byte[] bytearray { get; set; }

        public int method_6(int int_1)
        {
            Class3 class3 = this;
            int int_1_1 = class3.int_0 + int_1;
            class3.int_0 = int_1_1;
            return this.int_0;
        }
    }
}
