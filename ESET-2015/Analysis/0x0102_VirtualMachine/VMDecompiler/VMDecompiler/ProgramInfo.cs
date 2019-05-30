using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMDecompiler
{
    public partial class ProgramInfoForm : Form
    {
        Context ctx;
        public ProgramInfoForm(Context currentCtx)
        {
            ctx = currentCtx;
            InitializeComponent();
        }

        private void ProgramInfoForm_Load(object sender, EventArgs e)
        {
            programInfo.Rows.Clear();
            if (ctx == null)
                return;
            programInfo.Rows.Add("Data", String.Format("{0:X}", ctx.VirtualHeader.CustomData));
            programInfo.Rows.Add("Library Flag", String.Format("{0:X}", ctx.VirtualHeader.LibraryFlag));
            programInfo.Rows.Add("Program Size", String.Format("{0:X}", ctx.VirtualHeader.ProgramSize));
            programInfo.Rows.Add("Header Size", String.Format("{0:X}", ctx.VirtualHeader.HeaderSize));
            programInfo.Rows.Add("Init will Run", ctx.VirtualHeader.InitWillRun);
            if (ctx.additionalFile == null)
                return;
            FileStream fs = null;
            try
            {
                byte[] readedBytes = new byte[4];
                fs = File.Open(ctx.additionalFile, FileMode.Open);
                for (int i=0; i<4; i++)
                {
                    fs.Read(readedBytes,0,readedBytes.Length);
                    //Array.Reverse(readedBytes, 0, readedBytes.Length);
                    int loadedDWORD = BitConverter.ToInt32(readedBytes,0);
                    programInfo.Rows.Add(string.Format("reg_{0}",i+9), String.Format("{0:X}",loadedDWORD) );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Unable to open additional input file: {0}", ex.Message), "Error!");
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }

            
        }
    }
}
