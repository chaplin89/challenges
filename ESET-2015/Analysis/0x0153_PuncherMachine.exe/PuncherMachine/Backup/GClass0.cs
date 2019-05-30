// Decompiled with JetBrains decompiler
// Type: ns0.GClass0
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using ns1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
  public class GClass0
  {
    private const int int_0 = 80;
    private const string string_0 = "punch_card_{0}.bmp";
    private const int int_1 = 22;
    private const int int_2 = 197;
    private const int int_3 = 7;
    private const int int_4 = 17;
    private const int int_5 = 3;
    private const int int_6 = 7;
    private volatile bool bool_0;
    private Bitmap bitmap_0;
    private Bitmap bitmap_1;
    private Assembly assembly_0;
    private List<char> list_0;
    private List<int> list_1;
    private Hashtable hashtable_0;
    private Hashtable hashtable_1;
    private SoundPlayer soundPlayer_0;
    private SoundPlayer soundPlayer_1;
    private GClass0.GDelegate0 gdelegate0_0;

    public GClass0(string string_1, byte[] byte_0, Assembly assembly_1, GClass0.GDelegate0 gdelegate0_1)
    {
label_119:
      int num1 = 1685872658;
      while (true)
      {
        int num2 = 1685872664;
        byte[] numArray;
        switch (num1 ^ num2)
        {
          case 0:
            this.list_0.Add('&');
            num1 = 1685872721;
            continue;
          case 1:
            this.list_1.Add(Convert.ToInt32("000000100000", 2));
            num1 = 1685872657;
            continue;
          case 2:
            this.list_0.Add('e');
            this.list_0.Add('f');
            this.list_0.Add('g');
            num1 = 1685872746;
            continue;
          case 3:
            this.list_0.Add('x');
            num1 = 1685872643;
            continue;
          case 4:
            this.list_0.Add('"');
            num1 = 1685872662;
            continue;
          case 5:
            this.list_1.Add(Convert.ToInt32("010000100000", 2));
            num1 = 1685872678;
            continue;
          case 6:
            this.list_1.Add(Convert.ToInt32("011000100000", 2));
            num1 = 1685872695;
            continue;
          case 7:
            this.list_1.Add(Convert.ToInt32("100100000000", 2));
            this.list_1.Add(Convert.ToInt32("100010000000", 2));
            this.list_1.Add(Convert.ToInt32("100001000000", 2));
            this.list_1.Add(Convert.ToInt32("100000100000", 2));
            this.list_1.Add(Convert.ToInt32("100000010000", 2));
            num1 = 1685872732;
            continue;
          case 8:
            this.list_1.Add(Convert.ToInt32("110000000100", 2));
            this.list_1.Add(Convert.ToInt32("110000000010", 2));
            num1 = 1685872703;
            continue;
          case 9:
            this.list_1.Add(Convert.ToInt32("000000010000", 2));
            num1 = 1685872726;
            continue;
          case 10:
            numArray = GClass1.smethod_1(string_1);
            num1 = 1685872642;
            continue;
          case 11:
            this.list_0.Add('i');
            this.list_0.Add('j');
            num1 = 1685872679;
            continue;
          case 12:
            this.list_0.Add('w');
            num1 = 1685872667;
            continue;
          case 13:
            this.list_0.Add('r');
            num1 = 1685872640;
            continue;
          case 14:
            this.list_0.Add('.');
            num1 = 1685872676;
            continue;
          case 15:
            this.list_1.Add(Convert.ToInt32("101010000000", 2));
            this.list_1.Add(Convert.ToInt32("101001000000", 2));
            this.list_1.Add(Convert.ToInt32("101000100000", 2));
            this.list_1.Add(Convert.ToInt32("101000010000", 2));
            num1 = 1685872733;
            continue;
          case 16:
            this.list_0.Add('v');
            num1 = 1685872660;
            continue;
          case 17:
            this.list_0.Add('P');
            num1 = 1685872694;
            continue;
          case 18:
            this.list_0.Add('\'');
            this.list_0.Add('=');
            num1 = 1685872668;
            continue;
          case 19:
            this.list_0.Add('t');
            num1 = 1685872641;
            continue;
          case 20:
            this.list_0.Add('c');
            this.list_0.Add('d');
            num1 = 1685872666;
            continue;
          case 21:
            this.list_0.Add('+');
            num1 = 1685872680;
            continue;
          case 22:
            this.list_0.Add('l');
            num1 = 1685872744;
            continue;
          case 23:
            this.list_0.Add('X');
            num1 = 1685872760;
            continue;
          case 24:
            this.list_0.Add('s');
            num1 = 1685872651;
            continue;
          case 25:
            this.list_0.Add('u');
            num1 = 1685872648;
            continue;
          case 26:
            int num3;
            int num4;
            if (Enumerable.SequenceEqual<byte>((IEnumerable<byte>) byte_0, (IEnumerable<byte>) numArray))
            {
              int num5 = 1685872753;
              num4 = 1685872753;
              num3 = num5;
            }
            else
            {
              num3 = 1685872683;
              num4 = 1685872683;
            }
            num1 = num3;
            continue;
          case 27:
            this.list_0.Add('y');
            num1 = 1685872684;
            continue;
          case 28:
            this.list_1.Add(Convert.ToInt32("110000001000", 2));
            num1 = 1685872656;
            continue;
          case 29:
            this.list_1.Add(Convert.ToInt32("000000000010", 2));
            num1 = 1685872711;
            continue;
          case 30:
            this.list_1.Add(Convert.ToInt32("011010000000", 2));
            num1 = 1685872727;
            continue;
          case 31:
            this.list_1.Add(Convert.ToInt32("100000000100", 2));
            num1 = 1685872672;
            continue;
          case 32:
            this.list_1.Add(Convert.ToInt32("010000100010", 2));
            this.list_1.Add(Convert.ToInt32("010000010010", 2));
            this.list_1.Add(Convert.ToInt32("010000001010", 2));
            this.list_1.Add(Convert.ToInt32("001001000010", 2));
            this.list_1.Add(Convert.ToInt32("001000100010", 2));
            num1 = 1685872701;
            continue;
          case 33:
            this.list_0.Add('?');
            num1 = 1685872725;
            continue;
          case 34:
            this.list_0.Add(')');
            this.list_0.Add(';');
            num1 = 1685872677;
            continue;
          case 35:
            this.list_0.Add('n');
            num1 = 1685872706;
            continue;
          case 36:
            this.list_1.Add(Convert.ToInt32("001000000100", 2));
            num1 = 1685872690;
            continue;
          case 37:
            this.list_1.Add(Convert.ToInt32("001000010010", 2));
            this.list_1.Add(Convert.ToInt32("001000001010", 2));
            num1 = 1685872675;
            continue;
          case 38:
            this.list_1.Add(Convert.ToInt32("000000010010", 2));
            this.list_1.Add(Convert.ToInt32("000000001010", 2));
            this.list_1.Add(Convert.ToInt32("000000000110", 2));
            this.list_1.Add(Convert.ToInt32("100001000010", 2));
            num1 = 1685872686;
            continue;
          case 39:
            this.list_1.Add(Convert.ToInt32("110000000001", 2));
            num1 = 1685872646;
            continue;
          case 40:
            this.list_0.Add('I');
            this.list_0.Add('J');
            num1 = 1685872720;
            continue;
          case 41:
            this.list_0.Add('8');
            this.list_0.Add('9');
            this.list_0.Add('A');
            num1 = 1685872752;
            continue;
          case 42:
            this.list_1.Add(Convert.ToInt32("001000000010", 2));
            num1 = 1685872735;
            continue;
          case 43:
            this.list_0.Add('2');
            this.list_0.Add('3');
            num1 = 1685872712;
            continue;
          case 44:
            this.list_0.Add('D');
            this.list_0.Add('E');
            num1 = 1685872761;
            continue;
          case 45:
            this.list_1.Add(Convert.ToInt32("001000010000", 2));
            num1 = 1685872718;
            continue;
          case 46:
            this.list_0.Add('Q');
            this.list_0.Add('R');
            this.list_0.Add('/');
            num1 = 1685872734;
            continue;
          case 47:
            this.list_1.Add(Convert.ToInt32("011000010000", 2));
            this.list_1.Add(Convert.ToInt32("011000001000", 2));
            num1 = 1685872748;
            continue;
          case 48:
            this.list_0.Add('|');
            num1 = 1685872685;
            continue;
          case 49:
            this.list_1.Add(Convert.ToInt32("100000000000", 2));
            num1 = 1685872714;
            continue;
          case 50:
            goto label_119;
          case 51:
            goto label_120;
          case 52:
            this.list_0.Add('z');
            this.list_0.Add(':');
            this.list_0.Add('#');
            num1 = 1685872747;
            continue;
          case 53:
            this.list_0.Add('$');
            this.list_0.Add('*');
            num1 = 1685872698;
            continue;
          case 54:
            this.list_1.Add(Convert.ToInt32("100000100010", 2));
            num1 = 1685872710;
            continue;
          case 55:
            this.list_1.Add(Convert.ToInt32("000001000000", 2));
            num1 = 1685872665;
            continue;
          case 56:
            this.list_1.Add(Convert.ToInt32("100000000010", 2));
            num1 = 1685872705;
            continue;
          case 57:
            this.list_0.Add('C');
            num1 = 1685872692;
            continue;
          case 58:
            this.list_0.Add('%');
            this.list_0.Add('_');
            num1 = 1685872724;
            continue;
          case 59:
            this.list_1.Add(Convert.ToInt32("001000000110", 2));
            this.list_1.Add(Convert.ToInt32("000000000000", 2));
            this.list_1.Add(Convert.ToInt32("010000000000", 2));
            num1 = 1685872681;
            continue;
          case 60:
            this.list_0.Add('<');
            num1 = 1685872764;
            continue;
          case 61:
            this.list_0.Add(',');
            num1 = 1685872674;
            continue;
          case 62:
            this.list_1.Add(Convert.ToInt32("010000010000", 2));
            this.list_1.Add(Convert.ToInt32("010000001000", 2));
            this.list_1.Add(Convert.ToInt32("010000000100", 2));
            this.list_1.Add(Convert.ToInt32("010000000010", 2));
            num1 = 1685872704;
            continue;
          case 63:
            this.list_0.Add('k');
            num1 = 1685872654;
            continue;
          case 64:
            this.list_1.Add(Convert.ToInt32("100000001010", 2));
            this.list_1.Add(Convert.ToInt32("100000000110", 2));
            this.list_1.Add(Convert.ToInt32("010001000010", 2));
            num1 = 1685872696;
            continue;
          case 65:
            this.bitmap_0 = new Bitmap(string_1, true);
            num1 = 1685872755;
            continue;
          case 66:
            this.list_1.Add(Convert.ToInt32("001000000000", 2));
            num1 = 1685872707;
            continue;
          case 67:
            this.list_1.Add(Convert.ToInt32("001000100000", 2));
            num1 = 1685872693;
            continue;
          case 68:
            this.list_1.Add(Convert.ToInt32("100000001000", 2));
            num1 = 1685872647;
            continue;
          case 69:
            this.list_1.Add(Convert.ToInt32("101000001000", 2));
            num1 = 1685872767;
            continue;
          case 70:
            this.list_0.Add('S');
            num1 = 1685872757;
            continue;
          case 71:
            this.list_1.Add(Convert.ToInt32("001000000001", 2));
            this.list_1.Add(Convert.ToInt32("101100000000", 2));
            num1 = 1685872663;
            continue;
          case 72:
            this.list_0.Add('K');
            this.list_0.Add('L');
            this.list_0.Add('M');
            num1 = 1685872715;
            continue;
          case 73:
            this.list_1 = new List<int>();
            num1 = 1685872730;
            continue;
          case 74:
            this.list_0.Add('H');
            num1 = 1685872688;
            continue;
          case 75:
            this.list_1.Add(Convert.ToInt32("000001000010", 2));
            num1 = 1685872754;
            continue;
          case 76:
            this.list_0.Add('>');
            num1 = 1685872697;
            continue;
          case 77:
            this.list_0.Add(' ');
            num1 = 1685872765;
            continue;
          case 78:
            this.list_1.Add(Convert.ToInt32("000000001000", 2));
            num1 = 1685872708;
            continue;
          case 79:
            this.list_1.Add(Convert.ToInt32("011001000000", 2));
            num1 = 1685872670;
            continue;
          case 80:
            this.list_0.Add('4');
            this.list_0.Add('5');
            this.list_0.Add('6');
            this.list_0.Add('7');
            num1 = 1685872689;
            continue;
          case 81:
            this.list_1.Add(Convert.ToInt32("010100000000", 2));
            this.list_1.Add(Convert.ToInt32("010010000000", 2));
            this.list_1.Add(Convert.ToInt32("010001000000", 2));
            num1 = 1685872669;
            continue;
          case 82:
            this.assembly_0 = assembly_1;
            // ISSUE: reference to a compiler-generated method
            this.soundPlayer_0 = new SoundPlayer((Stream) Class5.smethod_0());
            num1 = 1685872756;
            continue;
          case 83:
            this.list_0.Add('N');
            this.list_0.Add('O');
            num1 = 1685872649;
            continue;
          case 84:
            this.list_0.Add('p');
            this.list_0.Add('q');
            num1 = 1685872661;
            continue;
          case 85:
            this.list_1.Add(Convert.ToInt32("000010000000", 2));
            num1 = 1685872687;
            continue;
          case 86:
            this.list_1.Add(Convert.ToInt32("001000001000", 2));
            num1 = 1685872700;
            continue;
          case 87:
            this.list_1.Add(Convert.ToInt32("001001000000", 2));
            num1 = 1685872731;
            continue;
          case 88:
            this.list_1.Add(Convert.ToInt32("010000000001", 2));
            num1 = 1685872763;
            continue;
          case 89:
            this.list_1.Add(Convert.ToInt32("100000000001", 2));
            num1 = 1685872713;
            continue;
          case 90:
            this.list_0.Add('o');
            num1 = 1685872716;
            continue;
          case 91:
            this.list_1.Add(Convert.ToInt32("000100000000", 2));
            num1 = 1685872717;
            continue;
          case 92:
            this.list_1.Add(Convert.ToInt32("000000000100", 2));
            num1 = 1685872645;
            continue;
          case 93:
            this.list_0.Add('0');
            this.list_0.Add('1');
            num1 = 1685872691;
            continue;
          case 94:
            this.list_1.Add(Convert.ToInt32("100000010010", 2));
            num1 = 1685872728;
            continue;
          case 95:
            this.list_1.Add(Convert.ToInt32("000000000001", 2));
            num1 = 1685872671;
            continue;
          case 96:
            this.list_0.Add('Y');
            num1 = 1685872759;
            continue;
          case 97:
            this.list_0.Add('F');
            this.list_0.Add('G');
            num1 = 1685872722;
            continue;
          case 98:
            this.list_1.Add(Convert.ToInt32("110000100000", 2));
            this.list_1.Add(Convert.ToInt32("110000010000", 2));
            num1 = 1685872644;
            continue;
          case 99:
            this.list_1.Add(Convert.ToInt32("001100000000", 2));
            this.list_1.Add(Convert.ToInt32("001010000000", 2));
            num1 = 1685872719;
            continue;
          case 100:
            this.list_0.Add('(');
            num1 = 1685872653;
            continue;
          case 101:
            this.list_0.Add('-');
            num1 = 1685872664;
            continue;
          case 102:
            this.list_0.Add('W');
            num1 = 1685872655;
            continue;
          case 103:
            this.list_1.Add(Convert.ToInt32("101000000100", 2));
            this.list_1.Add(Convert.ToInt32("101000000010", 2));
            num1 = 1685872758;
            continue;
          case 104:
            this.list_0.Add('B');
            num1 = 1685872673;
            continue;
          case 105:
            this.gdelegate0_0 = gdelegate0_1;
            num1 = 1685872729;
            continue;
          case 106:
            this.list_1.Add(Convert.ToInt32("000000100010", 2));
            num1 = 1685872702;
            continue;
          case 107:
            this.list_0 = new List<char>();
            num1 = 1685872709;
            continue;
          case 109:
            this.list_0.Add('T');
            this.list_0.Add('U');
            this.list_0.Add('V');
            num1 = 1685872766;
            continue;
          case 110:
            this.list_1.Add(Convert.ToInt32("101000000001", 2));
            num1 = 1685872745;
            continue;
          case 111:
            this.list_0.Add('Z');
            this.list_0.Add('a');
            this.list_0.Add('b');
            num1 = 1685872652;
            continue;
          case 112:
            this.list_0.Add('m');
            num1 = 1685872699;
            continue;
          case 113:
            this.list_1.Add(Convert.ToInt32("110100000000", 2));
            this.list_1.Add(Convert.ToInt32("110010000000", 2));
            this.list_1.Add(Convert.ToInt32("110001000000", 2));
            num1 = 1685872762;
            continue;
          case 114:
            this.list_0.Add('h');
            num1 = 1685872659;
            continue;
          case 115:
            this.list_0.Add('@');
            num1 = 1685872650;
            continue;
          case 116:
            this.list_1.Add(Convert.ToInt32("011000000100", 2));
            this.list_1.Add(Convert.ToInt32("011000000010", 2));
            this.list_1.Add(Convert.ToInt32("011000000001", 2));
            this.list_1.Add(Convert.ToInt32("000010000010", 2));
            num1 = 1685872723;
            continue;
          default:
            goto label_121;
        }
      }
label_120:
      throw new GException0("Invalid punch card!");
label_121:
      // ISSUE: reference to a compiler-generated method
      this.soundPlayer_1 = new SoundPlayer((Stream) Class5.smethod_1());
    }

    [SpecialName]
    public Bitmap method_0()
    {
      return this.bitmap_1;
    }

    public bool method_1(string string_1, string string_2)
    {
      List<uint> list = new List<uint>();
label_3:
      int num1 = 2125357806;
      int startIndex;
      while (true)
      {
        int num2 = 2125357807;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_3;
          case 1:
            startIndex = 0;
            num1 = 2125357805;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      if (startIndex < string_1.Length)
      {
        try
        {
          list.Add(Convert.ToUInt32(string_1.Substring(startIndex, 8), 16));
        }
        catch (Exception ex)
        {
        }
        startIndex += 8;
        goto label_10;
      }
      else
        goto label_11;
label_9:
      int num3;
      while (true)
      {
        int num2 = 2125357807;
        switch (num3 ^ num2)
        {
          case 0:
            goto label_10;
          case 1:
            goto label_15;
          case 2:
            if (string_2.Length == 0)
            {
              num3 = 2125357804;
              continue;
            }
            goto label_16;
          default:
            goto label_35;
        }
      }
label_16:
      bool flag;
      try
      {
        GClass0.GDelegate1<ulong, string> gdelegate1 = this.method_3(list.ToArray());
label_31:
        int num2 = 2125357800;
        while (true)
        {
          int num4 = 2125357807;
          ulong num5;
          switch (num2 ^ num4)
          {
            case 0:
              startIndex = 0;
              num2 = 2125357802;
              continue;
            case 1:
              flag = true;
              num2 = 2125357798;
              continue;
            case 2:
              num2 = 2125357796;
              continue;
            case 3:
              goto label_31;
            case 4:
              goto label_32;
            case 5:
              num2 = 2125357797;
              continue;
            case 6:
              if (this.hashtable_0.ContainsKey((object) num5))
              {
                this.hashtable_1.Add((object) this.list_0[startIndex], this.hashtable_0[(object) num5]);
                num2 = 2125357805;
                continue;
              }
              goto label_32;
            case 7:
              this.method_2();
              this.hashtable_1 = new Hashtable();
              num2 = 2125357807;
              continue;
            case 8:
              num5 = gdelegate1(startIndex < string_2.Length ? this.list_0[startIndex].ToString() + string_2[startIndex].ToString() : this.list_0[startIndex].ToString());
              num2 = 2125357801;
              continue;
            case 10:
              int num6;
              int num7;
              if (startIndex >= this.list_0.Count)
              {
                int num8 = 2125357806;
                num7 = 2125357806;
                num6 = num8;
              }
              else
              {
                num6 = 2125357799;
                num7 = 2125357799;
              }
              num2 = num6;
              continue;
            case 11:
              ++startIndex;
              num2 = 2125357797;
              continue;
            default:
              goto label_34;
          }
        }
label_32:
        flag = false;
      }
      catch (Exception ex)
      {
        flag = false;
      }
label_34:
      return flag;
label_35:
      return false;
label_10:
      num3 = 2125357806;
      goto label_9;
label_11:
      int num9;
      int num10;
      if (string_2.Length > this.list_0.Count)
      {
        int num2 = 2125357804;
        num10 = 2125357804;
        num9 = num2;
      }
      else
      {
        num9 = 2125357805;
        num10 = 2125357805;
      }
      num3 = num9;
      goto label_9;
    }

    private void method_2()
    {
      this.hashtable_0 = new Hashtable();
label_10:
      int num1 = 722124814;
      while (true)
      {
        int num2 = 722124815;
        int index;
        byte[] numArray;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_9;
          case 1:
            numArray = new GClass2().method_0(65280, Class0.byte_0);
            index = 0;
            num1 = 722124811;
            continue;
          case 2:
            this.hashtable_0.Add((object) BitConverter.ToUInt64(numArray, index * 8), (object) this.list_1[index]);
            num1 = 722124812;
            continue;
          case 3:
            ++index;
            num1 = 722124811;
            continue;
          case 4:
            int num3;
            int num4;
            if (index >= this.list_0.Count)
            {
              int num5 = 722124815;
              num4 = 722124815;
              num3 = num5;
            }
            else
            {
              num3 = 722124813;
              num4 = 722124813;
            }
            num1 = num3;
            continue;
          case 5:
            goto label_10;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_9:;
    }

    private GClass0.GDelegate1<ulong, string> method_3(uint[] uint_0)
    {
      MethodInfo method = this.assembly_0.GetType("DynMethod.DynMethodFactory").GetMethod("createMethod");
label_3:
      int num1 = 1161877159;
      DynamicMethod dynamicMethod;
      while (true)
      {
        int num2 = 1161877158;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_3;
          case 1:
            dynamicMethod = (DynamicMethod) method.Invoke((object) null, new object[1]
            {
              (object) uint_0
            });
            num1 = 1161877156;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (GClass0.GDelegate1<ulong, string>) dynamicMethod.CreateDelegate(typeof (GClass0.GDelegate1<ulong, string>));
    }

    public void method_4(string[] string_1)
    {
      try
      {
        if (string_1.Length == 0)
          throw new GException0(string.Format("No data to punch!"));
label_66:
        this.method_6(string_1);
        int num1 = -1559479496;
        while (true)
        {
          int num2 = -1559479510;
          BitmapData bitmapdata;
          int num3;
          int num4;
          int num5;
          byte[] numArray;
          int num6;
          int num7;
          int index1;
          string str;
          int num8;
          int index2;
          char ch;
          switch (num1 ^ num2)
          {
            case 0:
              int num9;
              int num10;
              if ((num5 & 1) != 1)
              {
                int num11 = -1559479512;
                num10 = -1559479512;
                num9 = num11;
              }
              else
              {
                num9 = -1559479498;
                num10 = -1559479498;
              }
              num1 = num9;
              continue;
            case 1:
              num4 = 197;
              bitmapdata = this.bitmap_1.LockBits(new Rectangle(0, 0, this.bitmap_1.Width, this.bitmap_1.Height), ImageLockMode.ReadWrite, this.bitmap_1.PixelFormat);
              numArray = new byte[bitmapdata.Height * bitmapdata.Stride];
              num1 = -1559479518;
              continue;
            case 2:
              num5 >>= 1;
              num1 = -1559479503;
              continue;
            case 3:
              index1 = 0;
              num1 = -1559479491;
              continue;
            case 4:
              num1 = -1559479492;
              continue;
            case 5:
              this.bitmap_1.UnlockBits(bitmapdata);
              this.gdelegate0_0(GClass0.GEnum0.const_0, (object) new Bitmap((Image) this.bitmap_1));
              this.soundPlayer_1.PlaySync();
              num1 = -1559479512;
              continue;
            case 6:
              ch = str[index1];
              num1 = -1559479514;
              continue;
            case 7:
label_37:
              str = string_1[index2];
              num1 = -1559479493;
              continue;
            case 8:
              Marshal.Copy(bitmapdata.Scan0, numArray, 0, numArray.Length);
              this.bitmap_1.UnlockBits(bitmapdata);
              num1 = -1559479510;
              continue;
            case 9:
              ++index1;
              num1 = -1559479491;
              continue;
            case 10:
              int num12;
              int num13;
              if (this.bool_0)
              {
                int num11 = -1559479516;
                num13 = -1559479516;
                num12 = num11;
              }
              else
              {
                num12 = -1559479508;
                num13 = -1559479508;
              }
              num1 = num12;
              continue;
            case 11:
              int num14;
              int num15;
              if (num6 < 7)
              {
                int num11 = -1559479513;
                num15 = -1559479513;
                num14 = num11;
              }
              else
              {
                num14 = -1559479489;
                num15 = -1559479489;
              }
              num1 = num14;
              continue;
            case 12:
              num5 = (int) this.hashtable_1[(object) ch];
              num1 = -1559479509;
              continue;
            case 13:
              this.method_7(numArray, num7 + num3, num4 + num6, (byte) 0);
              ++num6;
              num1 = -1559479519;
              continue;
            case 14:
              this.soundPlayer_0.PlaySync();
              num1 = -1559479495;
              continue;
            case 15:
              num6 = 0;
              num1 = -1559479519;
              continue;
            case 16:
              num7 = 22;
              num1 = -1559479511;
              continue;
            case 17:
              this.bitmap_1 = this.bitmap_0.Clone(new Rectangle(0, 0, this.bitmap_0.Width, this.bitmap_0.Height), PixelFormat.Format4bppIndexed);
              this.soundPlayer_0.PlaySync();
              num1 = -1559479494;
              continue;
            case 18:
              num8 = 0;
              this.soundPlayer_0.PlaySync();
              index2 = 0;
              break;
            case 20:
              num1 = -1559479504;
              continue;
            case 21:
              ++num3;
              num1 = -1559479504;
              continue;
            case 22:
              goto label_66;
            case 23:
              int num16;
              int num17;
              if (index1 >= str.Length)
              {
                int num11 = -1559479516;
                num17 = -1559479516;
                num16 = num11;
              }
              else
              {
                num16 = -1559479520;
                num17 = -1559479520;
              }
              num1 = num16;
              continue;
            case 24:
              int num18;
              int num19;
              if (!this.bool_0)
              {
                int num11 = -1559479510;
                num19 = -1559479510;
                num18 = num11;
              }
              else
              {
                num18 = -1559479501;
                num19 = -1559479501;
              }
              num1 = num18;
              continue;
            case 25:
              num7 += 7;
              num1 = -1559479517;
              continue;
            case 26:
              if (num3 >= 3)
              {
                Marshal.Copy(numArray, 0, bitmapdata.Scan0, numArray.Length);
                num1 = -1559479505;
                continue;
              }
              goto case 15;
            case 27:
              num4 -= 17;
              int num20;
              int num21;
              if (num5 <= 0)
              {
                int num11 = -1559479501;
                num21 = -1559479501;
                num20 = num11;
              }
              else
              {
                num20 = -1559479502;
                num21 = -1559479502;
              }
              num1 = num20;
              continue;
            case 28:
              bitmapdata = this.bitmap_1.LockBits(new Rectangle(0, 0, this.bitmap_1.Width, this.bitmap_1.Height), ImageLockMode.ReadWrite, this.bitmap_1.PixelFormat);
              num3 = 0;
              num1 = -1559479490;
              continue;
            default:
              string filename = string.Format("punch_card_{0}.bmp", (object) Convert.ToString(num8).PadLeft(3, '0'));
              try
              {
                this.bitmap_1.Clone(new Rectangle(0, 0, this.bitmap_1.Width, this.bitmap_1.Height), PixelFormat.Format4bppIndexed).Save(filename, ImageFormat.Bmp);
              }
              catch (Exception ex)
              {
                throw new GException0(string.Format("Can't save punchcard with name: {0}", (object) filename));
              }
              ++num8;
              goto label_36;
          }
label_26:
          int num22;
          int num23;
          if (index2 < string_1.Length)
          {
            int num11 = -1559479511;
            num23 = -1559479511;
            num22 = num11;
          }
          else
          {
            num22 = -1559479510;
            num23 = -1559479510;
          }
label_34:
          while (true)
          {
            int num11 = -1559479510;
            switch (num22 ^ num11)
            {
              case 0:
                this.soundPlayer_0.PlaySync();
                num22 = -1559479508;
                continue;
              case 1:
                ++index2;
                num22 = -1559479506;
                continue;
              case 2:
                goto label_36;
              case 3:
                if (this.bool_0)
                {
                  num22 = -1559479510;
                  continue;
                }
                goto label_37;
              case 4:
                goto label_26;
              case 5:
                goto label_65;
              case 6:
                this.gdelegate0_0(GClass0.GEnum0.const_1, (object) null);
                num22 = -1559479505;
                continue;
              default:
                goto label_35;
            }
          }
label_36:
          num22 = -1559479509;
          goto label_34;
        }
label_35:
        return;
label_65:;
      }
      catch (Exception ex)
      {
        this.gdelegate0_0(GClass0.GEnum0.const_2, (object) ex);
      }
    }

    public void method_5()
    {
      this.bool_0 = true;
    }

    protected void method_6(string[] string_1)
    {
      int num1 = 1;
label_20:
      int num2 = 920829957;
      while (true)
      {
        int num3 = 920829955;
        string str1;
        int index1;
        string[] strArray;
        int index2;
        string str2;
        switch (num2 ^ num3)
        {
          case 0:
            index1 = 0;
            num2 = 920829954;
            continue;
          case 1:
            if (index1 >= str1.Length)
            {
              ++num1;
              ++index2;
              num2 = 920829959;
              continue;
            }
            goto case 10;
          case 2:
            ++index1;
            num2 = 920829954;
            continue;
          case 3:
            str1 = str2;
            num2 = 920829955;
            continue;
          case 4:
            int num4;
            int num5;
            if (index2 < strArray.Length)
            {
              int num6 = 920829963;
              num5 = 920829963;
              num4 = num6;
            }
            else
            {
              num4 = 920829958;
              num5 = 920829958;
            }
            num2 = num4;
            continue;
          case 5:
            goto label_19;
          case 6:
            strArray = string_1;
            index2 = 0;
            num2 = 920829967;
            continue;
          case 7:
            int num7;
            int num8;
            if (str2.Length > 80)
            {
              int num6 = 920829960;
              num8 = 920829960;
              num7 = num6;
            }
            else
            {
              num7 = 920829952;
              num8 = 920829952;
            }
            num2 = num7;
            continue;
          case 8:
            str2 = strArray[index2];
            num2 = 920829956;
            continue;
          case 9:
            goto label_20;
          case 10:
            if (!this.hashtable_1.ContainsKey((object) str1[index1]))
              goto label_21;
            else
              goto case 2;
          case 11:
            goto label_22;
          case 12:
            num2 = 920829959;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return;
label_19:
      return;
label_21:
      throw new GException0(string.Format("Invalid character on line nr.: {0}", (object) num1));
label_22:
      throw new GException0(string.Format("Maximum line length exceeded on line nr.: {0}", (object) num1));
    }

    protected void method_7(byte[] byte_0, int int_7, int int_8, byte byte_1)
    {
      int index = 300 * int_8 + (int_7 >> 1);
label_9:
      int num1 = 595855208;
      while (true)
      {
        int num2 = 595855212;
        switch (num1 ^ num2)
        {
          case 0:
            byte_0[index] = (byte) ((uint) byte_0[index] & (uint) (byte) ((int) byte_1 << 4 | 15));
            num1 = 595855213;
            continue;
          case 1:
            goto label_8;
          case 2:
            goto label_9;
          case 3:
            goto label_10;
          case 4:
            int num3;
            int num4;
            if ((int_7 & 1) != 0)
            {
              int num5 = 595855209;
              num4 = 595855209;
              num3 = num5;
            }
            else
            {
              num3 = 595855212;
              num4 = 595855212;
            }
            num1 = num3;
            continue;
          case 5:
            byte_0[index] = (byte) ((uint) byte_0[index] & (uint) (byte) ((uint) byte_1 | 240U));
            num1 = 595855215;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return;
label_10:
      return;
label_8:;
    }

    public delegate void GDelegate0(GClass0.GEnum0 genum0_0, object object_0);

    public enum GEnum0
    {
      const_0,
      const_1,
      const_2,
    }

    public delegate T GDelegate1<T, U>(U gparam_0);
  }
}
