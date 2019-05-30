using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bmp = File.ReadAllBytes(@".\punchcard.bmp");
            byte[] BufferVM = {
                0xD0, 0xFC, 0xF9, 0xF7, 0x63, 0xED, 0x71, 0xFA, 0xD6, 0xAE, 0xE6, 0x62,
                0x36, 0xFB, 0x63, 0x7F, 0x77, 0xE9
            };
            byte[] VMConst = {
                0x45, 0x54, 0x53, 0x45
            };

            byte[] RegKey = null;

            byte[] BufferVM2 = {
                0x82, 0x99, 0x8F, 0x92, 0x11, 0x9E, 0x18, 0x94, 0xB1, 0x8E, 0x8F, 0x11,
                0x16, 0x9C, 0x11, 0x1A, 0x16, 0x9D
            };

            byte[] Buffer512 = new byte[512];

            for (int i = 0; i < BufferVM.Length; i++)
            {
                byte temp;
                byte[] Buffer = null;
                if (RegKey != null)
                {
                    temp = RegKey[i % RegKey.Length];
                    Buffer = BufferVM;
                }
                else
                {
                    temp = 0;
                    Buffer = BufferVM2;
                }

                temp ^= Buffer[i];
                temp++;
                temp = (byte)((temp >> 7 | (temp << 1)));
                Buffer[i] = (byte)(temp ^ VMConst[i % VMConst.Length]);
            }
            System.Console.WriteLine(System.Text.Encoding.ASCII.GetString(BufferVM2));
            Reverse(BufferVM2);

            for (int i = 0; i < Buffer512.Length; i++)
                Buffer512[i] = (byte)i;

            for (int i = 0, j = 0; i < 0x100; i++)
            {
                j = (j + Buffer512[i] + BufferVM2[i % BufferVM2.Length]) % 0x100;
                byte temp = Buffer512[i];
                Buffer512[i] = Buffer512[j];
                Buffer512[j] = temp;
            }

            byte[] bmp2 = new byte[bmp.Length];

            for (int i = 0, j = 0, k = 0; k < bmp2.Length; k++)
            {
                i = (i + 1) % 0x100;
                j = (j + Buffer512[i]) % 0x100;

                byte temp = Buffer512[i];
                Buffer512[i] = Buffer512[j];
                Buffer512[j] = temp;

                bmp2[k] = (byte)(Buffer512[(Buffer512[i] + Buffer512[j]) % 0x100] ^ bmp[k]);
            }

            File.WriteAllBytes(@".\punchcard_1.bmp", bmp2);
        }

        static void Reverse(byte[] input)
        {
            byte[] BufferVM = {
                0xD0, 0xFC, 0xF9, 0xF7, 0x63, 0xED, 0x71, 0xFA, 0xD6, 0xAE, 0xE6, 0x62,
                0x36, 0xFB, 0x63, 0x7F, 0x77, 0xE9
            };
            byte[] VMConst = {
                0x45, 0x54, 0x53, 0x45
            };

            byte[] RegKey = new byte[64];

            for (int i = 0; i < input.Length; i++)
            {
                int temp = input[i] ^ VMConst[i % VMConst.Length];
                temp = ((temp << 7 | (temp >> 1)));
                temp--;
                temp = temp ^ BufferVM[i];
                RegKey[i] = (byte)temp;
            }

            System.Console.WriteLine(System.Text.Encoding.ASCII.GetString(RegKey));
        }
    }
}
