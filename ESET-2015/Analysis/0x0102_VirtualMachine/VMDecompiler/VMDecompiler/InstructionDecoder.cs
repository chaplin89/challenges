using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace VMDecompiler
{
    class InstructionDecoder
    {

        /// <summary>
        /// Decode data location
        /// </summary>
        /// <param name="ctx">
        /// Current context
        /// </param>
        /// <param name="type">
        /// type = 0, direct register access
        /// type = 1, indirect register access
        /// type = 2, constant
        /// type = 3, constant + offset register
        /// </param>
        /// <param name="register">
        /// type 0,1: index of the register. 
        /// Unused otherwise.
        /// </param>
        /// <param name="size">
        /// Size in word (0,1,2)
        /// </param>
        /// <returns>
        /// Decoded data location
        /// </returns>
        private InstructionElement DecodeDataLocation(Context ctx, int type, int register, int size)
        {
            InstructionElement ie = new InstructionElement();
            byte[] constant = new byte[4];
            StringBuilder sb = new StringBuilder();
            switch (size)
            {
                case 1:
                    sb.Append("word ");
                    break;
                case 2:
                    sb.Append("dword ");
                    break;
                default:
                    sb.Append("byte ");
                    break;
            }

            switch (type)
            {
                case 0:
                    switch (register)
                    {
                        case 6:
                            sb.Append("stackptr");
                            break;
                        case 7:
                            sb.Append("program");
                            break;
                        case 8:
                            sb.Append("size");
                            break;
                        case 9:
                            sb.Append("library");
                            break;
                        default:
                            sb.AppendFormat("reg_{0}", register);
                            break;
                    }
                    break;
                case 1:
                    switch (register)
                    {
                        case 6:
                            sb.Append("[stackptr]");
                            break;
                        case 7:
                            sb.Append("[ptr]");
                            break;
                        case 8:
                            sb.Append("[size]");
                            break;
                        case 9:
                            sb.Append("[library]");
                            break;
                        default:
                            sb.AppendFormat("[reg_{0}]", register);
                            break;
                    }
                    break;
                case 2:
                    switch (size)
                    {
                        case 2:
                            ctx.Read(constant, 0, 4);
                            break;
                        case 1:
                            ctx.Read(constant, 0, 2);
                            break;
                        default:
                            ctx.Read(constant, 0, 1);
                            break;
                    }
                    sb.AppendFormat("0x{0:X}", BitConverter.ToInt32(constant, 0));
                    break;
                case 3:
                    ctx.Read(constant, 0, 4);
                    sb.AppendFormat("0x{0:X} + offset", BitConverter.ToInt32(constant, 0));
                    break;
            }
            ie.content = sb.ToString();
            return ie;
        }

        [DecodeOpcode(0x00)]
        DecodedInstruction Decode0(Context ctx)
        {
            return new DecodedInstruction(ctx, "exit", 0);
        }
        [DecodeOpcode(0x01)]
        DecodedInstruction Decode1(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "mov", 2);
            byte[] arguments = new byte[2];

            ctx.Read(arguments, 0, 2);

            di[1] = DecodeDataLocation(ctx, arguments[1] >> 2 & 3, arguments[0] & 0xF, arguments[1] >> 4 & 3);
            di[2] = DecodeDataLocation(ctx, arguments[1] & 3, arguments[0] >> 4, (arguments[1] >> 4) & 3);

            return di;
        }
        [DecodeOpcode(0x02)]
         DecodedInstruction Decode2(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "native call", 1);
            int arguments = ctx.ReadByte();

            di[1] = DecodeDataLocation(ctx, (arguments >> 4) & 3, arguments & 0xF, 2);

            return di;
        }
        [DecodeOpcode(0x03)]
         DecodedInstruction Decode3(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "lib call", 2);
            byte[] arguments = new byte[2];
            
            ctx.Read(arguments, 0, 2);

            di[1].content = string.Format("function {0}", DecodeDataLocation(ctx, arguments[1] & 3, arguments[0] & 0xF, 2));
            di[2].content = string.Format("library {0}", DecodeDataLocation(ctx, arguments[1] >> 2 & 3, arguments[0] >> 4, 2));
            return di;
        }
        [DecodeOpcode(0x04)]
         DecodedInstruction Decode4(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "push", 1);
            int arguments = ctx.ReadByte();

            di[1] = DecodeDataLocation(ctx, (arguments >> 4) & 3, arguments & 0x0F, arguments >> 6);

            return di;
        }
        [DecodeOpcode(0x05)]
         DecodedInstruction Decode5(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "pop", 1);
            di[1]= DecodeDataLocation(ctx, 0, ctx.ReadByte() & 0xF, 2);
            return di;
        }
        [DecodeOpcode(0x06)]
         DecodedInstruction Decode6(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, null, 2);
            byte[] arguments = new byte[2];
            
            ctx.Read(arguments, 0, 2);

            switch ((arguments[1] >> 4) & 7)
            {
                case 1:
                    di[0].content = "notequal";
                    break;
                case 2:
                    di[0].content = "less";
                    break;
                default:
                    di[0].content = "equal";
                    break;
            }

            di[1] = DecodeDataLocation(ctx, 0, arguments[0] & 0xF, 2);
            di[2] = DecodeDataLocation(ctx, arguments[1] & 3, arguments[0] >> 4, arguments[1] >> 2 & 3);
            return di;
        }
        [DecodeOpcode(0x07)]
         DecodedInstruction Decode7(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx,"jmp", 1);  

            if (ctx.ReadByte() == 1)
                di[0].content = "cjmp";

            di[1] = DecodeDataLocation(ctx, 2, 0, 2);
            return di;
        }
        [DecodeOpcode(0x08)]
         DecodedInstruction Decode8(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "call", 1);
            di[1] = DecodeDataLocation(ctx, 2, 0, 2);
            return di;
        }
        [DecodeOpcode(0x09)]
         DecodedInstruction Decode9(Context ctx)
        {
            return new DecodedInstruction(ctx, "ret", 0);
        }
        [DecodeOpcode(0x0A)]
         DecodedInstruction DecodeA(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, null, 2);
            byte[] arguments = new byte[2];
            ctx.Read(arguments, 0, 2);

            switch ((arguments[1] >> 4) & 7)
            {
                case 0:
                    di[0].content = "xor";
                    break;
                case 1:
                    di[0].content = "add";
                    break;
                case 2:
                    di[0].content = "sub";
                    break;
                case 3:
                    di[0].content = "shl";
                    break;
                case 4:
                    di[0].content = "shr";
                    break;
                case 5:
                    di[0].content = "ror";
                    break;
                case 6:
                    di[0].content = "rol";
                    break;
                case 7:
                    di[0].content = "mod";
                    break;
            }
            di[1] = DecodeDataLocation(ctx, 0, arguments[0] & 0xF, 2);
            di[2] = DecodeDataLocation(ctx, arguments[1] & 3, arguments[0] >> 4, (arguments[1] >> 2) & 3);

            return di;
        }
        [DecodeOpcode(0x0B)]
         DecodedInstruction DecodeB(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx,"allocate",1);            
            int arguments = ctx.ReadByte();

            di[1] = DecodeDataLocation(ctx, (arguments >> 4) & 3, arguments & 0xF, arguments >> 6);
            return di;
        }
        [DecodeOpcode(0x0C)]
         DecodedInstruction DecodeC(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx, "deallocate", 1);            
            int arguments = ctx.ReadByte();

            di[1] = DecodeDataLocation(ctx, arguments >> 4 & 3, arguments & 0xF, arguments >> 6);
            return di;
        }
        [DecodeOpcode(0x0D)]
         DecodedInstruction DecodeD(Context ctx)
        {
            DecodedInstruction di = new DecodedInstruction(ctx,"reloadvm",2);
            byte[] arguments = new byte[2];
            ctx.Read(arguments, 0, 2);

            di[1] = DecodeDataLocation(ctx, arguments[1] & 3, arguments[0] & 0xF, 2);
            di[2] = DecodeDataLocation(ctx, (arguments[1] >> 2) & 3, arguments[0] >> 4, (arguments[1] >> 4) & 3);

            return di;
        }
        [DecodeOpcode(0x0E)]
         DecodedInstruction DecodeE(Context ctx)
        {
            return new DecodedInstruction(ctx, "fault", 0);
        }

        public IEnumerable<DecodedInstruction> GetDecodedInstructions(Context ctx)
        {
            int currentOpcode;
            bool decoded;
            
            while ((currentOpcode = ctx.ReadByte()) != -1)
            {
                byte opcode = (byte)currentOpcode;
                decoded = false;

                foreach (var member in typeof(InstructionDecoder).GetMembers(BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    foreach (object attribute in member.GetCustomAttributes(false))
                    {
                        if (attribute is DecodeOpcode)
                        {
                            DecodeOpcode currentAttribute = (DecodeOpcode)attribute;
                            if (currentAttribute.methodOpcode == opcode)
                            {
                                MethodInfo currentMethod = (MethodInfo)member;
                                DecodedInstruction di = (DecodedInstruction)currentMethod.Invoke(this, new object[] { ctx });

                                yield return di;
                                decoded = true;
                                break;
                            }
                        }
                    }
                    if (decoded)
                        break;
                }
                if (!decoded)
                {
                    yield return new DecodedInstruction(ctx, string.Format("Unsupported: 0x{0:X}", currentOpcode), 0);
                }
            }

            yield break;
        }
    }
}
