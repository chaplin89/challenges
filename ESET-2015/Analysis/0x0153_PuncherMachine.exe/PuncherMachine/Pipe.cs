// Decompiled with JetBrains decompiler
// Type: ns0.GClass2
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace PuncherMachine
{
    public class Pipe
    {
        private static byte[] byte_0 = new byte[2]
        {
      (byte) 69,
      (byte) 82
        };
        private static byte[] byte_1 = new byte[2]
        {
      (byte) 79,
      (byte) 75
        };
        protected NamedPipeClientStream namedPipe;
        private ManualResetEvent endWriteEvent;
        private ManualResetEvent endReadEvent;

        public byte[] GetAndDecrypt(int int_5, byte[] byte_2)
        {
            byte[] numArray = null;
            byte[] byte_2_1 = null;
            byte[] byte_2_2 = null;
            byte[] byte_2_3 = null;
            uint num3 = 0;
            try
            {
                this.ConnectPipe();
                label_16:
                int num1 = -2007991692;
                while (true)
                {
                    int num2 = -2007991695;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            this.ReadPipe(byte_2_2);
                            this.ReadPipe(byte_2_3);
                            num1 = -2007991694;
                            continue;
                        case 1:
                            int num4;
                            int num5;
                            if (Enumerable.SequenceEqual(byte_2_1, byte_0))
                            {
                                int num6 = -2007991687;
                                num5 = -2007991687;
                                num4 = num6;
                            }
                            else
                            {
                                num4 = -2007991685;
                                num5 = -2007991685;
                            }
                            num1 = num4;
                            continue;
                        case 3:
                            num3 = BitConverter.ToUInt32(byte_2_3, 0);
                            num1 = -2007991691;
                            continue;
                        case 4:
                            byte_2_1 = new byte[num3];
                            this.ReadPipe(byte_2_1);
                            num1 = -2007991689;
                            continue;
                        case 5:
                            this.WritePipe(new byte[3]
                            {
                 1,
                (byte) (int_5 &  byte.MaxValue),
                (byte) ((int_5 & 65280) >> 8)
                            });
                            byte[] byte_2_4 = new byte[1];
                            byte_2_2 = new byte[2];
                            byte_2_3 = new byte[4];
                            this.ReadPipe(byte_2_4);
                            num1 = -2007991695;
                            continue;
                        case 6:
                            int num7;
                            int num8;
                            if (byte_2_1.Length == byte_0.Length)
                            {
                                int num6 = -2007991696;
                                num8 = -2007991696;
                                num7 = num6;
                            }
                            else
                            {
                                num7 = -2007991685;
                                num8 = -2007991685;
                            }
                            num1 = num7;
                            continue;
                        case 7:
                            goto label_16;
                        case 8:
                            numArray = (byte[])null;
                            num1 = -2007991693;
                            continue;
                        case 10:
                            numArray = this.DecryptAES(byte_2_1, byte_2);
                            num1 = -2007991688;
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
            return numArray;
        }

        public bool WriteShit(Utility.Response genum2_0)
        {
            try
            {
                byte[] byte_2_1 = null;
                byte[] byte_2_2 = null;
                byte[] byte_2_3 = null;
                byte[] byte_2_4 = null;
                this.ConnectPipe();
                label_15:
                int num1 = -476638758;
                while (true)
                {
                    int num2 = -476638759;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            goto label_15;
                        case 1:
                            ReadPipe(byte_2_4);
                            num1 = -476638754;
                            continue;
                        case 2:
                            int num3;
                            int num4;
                            if (Enumerable.SequenceEqual(byte_2_2, byte_1))
                            {
                                int num5 = -476638768;
                                num4 = -476638768;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = -476638755;
                                num4 = -476638755;
                            }
                            num1 = num3;
                            continue;
                        case 3:
                            WritePipe(new byte[3]
                            {
                 2,
                (byte) (genum2_0 & (Utility.Response) 255),
                (byte) ((uint) (genum2_0 & Utility.Response.const_0) >> 8)
                            });
                            num1 = -476638756;
                            continue;
                        case 5:
                            byte_2_3 = new byte[1];
                            byte_2_4 = new byte[2];
                            num1 = -476638767;
                            continue;
                        case 6:
                            this.ReadPipe(byte_2_2);
                            int num6;
                            int num7;
                            if (byte_2_2.Length == byte_1.Length)
                            {
                                int num5 = -476638757;
                                num7 = -476638757;
                                num6 = num5;
                            }
                            else
                            {
                                num6 = -476638755;
                                num7 = -476638755;
                            }
                            num1 = num6;
                            continue;
                        case 7:
                            this.ReadPipe(byte_2_1);
                            num1 = -476638753;
                            continue;
                        case 8:
                            byte_2_1 = new byte[4];
                            byte_2_2 = new byte[2];
                            this.ReadPipe(byte_2_3);
                            num1 = -476638760;
                            continue;
                        case 9:
                            goto label_17;
                        default:
                            goto label_16;
                    }
                }
                label_16:
                return false;
                label_17:
                return true;
            }
            catch (Exception ex)
            {
                throw new GException1("Pipe communication failed!", ex);
            }
        }

        private void ConnectPipe()
        {
            namedPipe = new NamedPipeClientStream(".", "EsetCrackmePipe", PipeDirection.InOut, PipeOptions.Asynchronous, TokenImpersonationLevel.Impersonation);
            namedPipe.Connect(2000);
            return;
        }

        private byte[] DecryptAES(byte[] block, byte[] key)
        {
            int num1 = block.Length % 16;
            byte[] outputBuffer = Enumerable.ToArray<byte>(Enumerable.Take<byte>((IEnumerable<byte>)block, block.Length - num1));
            using (AesManaged aesManaged = new AesManaged())
            {
                aesManaged.Mode = CipherMode.ECB;
                ICryptoTransform decryptor = null;
                label_8:
                int num2 = 382331230;
                while (true)
                {
                    int num3 = 382331227;
                    switch (num2 ^ num3)
                    {
                        case 0:
                            goto label_8;
                        case 1:
                            aesManaged.Padding = PaddingMode.None;
                            num2 = 382331229;
                            continue;
                        case 3:
                            aesManaged.KeySize = 256;
                            num2 = 382331226;
                            continue;
                        case 4:
                            decryptor.TransformBlock(block, 0, outputBuffer.Length, outputBuffer, 0);
                            num2 = 382331225;
                            continue;
                        case 5:
                            aesManaged.BlockSize = 128;
                            num2 = 382331224;
                            continue;
                        case 6:
                            aesManaged.Key = Encoding.ASCII.GetBytes(Utility.GetKeyString(key));
                            decryptor = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV);
                            num2 = 382331231;
                            continue;
                        default:
                            goto label_12;
                    }
                }
            }
            label_12:
            byte[] numArray = Enumerable.ToArray<byte>(Enumerable.Skip<byte>((IEnumerable<byte>)block, block.Length - num1));
            return Enumerable.ToArray<byte>(Enumerable.Concat<byte>((IEnumerable<byte>)outputBuffer, (IEnumerable<byte>)numArray));
        }

        private void WritePipe(byte[] byte_2)
        {
            this.endWriteEvent = new ManualResetEvent(false);
            label_8:
            int num1 = -921451631;
            while (true)
            {
                int num2 = -921451629;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_7;
                    case 1:
                        goto label_9;
                    case 2:
                        this.namedPipe.BeginWrite(byte_2, 0, byte_2.Length, new AsyncCallback(this.EndWrite), (object)this.namedPipe);
                        num1 = -921451632;
                        continue;
                    case 3:
                        int num3;
                        int num4;
                        if (this.endWriteEvent.WaitOne(2000))
                        {
                            int num5 = -921451629;
                            num4 = -921451629;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = -921451630;
                            num4 = -921451630;
                        }
                        num1 = num3;
                        continue;
                    case 4:
                        goto label_8;
                    default:
                        goto label_10;
                }
            }
            label_10:
            return;
            label_7:
            return;
            label_9:
            throw new GException1("Write timeout!");
        }

        private void ReadPipe(byte[] byte_2)
        {
            Class3 class3 = new Class3(this.namedPipe, byte_2);
            this.endReadEvent = new ManualResetEvent(false);
            label_8:
            int num1 = -813193346;
            while (true)
            {
                int num2 = -813193350;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_9;
                    case 1:
                        goto label_7;
                    case 2:
                        int num3;
                        int num4;
                        if (this.endReadEvent.WaitOne(5000))
                        {
                            int num5 = -813193349;
                            num4 = -813193349;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = -813193350;
                            num4 = -813193350;
                        }
                        num1 = num3;
                        continue;
                    case 3:
                        goto label_8;
                    case 4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        this.namedPipe.BeginRead(class3.bytearray, 0, class3.bytearray.Length, new AsyncCallback(this.EndRead), (object)class3);
                        num1 = -813193352;
                        continue;
                    default:
                        goto label_10;
                }
            }
            label_10:
            return;
            label_7:
            return;
            label_9:
            throw new GException1("Read timeout!");
        }

        private void EndRead(IAsyncResult iasyncResult_0)
        {
            Class3 class3 = (Class3)iasyncResult_0.AsyncState;
            label_10:
            int num1 = 607391653;
            while (true)
            {
                int num2 = 607391652;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_9;
                    case 1:
                        // ISSUE: reference to a compiler-generated method
                        int int_1 = class3.np.EndRead(iasyncResult_0);
                        // ISSUE: reference to a compiler-generated method
                        if (class3.method_6(int_1) != class3.bytearray.Length)
                            goto case 2;
                        else
                            goto label_11;
                    case 2:
                        int num3;
                        int num4;
                        // ISSUE: reference to a compiler-generated method
                        if (class3.np.IsConnected)
                        {
                            int num5 = 607391655;
                            num4 = 607391655;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = 607391652;
                            num4 = 607391652;
                        }
                        num1 = num3;
                        continue;
                    case 3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        class3.np.BeginRead(class3.bytearray, class3.int_0, class3.bytearray.Length - class3.int_0, new AsyncCallback(EndRead), class3);
                        num1 = 607391652;
                        continue;
                    case 4:
                        goto label_10;
                    default:
                        goto label_7;
                }
            }
            label_7:
            return;
            label_9:
            return;
            label_11:
            this.endReadEvent.Set();
        }

        private void EndWrite(IAsyncResult iasyncResult_0)
        {
            NamedPipeClientStream pipeClientStream = (NamedPipeClientStream)iasyncResult_0.AsyncState;
            label_4:
            int num1 = -1234612241;
            while (true)
            {
                int num2 = -1234612243;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_4;
                    case 1:
                        goto label_3;
                    case 2:
                        pipeClientStream.EndWrite(iasyncResult_0);
                        this.endWriteEvent.Set();
                        num1 = -1234612244;
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
