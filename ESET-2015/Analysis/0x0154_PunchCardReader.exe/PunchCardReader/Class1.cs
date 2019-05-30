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
        public byte[] A_byte
        {
            get;
            private set;
        }
        public int A_int
        {
            get;
            private set;
        }
        public NamedPipeClientStream A_Pipe
        {
            get;
            private set;
        }
        public Class1(NamedPipeClientStream namedPipeClientStream, byte[] byte_0)
        {
            this.A_Pipe = namedPipeClientStream;
            this.A_byte = byte_0;
            this.A_int = 0;
        }

        public int method_6(int int_0)
        {
            Class1 d_ = this;
            int int_0_1 = d_.A_int + int_0;
            d_.A_int = int_0_1;
            return this.A_int;
        }
    }
}
