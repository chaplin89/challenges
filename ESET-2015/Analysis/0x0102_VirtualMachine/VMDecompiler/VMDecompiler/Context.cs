using System.IO;

namespace VMDecompiler
{
    public class Context
    {
        public string additionalFile;
        FileStream stream;
        int currentPointer = 0;
        VirtualProgramHeader header = new VirtualProgramHeader();

        public VirtualProgramHeader VirtualHeader
        {
            get { return header; }
        }
        public int CurrentPointer
        {
            get { return currentPointer; }
        }

        public Context(FileStream fs)
        {
            (stream = fs).Seek(0, SeekOrigin.Begin);
            header.DecodeHeader(stream);
        }

        public void ResetPointer()
        {
            currentPointer = 1;
        }

        public int ReadByte()
        {
            int currentByte = stream.ReadByte();
            if (currentByte != -1)
                ++currentPointer;

            return currentByte;
        }
        public int Read(byte[] destination, int offset, int size)
        {
            int readedBytes = stream.Read(destination, offset, size);
            currentPointer += readedBytes;
            return readedBytes;
        }
    }
}

