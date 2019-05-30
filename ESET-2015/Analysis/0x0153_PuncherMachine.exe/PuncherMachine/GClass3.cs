// Decompiled with JetBrains decompiler
// Type: ns0.GClass3
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace PuncherMachine
{
    public class GClass3
    {
        protected ILGenerator ilgenerator_0;
        protected List<GClass4> list_0;

        public GClass3(ILGenerator ilgenerator_1)
        {
            this.ilgenerator_0 = ilgenerator_1;
            this.list_0 = new List<GClass4>();
        }

        public void method_0(GClass4 gclass4_0)
        {
            this.list_0.Add(gclass4_0);
        }

        public void method_1()
        {
            this.list_0.Sort();
            using (List<GClass4>.Enumerator enumerator = this.list_0.GetEnumerator())
            {
                label_60:
                while (enumerator.MoveNext())
                {
                    OperandType operandType = new OperandType();
                    OpCode opCode = new OpCode();
                    label_59:
                    GClass4 current = enumerator.Current;
                    if (!(current.object_0 is OpCode))
                        goto label_54;
                    else
                        goto label_55;
                    label_52:
                    int num1;
                    while (true)
                    {
                        int num2 = 1989584564;
                        switch (num1 ^ num2)
                        {
                            case 0:
                                this.ilgenerator_0.Emit((OpCode)current.object_0);
                                num1 = 1989584547;
                                continue;
                            case 1:
                                goto label_59;
                            case 2:
                                label_26:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (long)current.object_1);
                                num1 = 1989584563;
                                continue;
                            case 3:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (byte)current.object_1);
                                num1 = 1989584570;
                                continue;
                            case 4:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (int)current.object_1);
                                num1 = 1989584575;
                                continue;
                            case 6:
                                num1 = 1989584561;
                                continue;
                            case 7:
                                num1 = 1989584561;
                                continue;
                            case 8:
                                int num3;
                                int num4;
                                if (current.object_1 is int)
                                {
                                    int num5 = 1989584560;
                                    num4 = 1989584560;
                                    num3 = num5;
                                }
                                else
                                {
                                    num3 = 1989584568;
                                    num4 = 1989584568;
                                }
                                num1 = num3;
                                continue;
                            case 9:
                                num1 = 1989584558;
                                continue;
                            case 10:
                                label_25:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (int)current.object_1);
                                num1 = 1989584550;
                                continue;
                            case 11:
                                num1 = 1989584561;
                                continue;
                            case 12:
                                if (current.object_1 is MethodInfo)
                                {
                                    this.ilgenerator_0.Emit((OpCode)current.object_0, (MethodInfo)current.object_1);
                                    num1 = 1989584561;
                                    continue;
                                }
                                goto label_61;
                            case 13:
                                num1 = 1989584561;
                                continue;
                            case 14:
                                num1 = 1989584561;
                                continue;
                            case 15:
                                operandType = opCode.OperandType;
                                num1 = 1989584553;
                                continue;
                            case 16:
                                opCode = (OpCode)current.object_0;
                                num1 = 1989584571;
                                continue;
                            case 17:
                                this.ilgenerator_0.MarkLabel((Label)current.object_0);
                                num1 = 1989584561;
                                continue;
                            case 18:
                                num1 = 1989584561;
                                continue;
                            case 19:
                                label_31:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (string)current.object_1);
                                num1 = 1989584562;
                                continue;
                            case 20:
                                num1 = 1989584565;
                                continue;
                            case 21:
                                switch (operandType)
                                {
                                    case OperandType.InlineString:
                                        goto label_31;
                                    case OperandType.ShortInlineI:
                                        goto label_8;
                                    case OperandType.ShortInlineR:
                                        goto label_16;
                                    default:
                                        num1 = 1989584555;
                                        continue;
                                }
                            case 22:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (float)current.object_1);
                                num1 = 1989584569;
                                continue;
                            case 23:
                                num1 = 1989584561;
                                continue;
                            case 24:
                                goto label_61;
                            case 25:
                                int num6;
                                int num7;
                                switch (operandType)
                                {
                                    case OperandType.InlineI:
                                        goto label_25;
                                    case OperandType.InlineI8:
                                        goto label_26;
                                    case OperandType.InlineR:
                                        int num8 = 1989584546;
                                        num7 = 1989584546;
                                        num6 = num8;
                                        break;
                                    default:
                                        num6 = 1989584573;
                                        num7 = 1989584573;
                                        break;
                                }
                                num1 = num6;
                                continue;
                            case 26:
                                int num9;
                                int num10;
                                if (!(current.object_1 is byte))
                                {
                                    int num5 = 1989584572;
                                    num10 = 1989584572;
                                    num9 = num5;
                                }
                                else
                                {
                                    num9 = 1989584567;
                                    num10 = 1989584567;
                                }
                                num1 = num9;
                                continue;
                            case 27:
                                goto label_54;
                            case 28:
                                label_16:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (float)current.object_1);
                                num1 = 1989584561;
                                continue;
                            case 29:
                                int num11;
                                int num12;
                                if (operandType <= OperandType.InlineR)
                                {
                                    int num5 = 1989584557;
                                    num12 = 1989584557;
                                    num11 = num5;
                                }
                                else
                                {
                                    num11 = 1989584545;
                                    num12 = 1989584545;
                                }
                                num1 = num11;
                                continue;
                            case 30:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (Label)current.object_1);
                                num1 = 1989584532;
                                continue;
                            case 31:
                                num1 = 1989584558;
                                continue;
                            case 32:
                                num1 = 1989584561;
                                continue;
                            case 33:
                                label_8:
                                this.ilgenerator_0.Emit((OpCode)current.object_0, (byte)current.object_1);
                                num1 = 1989584561;
                                continue;
                            case 34:
                                int num13;
                                int num14;
                                if (current.object_1 is Label)
                                {
                                    int num5 = 1989584554;
                                    num14 = 1989584554;
                                    num13 = num5;
                                }
                                else
                                {
                                    num13 = 1989584548;
                                    num14 = 1989584548;
                                }
                                num1 = num13;
                                continue;
                            default:
                                goto label_60;
                        }
                    }
                    label_61:
                    throw new Exception("Invalid argument");
                    label_54:
                    int num15;
                    if (!(current.object_0 is Label))
                    {
                        num1 = 1989584561;
                        num15 = 1989584561;
                    }
                    else
                        goto label_53;
                    label_3:
                    goto label_52;
                    label_53:
                    int num16 = 1989584549;
                    num15 = 1989584549;
                    num1 = num16;
                    goto label_3;
                    label_55:
                    int num17;
                    int num18;
                    if (current.object_1 == null)
                    {
                        int num2 = 1989584564;
                        num18 = 1989584564;
                        num17 = num2;
                    }
                    else
                    {
                        num17 = 1989584534;
                        num18 = 1989584534;
                    }
                    num1 = num17;
                    goto label_52;
                }
            }
        }
    }
}
