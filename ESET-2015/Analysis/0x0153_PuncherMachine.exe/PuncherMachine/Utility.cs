// Decompiled with JetBrains decompiler
// Type: ns0.GClass1
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PuncherMachine
{
    public static class Utility
    {
        public static void CopyStream(Stream stream_0, Stream stream_1)
        {
            byte[] buffer = new byte[8192];
            label_8:
            int count;
            int num1;
            int num2;
            if ((count = stream_0.Read(buffer, 0, buffer.Length)) <= 0)
            {
                num1 = -343980437;
                num2 = -343980437;
            }
            else
                goto label_7;
            label_2:
            while (true)
            {
                int num3 = -343980437;
                switch (num1 ^ num3)
                {
                    case 0:
                        goto label_9;
                    case 1:
                        stream_1.Write(buffer, 0, count);
                        num1 = -343980439;
                        continue;
                    case 2:
                        goto label_8;
                    case 3:
                        num1 = -343980438;
                        continue;
                    default:
                        goto label_6;
                }
            }
            label_6:
            return;
            label_9:
            return;
            label_7:
            int num4 = -343980438;
            num2 = -343980438;
            num1 = num4;
            goto label_2;
        }

        public static byte[] ComputeMD5(string path)
        {
            FileStream fileStream = File.OpenRead(path);
            MD5 md5 = MD5.Create();
            byte[] hash;
            try
            {
                hash = md5.ComputeHash((Stream)fileStream);
            }
            finally
            {
                if (md5 != null)
                {
                    label_5:
                    int num1 = -1692838931;
                    while (true)
                    {
                        int num2 = -1692838932;
                        switch (num1 ^ num2)
                        {
                            case 1:
                                md5.Clear();
                                num1 = -1692838932;
                                continue;
                            case 2:
                                goto label_5;
                            default:
                                goto label_6;
                        }
                    }
                }
                label_6:;
            }
            fileStream.Close();
            return hash;
        }

        public static string GetKeyString(byte[] byte_0)
        {
            StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
            byte[] numArray = byte_0;
            int index = 0;
            label_8:
            int num1;
            int num2;
            if (index < numArray.Length)
            {
                num1 = -440948081;
                num2 = -440948081;
            }
            else
                goto label_7;
            label_2:
            byte num4 = 0;
            while (true)
            {
                int num3 = -440948082;
                switch (num1 ^ num3)
                {
                    case 0:
                        stringBuilder.AppendFormat("{0:x2}", (object)num4);
                        ++index;
                        num1 = -440948084;
                        continue;
                    case 1:
                        num4 = numArray[index];
                        num1 = -440948082;
                        continue;
                    case 2:
                        goto label_8;
                    case 3:
                        num1 = -440948081;
                        continue;
                    default:
                        goto label_9;
                }
            }
            label_9:
            return stringBuilder.ToString();
            label_7:
            int num5 = -440948086;
            num2 = -440948086;
            num1 = num5;
            goto label_2;
        }

        public enum Request
        {
            const_0 = 65280,
            const_1 = 65281,
            const_2 = 65282,
            const_3 = 65284,
            const_4 = 65285,
        }

        public enum Response
        {
            const_0 = 65280,
            const_1 = 65281,
        }
    }
}
