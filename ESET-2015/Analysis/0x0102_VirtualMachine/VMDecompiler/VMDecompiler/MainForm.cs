using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VMDecompiler
{
    public partial class MainForm : Form
    {
        Context ctx;
        bool fileLoaded;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionDecoder id = new InstructionDecoder();
            StringBuilder sb = new StringBuilder();

            if (loadFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // Set window text
            Text = "ESET VM Decompiler - " + loadFileDialog.FileName.Substring(loadFileDialog.FileName.LastIndexOf('\\') + 1);

            using (FileStream fs = File.Open(loadFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                ctx = new Context(fs);
                VirtualProgramHeader vh = ctx.VirtualHeader;
                decompiled.Text = "";

                try
                {
                    foreach (DecodedInstruction di in id.GetDecodedInstructions(ctx))
                    {
                        Color c = decompiled.SelectionColor;
                        if (di.beforeComment != null)
                        {
                            decompiled.SelectionColor = Color.Green;
                            decompiled.AppendText(di.beforeComment);
                            decompiled.SelectionColor = c;
                        }

                        decompiled.AppendText(string.Format("vm_{0:X4}: ", di.offset));

                        decompiled.SelectionColor = Color.Blue;
                        decompiled.AppendText(di.First().ToString());
                        decompiled.SelectionColor = c;

                        bool firstOperand = true;

                        foreach (InstructionElement element in di)
                        {
                            if (element.Equals(di.First()))
                                continue;

                            if (!firstOperand)
                                decompiled.AppendText(",");

                            decompiled.AppendText(string.Format(" {0}", element.ToString()));
                            firstOperand = false;
                        }

                        if (di.inlinePostfixComment != null)
                            decompiled.AppendText(di.inlinePostfixComment);
                        decompiled.AppendText(Environment.NewLine);
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error while decompiling!");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            decompiled.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }

        private void loadDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() != DialogResult.OK)
                return;
            ctx.additionalFile = String.Copy(loadFileDialog.FileName);
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProgramInfoForm(ctx).ShowDialog();
        }
    }
}
