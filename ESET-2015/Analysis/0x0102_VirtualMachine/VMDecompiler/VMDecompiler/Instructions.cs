using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace VMDecompiler
{
    class DecodeOpcode : System.Attribute
    {
        public DecodeOpcode(int number)
        {
            methodOpcode = number;
        }
        public int methodOpcode { get; private set; }
    }
    public class InstructionElement
    {
        public string content { set; private get; }
        public int style;
        public Color backgroundColor;
        byte[] rawBytes;

        override public string ToString()
        {
            return content;
        }
    }
    public class DecodedInstruction : IEnumerable<InstructionElement>
    {
        public DecodedInstruction(Context ctx, string instructionName = null, int operandsNumber = 0)
        {
            InitOperands(operandsNumber);

            this[0].content = instructionName;

            if (ctx.CurrentPointer - 1 == 0)
            {
                if (ctx.VirtualHeader.InitWillRun)
                    beforeComment = Properties.Resources.InitializeRoutineWillRun;
                else
                    beforeComment = Properties.Resources.InitializeRoutineWillNotRun;
            }
            else if (ctx.CurrentPointer - 1 == ctx.VirtualHeader.MainOffset)
            {
                beforeComment = Properties.Resources.MainRoutine;
                ctx.ResetPointer();
            }

            offset = ctx.CurrentPointer - 1;
        }

        public int offset;
        List<InstructionElement> operands;
        public string beforeComment;
        public string afterComment;
        public string inlinePostfixComment;
        public string inlinePrefixComment;


        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", operands.First().ToString());
            bool firstOperand = true;

            foreach (InstructionElement element in operands)
            {
                if (element.Equals(operands.First()))
                    continue;

                if (!firstOperand)
                {
                    sb.Append(",");
                    firstOperand = false;
                }

                sb.AppendFormat(" {0}", element.ToString());
            }

            return sb.ToString();
        }
        public void InitOperands(int operandsNumber)
        {
            operands = new List<InstructionElement>();
            for (int i = 0; i < operandsNumber + 1; i++)
                operands.Add(new InstructionElement());
        }

        public InstructionElement this[int element]
        {
            get { return operands[element]; }
            set { operands[element] = value; }
        }

        public IEnumerator<InstructionElement> GetEnumerator()
        {
            return operands.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return operands.GetEnumerator();
        }
    }
}