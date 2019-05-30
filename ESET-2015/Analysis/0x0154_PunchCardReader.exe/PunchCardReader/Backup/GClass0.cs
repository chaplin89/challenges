// Decompiled with JetBrains decompiler
// Type: ns0.GClass0
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using ns1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
  public class GClass0
  {
    private const int int_0 = 22;
    private const int int_1 = 197;
    private const int int_2 = 7;
    private const int int_3 = 17;
    private const int int_4 = 3;
    private const int int_5 = 7;
    private const int int_6 = 600;
    private const int int_7 = 259;
    private const int int_8 = 80;
    private const int int_9 = 12;
    private const string string_0 = "punch_card_{0}.bmp";
    private const int int_10 = 1000;
    private volatile bool bool_0;
    private Hashtable hashtable_0;

    public GClass0()
    {
      this.hashtable_0 = new Hashtable();
      this.hashtable_0.Add((object) Convert.ToInt32("001000000000", 2), (object) '0');
      this.hashtable_0.Add((object) Convert.ToInt32("000100000000", 2), (object) '1');
      this.hashtable_0.Add((object) Convert.ToInt32("000010000000", 2), (object) '2');
      this.hashtable_0.Add((object) Convert.ToInt32("000001000000", 2), (object) '3');
      this.hashtable_0.Add((object) Convert.ToInt32("000000100000", 2), (object) '4');
      this.hashtable_0.Add((object) Convert.ToInt32("000000010000", 2), (object) '5');
      this.hashtable_0.Add((object) Convert.ToInt32("000000001000", 2), (object) '6');
      this.hashtable_0.Add((object) Convert.ToInt32("000000000100", 2), (object) '7');
      this.hashtable_0.Add((object) Convert.ToInt32("000000000010", 2), (object) '8');
      this.hashtable_0.Add((object) Convert.ToInt32("000000000001", 2), (object) '9');
      this.hashtable_0.Add((object) Convert.ToInt32("100100000000", 2), (object) 'A');
      this.hashtable_0.Add((object) Convert.ToInt32("100010000000", 2), (object) 'B');
      this.hashtable_0.Add((object) Convert.ToInt32("100001000000", 2), (object) 'C');
      this.hashtable_0.Add((object) Convert.ToInt32("100000100000", 2), (object) 'D');
      this.hashtable_0.Add((object) Convert.ToInt32("100000010000", 2), (object) 'E');
      this.hashtable_0.Add((object) Convert.ToInt32("100000001000", 2), (object) 'F');
      this.hashtable_0.Add((object) Convert.ToInt32("100000000100", 2), (object) 'G');
      this.hashtable_0.Add((object) Convert.ToInt32("100000000010", 2), (object) 'H');
      this.hashtable_0.Add((object) Convert.ToInt32("100000000001", 2), (object) 'I');
      this.hashtable_0.Add((object) Convert.ToInt32("010100000000", 2), (object) 'J');
      this.hashtable_0.Add((object) Convert.ToInt32("010010000000", 2), (object) 'K');
      this.hashtable_0.Add((object) Convert.ToInt32("010001000000", 2), (object) 'L');
      this.hashtable_0.Add((object) Convert.ToInt32("010000100000", 2), (object) 'M');
      this.hashtable_0.Add((object) Convert.ToInt32("010000010000", 2), (object) 'N');
      this.hashtable_0.Add((object) Convert.ToInt32("010000001000", 2), (object) 'O');
      this.hashtable_0.Add((object) Convert.ToInt32("010000000100", 2), (object) 'P');
      this.hashtable_0.Add((object) Convert.ToInt32("010000000010", 2), (object) 'Q');
      this.hashtable_0.Add((object) Convert.ToInt32("010000000001", 2), (object) 'R');
      this.hashtable_0.Add((object) Convert.ToInt32("001100000000", 2), (object) '/');
      this.hashtable_0.Add((object) Convert.ToInt32("001010000000", 2), (object) 'S');
      this.hashtable_0.Add((object) Convert.ToInt32("001001000000", 2), (object) 'T');
      this.hashtable_0.Add((object) Convert.ToInt32("001000100000", 2), (object) 'U');
      this.hashtable_0.Add((object) Convert.ToInt32("001000010000", 2), (object) 'V');
      this.hashtable_0.Add((object) Convert.ToInt32("001000001000", 2), (object) 'W');
      this.hashtable_0.Add((object) Convert.ToInt32("001000000100", 2), (object) 'X');
      this.hashtable_0.Add((object) Convert.ToInt32("001000000010", 2), (object) 'Y');
      this.hashtable_0.Add((object) Convert.ToInt32("001000000001", 2), (object) 'Z');
      this.hashtable_0.Add((object) Convert.ToInt32("101100000000", 2), (object) 'a');
      this.hashtable_0.Add((object) Convert.ToInt32("101010000000", 2), (object) 'b');
      this.hashtable_0.Add((object) Convert.ToInt32("101001000000", 2), (object) 'c');
      this.hashtable_0.Add((object) Convert.ToInt32("101000100000", 2), (object) 'd');
      this.hashtable_0.Add((object) Convert.ToInt32("101000010000", 2), (object) 'e');
      this.hashtable_0.Add((object) Convert.ToInt32("101000001000", 2), (object) 'f');
      this.hashtable_0.Add((object) Convert.ToInt32("101000000100", 2), (object) 'g');
      this.hashtable_0.Add((object) Convert.ToInt32("101000000010", 2), (object) 'h');
      this.hashtable_0.Add((object) Convert.ToInt32("101000000001", 2), (object) 'i');
      this.hashtable_0.Add((object) Convert.ToInt32("110100000000", 2), (object) 'j');
      this.hashtable_0.Add((object) Convert.ToInt32("110010000000", 2), (object) 'k');
      this.hashtable_0.Add((object) Convert.ToInt32("110001000000", 2), (object) 'l');
      this.hashtable_0.Add((object) Convert.ToInt32("110000100000", 2), (object) 'm');
      this.hashtable_0.Add((object) Convert.ToInt32("110000010000", 2), (object) 'n');
      this.hashtable_0.Add((object) Convert.ToInt32("110000001000", 2), (object) 'o');
      this.hashtable_0.Add((object) Convert.ToInt32("110000000100", 2), (object) 'p');
      this.hashtable_0.Add((object) Convert.ToInt32("110000000010", 2), (object) 'q');
      this.hashtable_0.Add((object) Convert.ToInt32("110000000001", 2), (object) 'r');
      this.hashtable_0.Add((object) Convert.ToInt32("011010000000", 2), (object) 's');
      this.hashtable_0.Add((object) Convert.ToInt32("011001000000", 2), (object) 't');
      this.hashtable_0.Add((object) Convert.ToInt32("011000100000", 2), (object) 'u');
      this.hashtable_0.Add((object) Convert.ToInt32("011000010000", 2), (object) 'v');
      this.hashtable_0.Add((object) Convert.ToInt32("011000001000", 2), (object) 'w');
      this.hashtable_0.Add((object) Convert.ToInt32("011000000100", 2), (object) 'x');
      this.hashtable_0.Add((object) Convert.ToInt32("011000000010", 2), (object) 'y');
      this.hashtable_0.Add((object) Convert.ToInt32("011000000001", 2), (object) 'z');
      this.hashtable_0.Add((object) Convert.ToInt32("000010000010", 2), (object) ':');
      this.hashtable_0.Add((object) Convert.ToInt32("000001000010", 2), (object) '#');
      this.hashtable_0.Add((object) Convert.ToInt32("000000100010", 2), (object) '@');
      this.hashtable_0.Add((object) Convert.ToInt32("000000010010", 2), (object) '\'');
      this.hashtable_0.Add((object) Convert.ToInt32("000000001010", 2), (object) '=');
      this.hashtable_0.Add((object) Convert.ToInt32("000000000110", 2), (object) '"');
      this.hashtable_0.Add((object) Convert.ToInt32("100001000010", 2), (object) '.');
      this.hashtable_0.Add((object) Convert.ToInt32("100000100010", 2), (object) '<');
      this.hashtable_0.Add((object) Convert.ToInt32("100000010010", 2), (object) '(');
      this.hashtable_0.Add((object) Convert.ToInt32("100000001010", 2), (object) '+');
      this.hashtable_0.Add((object) Convert.ToInt32("100000000110", 2), (object) '|');
      this.hashtable_0.Add((object) Convert.ToInt32("010001000010", 2), (object) '$');
      this.hashtable_0.Add((object) Convert.ToInt32("010000100010", 2), (object) '*');
      this.hashtable_0.Add((object) Convert.ToInt32("010000010010", 2), (object) ')');
      this.hashtable_0.Add((object) Convert.ToInt32("010000001010", 2), (object) ';');
      this.hashtable_0.Add((object) Convert.ToInt32("001001000010", 2), (object) ',');
      this.hashtable_0.Add((object) Convert.ToInt32("001000100010", 2), (object) '%');
      this.hashtable_0.Add((object) Convert.ToInt32("001000010010", 2), (object) '_');
      this.hashtable_0.Add((object) Convert.ToInt32("001000001010", 2), (object) '>');
      this.hashtable_0.Add((object) Convert.ToInt32("001000000110", 2), (object) '?');
      this.hashtable_0.Add((object) Convert.ToInt32("000000000000", 2), (object) ' ');
      this.hashtable_0.Add((object) Convert.ToInt32("010000000000", 2), (object) '-');
      this.hashtable_0.Add((object) Convert.ToInt32("100000000000", 2), (object) '&');
    }

    public string[] method_0()
    {
      List<string> list = new List<string>();
label_34:
      int num1 = 1711847806;
      while (true)
      {
        int num2 = 1711847790;
        Bitmap bitmap;
        int num3;
        int int_12;
        int num4;
        byte[] numArray;
        int int_11;
        int num5;
        StringBuilder stringBuilder;
        switch (num1 ^ num2)
        {
          case 0:
            if (bitmap.Width == 600)
            {
              int num6;
              int num7;
              if (bitmap.Height == 259)
              {
                int num8 = 1711847785;
                num7 = 1711847785;
                num6 = num8;
              }
              else
              {
                num6 = 1711847786;
                num7 = 1711847786;
              }
              num1 = num6;
              continue;
            }
            goto label_35;
          case 1:
            num1 = 1711847787;
            continue;
          case 2:
            int_11 += 7;
            num1 = 1711847787;
            continue;
          case 3:
            num5 = 0;
            num3 = 1;
            int_12 = 197;
            num1 = 1711847782;
            continue;
          case 4:
            goto label_35;
          case 5:
            if (int_11 >= 582)
            {
              list.Add(stringBuilder.ToString().TrimEnd(' '));
              bitmap.Dispose();
              num1 = 1711847779;
              continue;
            }
            goto case 3;
          case 6:
            stringBuilder = new StringBuilder();
            num1 = 1711847783;
            continue;
          case 7:
            BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            numArray = new byte[bitmapdata.Height * bitmapdata.Stride];
            Marshal.Copy(bitmapdata.Scan0, numArray, 0, numArray.Length);
            bitmap.UnlockBits(bitmapdata);
            num1 = 1711847784;
            continue;
          case 8:
            if (int_12 <= -7)
            {
              if (this.hashtable_0.ContainsKey((object) num5))
              {
                stringBuilder.Append(this.hashtable_0[(object) num5]);
                num1 = 1711847788;
                continue;
              }
              goto case 2;
            }
            else
              goto case 12;
          case 9:
            int_11 = 22;
            num1 = 1711847791;
            continue;
          case 10:
            string str = string.Format("punch_card_{0}.bmp", (object) Convert.ToString(num4).PadLeft(3, '0'));
            if (File.Exists(str))
            {
              bitmap = new Bitmap(str, true);
              num1 = 1711847804;
              continue;
            }
            goto label_36;
          case 12:
            if (this.method_1(numArray, int_11, int_12))
            {
              num5 |= num3;
              num1 = 1711847807;
              continue;
            }
            goto case 17;
          case 13:
            ++num4;
            num1 = 1711847776;
            continue;
          case 14:
            if (num4 < 1000)
            {
              int num6;
              int num7;
              if (!this.bool_0)
              {
                int num8 = 1711847780;
                num7 = 1711847780;
                num6 = num8;
              }
              else
              {
                num6 = 1711847781;
                num7 = 1711847781;
              }
              num1 = num6;
              continue;
            }
            goto label_36;
          case 15:
            goto label_34;
          case 16:
            num4 = 0;
            num1 = 1711847776;
            continue;
          case 17:
            num3 <<= 1;
            int_12 -= 17;
            num1 = 1711847782;
            continue;
          case 18:
            int num9;
            int num10;
            if (bitmap.PixelFormat != PixelFormat.Format4bppIndexed)
            {
              int num6 = 1711847786;
              num10 = 1711847786;
              num9 = num6;
            }
            else
            {
              num9 = 1711847790;
              num10 = 1711847790;
            }
            num1 = num9;
            continue;
          default:
            goto label_36;
        }
      }
label_35:
      throw new GException0("Invalid picture format!");
label_36:
      return list.ToArray();
    }

    protected bool method_1(byte[] byte_0, int int_11, int int_12)
    {
      int index = 300 * int_12 + (int_11 >> 1);
      if ((int_11 & 1) == 0)
        return ((int) byte_0[index] & 240) == 0;
      return ((int) byte_0[index] & 15) == 0;
    }

    public void method_2()
    {
      this.bool_0 = true;
    }

    public delegate void GDelegate0(GClass0.GEnum0 genum0_0, object object_0);

    public enum GEnum0
    {
      const_0,
      const_1,
      const_2,
    }
  }
}
