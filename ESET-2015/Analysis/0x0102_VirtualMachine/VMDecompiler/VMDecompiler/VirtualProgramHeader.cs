using System;
using System.IO;
using System.Reflection;

namespace VMDecompiler
{
    internal class SerializationOrder : Attribute
    {
        public int order { get; private set; }
        public SerializationOrder(int i)
        {
            order = i;
        }
    }

    public class VirtualProgramHeader
    {
        int headerSize;
        [SerializationOrder(0)]
        byte[] signature = new byte[2];
        byte[] Field_1 = new byte[4];
        byte[] Field_2 = new byte[4];
        byte[] Field_3 = new byte[4];
        byte[] Field_4 = new byte[4];

        #region Accessors
        public bool InitWillRun
        {
            get
            {
                return BitConverter.ToInt16(signature, 0) == 0x1337;
            }
        }
        public int MainOffset
        {
            get
            {
                return BitConverter.ToInt32(Field_1, 0) - headerSize;
            }
        }
        public int ProgramSize
        {
            get { return BitConverter.ToInt32(Field_3, 0); }
        }
        public int LibraryFlag { get { return BitConverter.ToInt32(Field_4, 0); } }
        public int HeaderSize { get { return headerSize; } }
        public int CustomData
        {
            get { return BitConverter.ToInt32(Field_2, 0) - headerSize; }
        }
        #endregion

        public void DecodeHeader(FileStream fs)
        {
            headerSize = 0;
            headerSize += fs.Read(signature, 0, signature.Length);
            headerSize += fs.Read(Field_1, 0, Field_1.Length);
            headerSize += fs.Read(Field_2, 0, Field_2.Length);
            headerSize += fs.Read(Field_3, 0, Field_3.Length);
            headerSize += fs.Read(Field_4, 0, Field_4.Length);
        }
    }
}
