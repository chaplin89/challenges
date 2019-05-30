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

namespace PuncherMachine
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
        private Bitmap punchcard;
        private Bitmap bitmap_1;
        private Assembly assembly_0;
        private List<char> charList;
        private List<int> binaryHash;
        private Hashtable hashPipeBinary;
        private Hashtable hashtable_1;
        private SoundPlayer soundPlayer_0;
        private SoundPlayer soundPlayer_1;
        private GDelegate0 gdelegate0_0;

        public GClass0(string punchcardPath, byte[] byte_0, Assembly assembly_1, GClass0.GDelegate0 gdelegate0_1)
        {
            label_119:
            int num1 = 1685872658;
            byte[] numArray = null;
            while (true)
            {
                int num2 = 1685872664;
                switch (num1 ^ num2)
                {
                    case 0:
                        charList.Add('&');
                        num1 = 1685872721;
                        continue;
                    case 1:
                        binaryHash.Add(Convert.ToInt32("000000100000", 2));
                        num1 = 1685872657;
                        continue;
                    case 2:
                        charList.Add('e');
                        charList.Add('f');
                        charList.Add('g');
                        num1 = 1685872746;
                        continue;
                    case 3:
                        charList.Add('x');
                        num1 = 1685872643;
                        continue;
                    case 4:
                        charList.Add('"');
                        num1 = 1685872662;
                        continue;
                    case 5:
                        binaryHash.Add(Convert.ToInt32("010000100000", 2));
                        num1 = 1685872678;
                        continue;
                    case 6:
                        binaryHash.Add(Convert.ToInt32("011000100000", 2));
                        num1 = 1685872695;
                        continue;
                    case 7:
                        binaryHash.Add(Convert.ToInt32("100100000000", 2));
                        binaryHash.Add(Convert.ToInt32("100010000000", 2));
                        binaryHash.Add(Convert.ToInt32("100001000000", 2));
                        binaryHash.Add(Convert.ToInt32("100000100000", 2));
                        binaryHash.Add(Convert.ToInt32("100000010000", 2));
                        num1 = 1685872732;
                        continue;
                    case 8:
                        binaryHash.Add(Convert.ToInt32("110000000100", 2));
                        binaryHash.Add(Convert.ToInt32("110000000010", 2));
                        num1 = 1685872703;
                        continue;
                    case 9:
                        binaryHash.Add(Convert.ToInt32("000000010000", 2));
                        num1 = 1685872726;
                        continue;
                    case 10:
                        numArray = Utility.ComputeMD5(punchcardPath);
                        num1 = 1685872642;
                        continue;
                    case 11:
                        charList.Add('i');
                        charList.Add('j');
                        num1 = 1685872679;
                        continue;
                    case 12:
                        charList.Add('w');
                        num1 = 1685872667;
                        continue;
                    case 13:
                        charList.Add('r');
                        num1 = 1685872640;
                        continue;
                    case 14:
                        charList.Add('.');
                        num1 = 1685872676;
                        continue;
                    case 15:
                        binaryHash.Add(Convert.ToInt32("101010000000", 2));
                        binaryHash.Add(Convert.ToInt32("101001000000", 2));
                        binaryHash.Add(Convert.ToInt32("101000100000", 2));
                        binaryHash.Add(Convert.ToInt32("101000010000", 2));
                        num1 = 1685872733;
                        continue;
                    case 16:
                        charList.Add('v');
                        num1 = 1685872660;
                        continue;
                    case 17:
                        charList.Add('P');
                        num1 = 1685872694;
                        continue;
                    case 18:
                        charList.Add('\'');
                        charList.Add('=');
                        num1 = 1685872668;
                        continue;
                    case 19:
                        charList.Add('t');
                        num1 = 1685872641;
                        continue;
                    case 20:
                        charList.Add('c');
                        charList.Add('d');
                        num1 = 1685872666;
                        continue;
                    case 21:
                        charList.Add('+');
                        num1 = 1685872680;
                        continue;
                    case 22:
                        charList.Add('l');
                        num1 = 1685872744;
                        continue;
                    case 23:
                        charList.Add('X');
                        num1 = 1685872760;
                        continue;
                    case 24:
                        charList.Add('s');
                        num1 = 1685872651;
                        continue;
                    case 25:
                        charList.Add('u');
                        num1 = 1685872648;
                        continue;
                    case 26:
                        int num3;
                        int num4;
                        if (Enumerable.SequenceEqual(byte_0, numArray))
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
                        charList.Add('y');
                        num1 = 1685872684;
                        continue;
                    case 28:
                        binaryHash.Add(Convert.ToInt32("110000001000", 2));
                        num1 = 1685872656;
                        continue;
                    case 29:
                        binaryHash.Add(Convert.ToInt32("000000000010", 2));
                        num1 = 1685872711;
                        continue;
                    case 30:
                        binaryHash.Add(Convert.ToInt32("011010000000", 2));
                        num1 = 1685872727;
                        continue;
                    case 31:
                        binaryHash.Add(Convert.ToInt32("100000000100", 2));
                        num1 = 1685872672;
                        continue;
                    case 32:
                        binaryHash.Add(Convert.ToInt32("010000100010", 2));
                        binaryHash.Add(Convert.ToInt32("010000010010", 2));
                        binaryHash.Add(Convert.ToInt32("010000001010", 2));
                        binaryHash.Add(Convert.ToInt32("001001000010", 2));
                        binaryHash.Add(Convert.ToInt32("001000100010", 2));
                        num1 = 1685872701;
                        continue;
                    case 33:
                        charList.Add('?');
                        num1 = 1685872725;
                        continue;
                    case 34:
                        charList.Add(')');
                        charList.Add(';');
                        num1 = 1685872677;
                        continue;
                    case 35:
                        charList.Add('n');
                        num1 = 1685872706;
                        continue;
                    case 36:
                        binaryHash.Add(Convert.ToInt32("001000000100", 2));
                        num1 = 1685872690;
                        continue;
                    case 37:
                        binaryHash.Add(Convert.ToInt32("001000010010", 2));
                        binaryHash.Add(Convert.ToInt32("001000001010", 2));
                        num1 = 1685872675;
                        continue;
                    case 38:
                        binaryHash.Add(Convert.ToInt32("000000010010", 2));
                        binaryHash.Add(Convert.ToInt32("000000001010", 2));
                        binaryHash.Add(Convert.ToInt32("000000000110", 2));
                        binaryHash.Add(Convert.ToInt32("100001000010", 2));
                        num1 = 1685872686;
                        continue;
                    case 39:
                        binaryHash.Add(Convert.ToInt32("110000000001", 2));
                        num1 = 1685872646;
                        continue;
                    case 40:
                        charList.Add('I');
                        charList.Add('J');
                        num1 = 1685872720;
                        continue;
                    case 41:
                        charList.Add('8');
                        charList.Add('9');
                        charList.Add('A');
                        num1 = 1685872752;
                        continue;
                    case 42:
                        binaryHash.Add(Convert.ToInt32("001000000010", 2));
                        num1 = 1685872735;
                        continue;
                    case 43:
                        charList.Add('2');
                        charList.Add('3');
                        num1 = 1685872712;
                        continue;
                    case 44:
                        charList.Add('D');
                        charList.Add('E');
                        num1 = 1685872761;
                        continue;
                    case 45:
                        binaryHash.Add(Convert.ToInt32("001000010000", 2));
                        num1 = 1685872718;
                        continue;
                    case 46:
                        charList.Add('Q');
                        charList.Add('R');
                        charList.Add('/');
                        num1 = 1685872734;
                        continue;
                    case 47:
                        binaryHash.Add(Convert.ToInt32("011000010000", 2));
                        binaryHash.Add(Convert.ToInt32("011000001000", 2));
                        num1 = 1685872748;
                        continue;
                    case 48:
                        charList.Add('|');
                        num1 = 1685872685;
                        continue;
                    case 49:
                        binaryHash.Add(Convert.ToInt32("100000000000", 2));
                        num1 = 1685872714;
                        continue;
                    case 50:
                        goto label_119;
                    case 51:
                        goto label_120;
                    case 52:
                        charList.Add('z');
                        charList.Add(':');
                        charList.Add('#');
                        num1 = 1685872747;
                        continue;
                    case 53:
                        charList.Add('$');
                        charList.Add('*');
                        num1 = 1685872698;
                        continue;
                    case 54:
                        binaryHash.Add(Convert.ToInt32("100000100010", 2));
                        num1 = 1685872710;
                        continue;
                    case 55:
                        binaryHash.Add(Convert.ToInt32("000001000000", 2));
                        num1 = 1685872665;
                        continue;
                    case 56:
                        binaryHash.Add(Convert.ToInt32("100000000010", 2));
                        num1 = 1685872705;
                        continue;
                    case 57:
                        charList.Add('C');
                        num1 = 1685872692;
                        continue;
                    case 58:
                        charList.Add('%');
                        charList.Add('_');
                        num1 = 1685872724;
                        continue;
                    case 59:
                        binaryHash.Add(Convert.ToInt32("001000000110", 2));
                        binaryHash.Add(Convert.ToInt32("000000000000", 2));
                        binaryHash.Add(Convert.ToInt32("010000000000", 2));
                        num1 = 1685872681;
                        continue;
                    case 60:
                        charList.Add('<');
                        num1 = 1685872764;
                        continue;
                    case 61:
                        charList.Add(',');
                        num1 = 1685872674;
                        continue;
                    case 62:
                        binaryHash.Add(Convert.ToInt32("010000010000", 2));
                        binaryHash.Add(Convert.ToInt32("010000001000", 2));
                        binaryHash.Add(Convert.ToInt32("010000000100", 2));
                        binaryHash.Add(Convert.ToInt32("010000000010", 2));
                        num1 = 1685872704;
                        continue;
                    case 63:
                        charList.Add('k');
                        num1 = 1685872654;
                        continue;
                    case 64:
                        binaryHash.Add(Convert.ToInt32("100000001010", 2));
                        binaryHash.Add(Convert.ToInt32("100000000110", 2));
                        binaryHash.Add(Convert.ToInt32("010001000010", 2));
                        num1 = 1685872696;
                        continue;
                    case 65:
                        punchcard = new Bitmap(punchcardPath, true);
                        num1 = 1685872755;
                        continue;
                    case 66:
                        binaryHash.Add(Convert.ToInt32("001000000000", 2));
                        num1 = 1685872707;
                        continue;
                    case 67:
                        binaryHash.Add(Convert.ToInt32("001000100000", 2));
                        num1 = 1685872693;
                        continue;
                    case 68:
                        binaryHash.Add(Convert.ToInt32("100000001000", 2));
                        num1 = 1685872647;
                        continue;
                    case 69:
                        binaryHash.Add(Convert.ToInt32("101000001000", 2));
                        num1 = 1685872767;
                        continue;
                    case 70:
                        charList.Add('S');
                        num1 = 1685872757;
                        continue;
                    case 71:
                        binaryHash.Add(Convert.ToInt32("001000000001", 2));
                        binaryHash.Add(Convert.ToInt32("101100000000", 2));
                        num1 = 1685872663;
                        continue;
                    case 72:
                        charList.Add('K');
                        charList.Add('L');
                        charList.Add('M');
                        num1 = 1685872715;
                        continue;
                    case 73:
                        binaryHash = new List<int>();
                        num1 = 1685872730;
                        continue;
                    case 74:
                        charList.Add('H');
                        num1 = 1685872688;
                        continue;
                    case 75:
                        binaryHash.Add(Convert.ToInt32("000001000010", 2));
                        num1 = 1685872754;
                        continue;
                    case 76:
                        charList.Add('>');
                        num1 = 1685872697;
                        continue;
                    case 77:
                        charList.Add(' ');
                        num1 = 1685872765;
                        continue;
                    case 78:
                        binaryHash.Add(Convert.ToInt32("000000001000", 2));
                        num1 = 1685872708;
                        continue;
                    case 79:
                        binaryHash.Add(Convert.ToInt32("011001000000", 2));
                        num1 = 1685872670;
                        continue;
                    case 80:
                        charList.Add('4');
                        charList.Add('5');
                        charList.Add('6');
                        charList.Add('7');
                        num1 = 1685872689;
                        continue;
                    case 81:
                        binaryHash.Add(Convert.ToInt32("010100000000", 2));
                        binaryHash.Add(Convert.ToInt32("010010000000", 2));
                        binaryHash.Add(Convert.ToInt32("010001000000", 2));
                        num1 = 1685872669;
                        continue;
                    case 82:
                        assembly_0 = assembly_1;
                        // ISSUE: reference to a compiler-generated method
                        soundPlayer_0 = new SoundPlayer(new MemoryStream(ns0.Resource.Computer_card_punch));
                        num1 = 1685872756;
                        continue;
                    case 83:
                        charList.Add('N');
                        charList.Add('O');
                        num1 = 1685872649;
                        continue;
                    case 84:
                        charList.Add('p');
                        charList.Add('q');
                        num1 = 1685872661;
                        continue;
                    case 85:
                        binaryHash.Add(Convert.ToInt32("000010000000", 2));
                        num1 = 1685872687;
                        continue;
                    case 86:
                        binaryHash.Add(Convert.ToInt32("001000001000", 2));
                        num1 = 1685872700;
                        continue;
                    case 87:
                        binaryHash.Add(Convert.ToInt32("001001000000", 2));
                        num1 = 1685872731;
                        continue;
                    case 88:
                        binaryHash.Add(Convert.ToInt32("010000000001", 2));
                        num1 = 1685872763;
                        continue;
                    case 89:
                        binaryHash.Add(Convert.ToInt32("100000000001", 2));
                        num1 = 1685872713;
                        continue;
                    case 90:
                        charList.Add('o');
                        num1 = 1685872716;
                        continue;
                    case 91:
                        binaryHash.Add(Convert.ToInt32("000100000000", 2));
                        num1 = 1685872717;
                        continue;
                    case 92:
                        binaryHash.Add(Convert.ToInt32("000000000100", 2));
                        num1 = 1685872645;
                        continue;
                    case 93:
                        charList.Add('0');
                        charList.Add('1');
                        num1 = 1685872691;
                        continue;
                    case 94:
                        binaryHash.Add(Convert.ToInt32("100000010010", 2));
                        num1 = 1685872728;
                        continue;
                    case 95:
                        binaryHash.Add(Convert.ToInt32("000000000001", 2));
                        num1 = 1685872671;
                        continue;
                    case 96:
                        charList.Add('Y');
                        num1 = 1685872759;
                        continue;
                    case 97:
                        charList.Add('F');
                        charList.Add('G');
                        num1 = 1685872722;
                        continue;
                    case 98:
                        binaryHash.Add(Convert.ToInt32("110000100000", 2));
                        binaryHash.Add(Convert.ToInt32("110000010000", 2));
                        num1 = 1685872644;
                        continue;
                    case 99:
                        binaryHash.Add(Convert.ToInt32("001100000000", 2));
                        binaryHash.Add(Convert.ToInt32("001010000000", 2));
                        num1 = 1685872719;
                        continue;
                    case 100:
                        charList.Add('(');
                        num1 = 1685872653;
                        continue;
                    case 101:
                        charList.Add('-');
                        num1 = 1685872664;
                        continue;
                    case 102:
                        charList.Add('W');
                        num1 = 1685872655;
                        continue;
                    case 103:
                        binaryHash.Add(Convert.ToInt32("101000000100", 2));
                        binaryHash.Add(Convert.ToInt32("101000000010", 2));
                        num1 = 1685872758;
                        continue;
                    case 104:
                        charList.Add('B');
                        num1 = 1685872673;
                        continue;
                    case 105:
                        gdelegate0_0 = gdelegate0_1;
                        num1 = 1685872729;
                        continue;
                    case 106:
                        binaryHash.Add(Convert.ToInt32("000000100010", 2));
                        num1 = 1685872702;
                        continue;
                    case 107:
                        charList = new List<char>();
                        num1 = 1685872709;
                        continue;
                    case 109:
                        charList.Add('T');
                        charList.Add('U');
                        charList.Add('V');
                        num1 = 1685872766;
                        continue;
                    case 110:
                        binaryHash.Add(Convert.ToInt32("101000000001", 2));
                        num1 = 1685872745;
                        continue;
                    case 111:
                        charList.Add('Z');
                        charList.Add('a');
                        charList.Add('b');
                        num1 = 1685872652;
                        continue;
                    case 112:
                        charList.Add('m');
                        num1 = 1685872699;
                        continue;
                    case 113:
                        binaryHash.Add(Convert.ToInt32("110100000000", 2));
                        binaryHash.Add(Convert.ToInt32("110010000000", 2));
                        binaryHash.Add(Convert.ToInt32("110001000000", 2));
                        num1 = 1685872762;
                        continue;
                    case 114:
                        charList.Add('h');
                        num1 = 1685872659;
                        continue;
                    case 115:
                        charList.Add('@');
                        num1 = 1685872650;
                        continue;
                    case 116:
                        binaryHash.Add(Convert.ToInt32("011000000100", 2));
                        binaryHash.Add(Convert.ToInt32("011000000010", 2));
                        binaryHash.Add(Convert.ToInt32("011000000001", 2));
                        binaryHash.Add(Convert.ToInt32("000010000010", 2));
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
            soundPlayer_1 = new SoundPlayer(new MemoryStream(ns0.Resource.fast));
        }

        [SpecialName]
        public Bitmap method_0()
        {
            return bitmap_1;
        }

        public bool GenerateHashtable1(string calibCode1, string calibCode2)
        {
            List<uint> calibrationIntegerList = new List<uint>();
            label_3:
            int num1 = 2125357806;
            int startIndex = 0;
            label_15:
            if (startIndex < calibCode1.Length)
            {
                try
                {
                    calibrationIntegerList.Add(Convert.ToUInt32(calibCode1.Substring(startIndex, 8), 16));
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
                        if (calibCode2.Length == 0)
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
            bool flag = false;
            try
            {
                GClass0.GDelegate1<ulong, string> gdelegate1 = GenerateMethod(calibrationIntegerList.ToArray());
                label_31:
                int num2 = 2125357800;
                ulong num5 = 0;
                while (true)
                {
                    int num4 = 2125357807;
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
                            if (hashPipeBinary.ContainsKey(num5))
                            {
                                hashtable_1.Add(charList[startIndex], hashPipeBinary[num5]);
                                num2 = 2125357805;
                                continue;
                            }
                            goto label_32;
                        case 7:
                            CreateMapPipeBinary();
                            hashtable_1 = new Hashtable();
                            num2 = 2125357807;
                            continue;
                        case 8:
                            num5 = gdelegate1(startIndex < calibCode2.Length ? charList[startIndex].ToString() + calibCode2[startIndex].ToString() : charList[startIndex].ToString());
                            num2 = 2125357801;
                            continue;
                        case 10:
                            int num6;
                            int num7;
                            if (startIndex >= charList.Count)
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
            if (calibCode2.Length > charList.Count)
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

        private void CreateMapPipeBinary()
        {
            hashPipeBinary = new Hashtable();
            label_10:
            int num1 = 722124814;
            int index = 0;
            byte[] pipeArray = null;
            while (true)
            {
                int num2 = 722124815;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_9;
                    case 1:
                        pipeArray = new Pipe().GetAndDecrypt(65280, Class0.currentHash);
                        index = 0;
                        num1 = 722124811;
                        continue;
                    case 2:
                        hashPipeBinary.Add(BitConverter.ToUInt64(pipeArray, index * 8), binaryHash[index]);
                        num1 = 722124812;
                        continue;
                    case 3:
                        ++index;
                        num1 = 722124811;
                        continue;
                    case 4:
                        int num3;
                        int num4;
                        if (index >= charList.Count)
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

        private GDelegate1<ulong, string> GenerateMethod(uint[] uint_0)
        {
            MethodInfo method = assembly_0.GetType("DynMethod.DynMethodFactory").GetMethod("createMethod");
            DynamicMethod dynamicMethod = (DynamicMethod)method.Invoke(null, new object[1] { uint_0 });
            return (GDelegate1<ulong, string>)dynamicMethod.CreateDelegate(typeof(GDelegate1<ulong, string>));
        }

        public void DoIt(string[] punchData)
        {
            try
            {
                if (punchData.Length == 0)
                    throw new GException0(string.Format("No data to punch!"));
                label_66:
                Validate(punchData);
                int num1 = -1559479496;
                BitmapData bitmapdata = null;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                byte[] numArray = null;
                int num6 = 0;
                int num7 = 0;
                int index1 = 0;
                string str = null;
                int num8 = 0;
                int index2 = 0;
                char ch = ' ';
                goto wtfwhile;
                wtflabel:
                str = punchData[index2];
                num1 = -1559479493;
                wtfwhile:
                while (true)
                {
                    int num2 = -1559479510;
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
                            bitmapdata = bitmap_1.LockBits(new Rectangle(0, 0, bitmap_1.Width, bitmap_1.Height), ImageLockMode.ReadWrite, bitmap_1.PixelFormat);
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
                            bitmap_1.UnlockBits(bitmapdata);
                            gdelegate0_0(GEnum0.const_0, new Bitmap(bitmap_1));
                            soundPlayer_1.PlaySync();
                            num1 = -1559479512;
                            continue;
                        case 6:
                            ch = str[index1];
                            num1 = -1559479514;
                            continue;
                        case 7:
                            label_37:
                            str = punchData[index2];
                            num1 = -1559479493;
                            continue;
                        case 8:
                            Marshal.Copy(bitmapdata.Scan0, numArray, 0, numArray.Length);
                            bitmap_1.UnlockBits(bitmapdata);
                            num1 = -1559479510;
                            continue;
                        case 9:
                            ++index1;
                            num1 = -1559479491;
                            continue;
                        case 10:
                            int num12;
                            int num13;
                            if (bool_0)
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
                            num5 = (int)hashtable_1[ch];
                            num1 = -1559479509;
                            continue;
                        case 13:
                            method_7(numArray, num7 + num3, num4 + num6, (byte)0);
                            ++num6;
                            num1 = -1559479519;
                            continue;
                        case 14:
                            soundPlayer_0.PlaySync();
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
                            bitmap_1 = punchcard.Clone(new Rectangle(0, 0, punchcard.Width, punchcard.Height), PixelFormat.Format4bppIndexed);
                            soundPlayer_0.PlaySync();
                            num1 = -1559479494;
                            continue;
                        case 18:
                            num8 = 0;
                            soundPlayer_0.PlaySync();
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
                            if (!bool_0)
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
                            bitmapdata = bitmap_1.LockBits(new Rectangle(0, 0, bitmap_1.Width, bitmap_1.Height), ImageLockMode.ReadWrite, bitmap_1.PixelFormat);
                            num3 = 0;
                            num1 = -1559479490;
                            continue;
                        default:
                            string filename = string.Format("punch_card_{0}.bmp", (object)Convert.ToString(num8).PadLeft(3, '0'));
                            try
                            {
                                bitmap_1.Clone(new Rectangle(0, 0, bitmap_1.Width, bitmap_1.Height), PixelFormat.Format4bppIndexed).Save(filename, ImageFormat.Bmp);
                            }
                            catch (Exception ex)
                            {
                                throw new GException0(string.Format("Can't save punchcard with name: {0}", (object)filename));
                            }
                            ++num8;
                            goto label_36;
                    }
                    label_26:
                    int num22;
                    int num23;
                    if (index2 < punchData.Length)
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
                                soundPlayer_0.PlaySync();
                                num22 = -1559479508;
                                continue;
                            case 1:
                                ++index2;
                                num22 = -1559479506;
                                continue;
                            case 2:
                                goto label_36;
                            case 3:
                                if (bool_0)
                                {
                                    num22 = -1559479510;
                                    continue;
                                }
                                goto wtflabel;
                            case 4:
                                goto label_26;
                            case 5:
                                goto label_65;
                            case 6:
                                gdelegate0_0(GEnum0.const_1, null);
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
                gdelegate0_0(GEnum0.PunchError, ex);
            }
        }

        public void method_5()
        {
            bool_0 = true;
        }

        protected void Validate(string[] string_1)
        {
            int num1 = 1;
            label_20:
            int num2 = 920829957;
            string str1 = null;
            int index1 = 0;
            string[] strArray = null;
            int index2 = 0;
            string str2 = null;
            while (true)
            {
                int num3 = 920829955;
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
                        if (!hashtable_1.ContainsKey((object)str1[index1]))
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
            throw new GException0(string.Format("Invalid character on line nr.: {0}", (object)num1));
            label_22:
            throw new GException0(string.Format("Maximum line length exceeded on line nr.: {0}", (object)num1));
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
                        byte_0[index] = (byte)((uint)byte_0[index] & (uint)(byte)((int)byte_1 << 4 | 15));
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
                        byte_0[index] = (byte)((uint)byte_0[index] & (uint)(byte)((uint)byte_1 | 240U));
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
            PunchError,
        }

        public delegate T GDelegate1<T, U>(U gparam_0);
    }
}
