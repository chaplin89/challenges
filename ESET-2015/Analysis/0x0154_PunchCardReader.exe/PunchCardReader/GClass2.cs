// Decompiled with JetBrains decompiler
// Type: ns0.GClass2
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ns0
{
    public class GClass2
    {
        private static byte[] byte_0 = new byte[2]
        {
      (byte) 69,
      (byte) 82
        };
        private const string string_0 = "EsetCrackmePipe";
        private const int int_0 = 2000;
        private const int int_1 = 2000;
        private const int int_2 = 5000;
        private const int int_3 = 128;
        private const int int_4 = 256;
        protected NamedPipeClientStream namedPipeClientStream_0;
        private static byte[] byte_1;
        private ManualResetEvent manualResetEvent_0;
        private ManualResetEvent manualResetEvent_1;

        static GClass2()
        {
            byte[] numArray = new byte[2]
            {
        (byte) 79,
        (byte) 0
            };
            label_5:
            int num1 = -1418239619;
            while (true)
            {
                int num2 = -1418239620;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        numArray[1] = (byte)75;
                        num1 = -1418239618;
                        continue;
                    case 2:
                        GClass2.byte_1 = numArray;
                        num1 = -1418239617;
                        continue;
                    case 3:
                        goto label_4;
                    default:
                        goto label_6;
                }
            }
            label_6:
            return;
            label_4:;
        }

        public byte[] method_0(int int_5, byte[] byte_2)
        {
            byte[] numArray = null;
            try
            {
                this.method_2();
                byte[] byte_2_1 = null;
                byte[] byte_2_2 = null;
                byte[] byte_2_3 = null;
                byte[] byte_2_4 = null;
                label_14:
                int num1 = 371085162;
                while (true)
                {
                    int num2 = 371085152;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            byte_2_4 = new byte[4];
                            num1 = 371085161;
                            continue;
                        case 1:
                            if (byte_2_1.Length == GClass2.byte_0.Length)
                            {
                                int num3;
                                int num4;
                                if (Enumerable.SequenceEqual<byte>((IEnumerable<byte>)byte_2_1, (IEnumerable<byte>)GClass2.byte_0))
                                {
                                    int num5 = 371085154;
                                    num4 = 371085154;
                                    num3 = num5;
                                }
                                else
                                {
                                    num3 = 371085160;
                                    num4 = 371085160;
                                }
                                num1 = num3;
                                continue;
                            }
                            goto label_15;
                        case 2:
                            numArray = (byte[])null;
                            num1 = 371085155;
                            continue;
                        case 3:
                            goto label_17;
                        case 4:
                            this.method_5(byte_2_1);
                            num1 = 371085153;
                            continue;
                        case 5:
                            this.method_5(byte_2_3);
                            this.method_5(byte_2_4);
                            byte_2_1 = new byte[BitConverter.ToUInt32(byte_2_4, 0)];
                            num1 = 371085156;
                            continue;
                        case 6:
                            goto label_14;
                        case 7:
                            byte_2_3 = new byte[2];
                            num1 = 371085152;
                            continue;
                        case 9:
                            this.method_5(byte_2_2);
                            num1 = 371085157;
                            continue;
                        case 10:
                            this.method_4(new byte[3]
                            {
                (byte) 1,
                (byte) (int_5 & (int) byte.MaxValue),
                (byte) ((int_5 & 65280) >> 8)
                            });
                            byte_2_2 = new byte[1];
                            num1 = 371085159;
                            continue;
                        default:
                            goto label_15;
                    }
                }
                label_15:
                numArray = this.method_3(byte_2_1, byte_2);
            }
            catch (Exception ex)
            {
                throw new GException1("Pipe communication failed!", ex);
            }
            label_17:
            return numArray;
        }

        public bool method_1(GClass1.GEnum2 genum2_0)
        {
            bool flag = true;
            try
            {
                byte[] byte_2_1 = null;
                byte[] byte_2_2 = null;
                byte[] byte_2_3 = null;
                byte[] byte_2_4 = null;
                this.method_2();
                this.method_4(new byte[3]
                {
          (byte) 2,
          (byte) (genum2_0 & (GClass1.GEnum2) 255),
          (byte) ((uint) (genum2_0 & GClass1.GEnum2.const_0) >> 8)
                });
                label_16:
                int num1 = -1182441620;
                while (true)
                {
                    int num2 = -1182441621;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            flag = false;
                            num1 = -1182441622;
                            continue;
                        case 2:
                            goto label_16;
                        case 3:
                            flag = true;
                            num1 = -1182441630;
                            continue;
                        case 4:
                            byte_2_3 = new byte[4];
                            byte_2_4 = new byte[2];
                            num1 = -1182441631;
                            continue;
                        case 5:
                            int num3;
                            int num4;
                            if (Enumerable.SequenceEqual<byte>((IEnumerable<byte>)byte_2_4, (IEnumerable<byte>)GClass2.byte_1))
                            {
                                int num5 = -1182441624;
                                num4 = -1182441624;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = -1182441621;
                                num4 = -1182441621;
                            }
                            num1 = num3;
                            continue;
                        case 6:
                            this.method_5(byte_2_4);
                            int num6;
                            int num7;
                            if (byte_2_4.Length != GClass2.byte_1.Length)
                            {
                                int num5 = -1182441621;
                                num7 = -1182441621;
                                num6 = num5;
                            }
                            else
                            {
                                num6 = -1182441618;
                                num7 = -1182441618;
                            }
                            num1 = num6;
                            continue;
                        case 7:
                            byte_2_1 = new byte[1];
                            byte_2_2 = new byte[2];
                            num1 = -1182441617;
                            continue;
                        case 8:
                            this.method_5(byte_2_2);
                            this.method_5(byte_2_3);
                            num1 = -1182441619;
                            continue;
                        case 10:
                            this.method_5(byte_2_1);
                            num1 = -1182441629;
                            continue;
                        default:
                            goto label_18;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new GException1("Pipe communication failed!", ex);
            }
            label_18:
            return flag;
        }

        private void method_2()
        {
            this.namedPipeClientStream_0 = new NamedPipeClientStream(".", "EsetCrackmePipe", PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.Impersonation);
            this.namedPipeClientStream_0.Connect(2000);
        }

        private byte[] method_3(byte[] byte_2, byte[] byte_3)
        {
            int num1 = byte_2.Length % 16;
            byte[] outputBuffer = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)byte_2, byte_2.Length - num1));
            AesManaged aesManaged = new AesManaged();
            try
            {
                aesManaged.Mode = CipherMode.ECB;
                ICryptoTransform decryptor = null;
                label_8:
                int num2 = -869577780;
                while (true)
                {
                    int num3 = -869577779;
                    switch (num2 ^ num3)
                    {
                        case 0:
                            aesManaged.Key = Encoding.ASCII.GetBytes(GClass1.smethod_2(byte_3));
                            decryptor = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV);
                            num2 = -869577783;
                            continue;
                        case 1:
                            aesManaged.BlockSize = 128;
                            num2 = -869577781;
                            continue;
                        case 3:
                            goto label_8;
                        case 4:
                            decryptor.TransformBlock(byte_2, 0, outputBuffer.Length, outputBuffer, 0);
                            num2 = -869577777;
                            continue;
                        case 5:
                            aesManaged.Padding = PaddingMode.None;
                            num2 = -869577779;
                            continue;
                        case 6:
                            aesManaged.KeySize = 256;
                            num2 = -869577784;
                            continue;
                        default:
                            goto label_14;
                    }
                }
            }
            finally
            {
                if (aesManaged != null)
                {
                    label_12:
                    int num2 = -869577780;
                    while (true)
                    {
                        int num3 = -869577779;
                        switch (num2 ^ num3)
                        {
                            case 1:
                                aesManaged.Clear();
                                num2 = -869577779;
                                continue;
                            case 2:
                                goto label_12;
                            default:
                                goto label_13;
                        }
                    }
                }
                label_13:;
            }
            label_14:
            byte[] numArray = Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)byte_2, byte_2.Length - num1));
            return Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)outputBuffer, (IEnumerable<byte>)numArray));
        }

        private void method_4(byte[] byte_2)
        {
            this.manualResetEvent_0 = new ManualResetEvent(false);
            label_4:
            int num1 = -1112273704;
            while (true)
            {
                int num2 = -1112273702;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_3;
                    case 1:
                        goto label_5;
                    case 2:
                        this.namedPipeClientStream_0.BeginWrite(byte_2, 0, byte_2.Length, new AsyncCallback(this.method_7), (object)this.namedPipeClientStream_0);
                        num1 = -1112273701;
                        continue;
                    case 3:
                        goto label_4;
                    default:
                        goto label_8;
                }
            }
            label_8:
            return;
            label_3:
            return;
            label_5:
            if (!this.manualResetEvent_0.WaitOne(2000))
                throw new GException1("Write timeout!");
        }

        private void method_5(byte[] byte_2)
        {
            Class1 class1 = new Class1(this.namedPipeClientStream_0, byte_2);
            this.manualResetEvent_1 = new ManualResetEvent(false);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.namedPipeClientStream_0.BeginRead(class1.A_byte, 0, class1.A_byte.Length, new AsyncCallback(this.method_6), (object)class1);
            if (!this.manualResetEvent_1.WaitOne(5000))
                throw new GException1("Read timeout!");
        }

        private void method_6(IAsyncResult iasyncResult_0)
        {
            Class1 class1 = (Class1)iasyncResult_0.AsyncState;
            // ISSUE: reference to a compiler-generated method
            int int_1 = class1.A_Pipe.EndRead(iasyncResult_0);
            label_10:
            int num1 = -2058269143;
            while (true)
            {
                int num2 = -2058269144;
                switch (num1 ^ num2)
                {
                    case 0:
                        this.manualResetEvent_1.Set();
                        num1 = -2058269141;
                        continue;
                    case 1:
                        int num3;
                        int num4;
                        // ISSUE: reference to a compiler-generated method
                        if (class1.method_6(int_1) != class1.A_byte.Length)
                        {
                            int num5 = -2058269139;
                            num4 = -2058269139;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = -2058269144;
                            num4 = -2058269144;
                        }
                        num1 = num3;
                        continue;
                    case 2:
                        goto label_10;
                    case 3:
                        goto label_9;
                    case 4:
                        goto label_12;
                    case 5:
                        // ISSUE: reference to a compiler-generated method
                        if (class1.A_Pipe.IsConnected)
                        {
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            class1.A_Pipe.BeginRead(class1.A_byte, class1.A_int, class1.A_byte.Length - class1.A_int, new AsyncCallback(this.method_6), (object)class1);
                            num1 = -2058269140;
                            continue;
                        }
                        goto label_11;
                    default:
                        goto label_13;
                }
            }
            label_11:
            return;
            label_9:
            return;
            label_13:
            return;
            label_12:;
        }

        private void method_7(IAsyncResult iasyncResult_0)
        {
            NamedPipeClientStream pipeClientStream = (NamedPipeClientStream)iasyncResult_0.AsyncState;
            label_4:
            int num1 = -2070964906;
            while (true)
            {
                int num2 = -2070964908;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_4;
                    case 1:
                        goto label_3;
                    case 2:
                        pipeClientStream.EndWrite(iasyncResult_0);
                        this.manualResetEvent_0.Set();
                        num1 = -2070964907;
                        continue;
                    default:
                        goto label_5;
                }
            }
            label_5:
            return;
            label_3:;
        }

        private enum Enum0
        {
            const_0 = 1,
            const_1 = 2,
            const_2 = 3,
        }
    }
}
