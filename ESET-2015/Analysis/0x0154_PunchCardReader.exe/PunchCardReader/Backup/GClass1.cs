// Decompiled with JetBrains decompiler
// Type: ns0.GClass1
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using ns1;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
  public static class GClass1
  {
    public static void smethod_0(Stream stream_0, Stream stream_1)
    {
      byte[] buffer = new byte[8192];
label_9:
      int num1 = -1760085151;
      while (true)
      {
        int num2 = -1760085152;
        int count;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_9;
          case 1:
            num1 = -1760085149;
            continue;
          case 2:
            stream_1.Write(buffer, 0, count);
            num1 = -1760085149;
            continue;
          case 3:
            int num3;
            int num4;
            if ((count = stream_0.Read(buffer, 0, buffer.Length)) > 0)
            {
              int num5 = -1760085150;
              num4 = -1760085150;
              num3 = num5;
            }
            else
            {
              num3 = -1760085148;
              num4 = -1760085148;
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
label_8:;
    }

    public static byte[] smethod_1(string string_0)
    {
      FileStream fileStream = File.OpenRead(string_0);
      MD5 md5 = MD5.Create();
      byte[] hash;
      try
      {
        hash = md5.ComputeHash((Stream) fileStream);
      }
      finally
      {
        if (md5 != null)
        {
label_5:
          int num1 = 423487823;
          while (true)
          {
            int num2 = 423487822;
            switch (num1 ^ num2)
            {
              case 1:
                md5.Dispose();
                num1 = 423487822;
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

    public static string smethod_2(byte[] byte_0)
    {
      StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
      byte[] numArray = byte_0;
label_6:
      int num1 = -1851108120;
      while (true)
      {
        int num2 = -1851108119;
        int index;
        switch (num1 ^ num2)
        {
          case 1:
            index = 0;
            num1 = -1851108118;
            continue;
          case 2:
            goto label_6;
          case 3:
            num1 = -1851108119;
            continue;
          case 4:
            byte num3 = numArray[index];
            stringBuilder.AppendFormat("{0:x2}", (object) num3);
            ++index;
            num1 = -1851108119;
            continue;
          default:
            if (index < numArray.Length)
              goto case 4;
            else
              goto label_7;
        }
      }
label_7:
      return stringBuilder.ToString();
    }

    public enum GEnum1
    {
      const_0 = 65280,
      const_1 = 65281,
      const_2 = 65282,
      const_3 = 65284,
      const_4 = 65285,
    }

    public enum GEnum2
    {
      const_0 = 65280,
      const_1 = 65281,
    }
  }
}
