// Decompiled with JetBrains decompiler
// Type: DynMethod.DynMethodFactory
// Assembly: CalibrationDynMethod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22B0C867-D633-4DA5-B05B-C988049911F2
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\Resources\0xFF04_CalibrationDynMethod.dll\CalibrationDynMethod.dll

using IlEmitHelp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace DynMethod
{
    public static class DynMethodFactory
    {
        public static DynamicMethod createMethod(uint[] instructionHashes)
        {
            // Get all opcodes except break
            OpCode[] opCodeArray = Enumerable.ToArray
            (
                Enumerable.Where
                (
                    Enumerable.Select
                    (
                        Enumerable.Where
                        (
                            typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public),
                            x => x.FieldType == typeof(OpCode)
                        ),
                        x => (OpCode)x.GetValue(null)
                    ),
                    x => !x.Name.Equals("break")
                )
            );

            OneParameter<uint, string> methodForOpcodes = create_HashMethodForOpcodes();
            Hashtable hashtable = new Hashtable();
            foreach (OpCode opCode in opCodeArray)
                hashtable.Add(methodForOpcodes(opCode.Name), opCode);
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(ulong), new Type[1] { typeof (string) });
            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
            ilGenerator.DeclareLocal(typeof(ulong), true);
            ilGenerator.DeclareLocal(typeof(int), true);
            ilGenerator.DeclareLocal(typeof(ulong), true);
            ilGenerator.DeclareLocal(typeof(bool), true);
            Label label1 = ilGenerator.DefineLabel();
            Label label2 = ilGenerator.DefineLabel();
            Label label3 = ilGenerator.DefineLabel();
            IlParticlesEmitor ilParticlesEmitor = new IlParticlesEmitor(ilGenerator);
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Nop,     null, "IL_00000"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldc_I8,  3074457345618258791, "IL_00010"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_0, null, "IL_000a0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldc_I4_0,null, "IL_000b0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_1, null, "IL_000c0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Br_S,    label1, "IL_000d0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(label2,          null, "IL_000d9"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Nop,     null, "IL_000f0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_0, null, "IL_00100"));
            try
            {
                ilParticlesEmitor.addILParticle(new ILEmitParticle(hashtable[instructionHashes[0]], null, "IL_00110"));
            }
            catch (Exception ex)
            {
            }
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_1, null, "IL_00120"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Callvirt, typeof(string).GetMethod("get_Chars"), "IL_00130"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Conv_U8, null, "IL_00180"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Add, null, "IL_00190"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_0, null, "IL_001a0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_0, null, "IL_001b0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldc_I8, 3074457345618258799, "IL_001c0"));
            try
            {
                ilParticlesEmitor.addILParticle(new ILEmitParticle(hashtable[instructionHashes[1]], null, "IL_00250"));
            }
            catch (Exception ex)
            {
            }
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_0, null, "IL_00260"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Nop, null, "IL_00270"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_1, null, "IL_00280"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldc_I4_1, null, "IL_00290"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Add, null, "IL_002a0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_1, null, "IL_002b0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(label1, null, "IL_002b9"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_1, null, "IL_002c0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldarg_0, null, "IL_002d0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Callvirt, typeof(string).GetMethod("get_Length"), "IL_002e0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Clt, null, "IL_00330"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_3, null, "IL_00350"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_3, null, "IL_00360"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Brtrue_S, label2, "IL_00370"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_0, null, "IL_00390"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Stloc_2, null, "IL_003a0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Br_S, label3, "IL_003b0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(label3, null, "IL_003c9"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ldloc_2, null, "IL_003d0"));
            ilParticlesEmitor.addILParticle(new ILEmitParticle(OpCodes.Ret, null, "IL_003e0"));
            ilParticlesEmitor.emitParticles();
            return dynamicMethod;
        }

        public static DynMethodFactory.OneParameter<uint, string> create_HashMethodForOpcodes()
        {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(uint), new Type[1]
            {
        typeof (string)
            });
            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
            ilGenerator.DeclareLocal(typeof(uint));
            ilGenerator.DeclareLocal(typeof(int));
            Label label1 = ilGenerator.DefineLabel();
            Label label2 = ilGenerator.DefineLabel();
            MethodInfo method1 = typeof(string).GetMethod("get_Chars", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder)null, new Type[1]
            {
        typeof (int)
            }, (ParameterModifier[])null);
            MethodInfo method2 = typeof(string).GetMethod("get_Length", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder)null, new Type[0], (ParameterModifier[])null);
            ilGenerator.Emit(OpCodes.Ldc_I4_0);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_0);
            ilGenerator.Emit(OpCodes.Stloc_1);
            ilGenerator.Emit(OpCodes.Br_S, label1);
            ilGenerator.MarkLabel(label2);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldarg_0);
            ilGenerator.Emit(OpCodes.Ldloc_1);
            ilGenerator.Emit(OpCodes.Callvirt, method1);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_S, 10);
            ilGenerator.Emit(OpCodes.Shl);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_6);
            ilGenerator.Emit(OpCodes.Shr_Un);
            ilGenerator.Emit(OpCodes.Xor);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_1);
            ilGenerator.Emit(OpCodes.Ldc_I4_1);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Stloc_1);
            ilGenerator.MarkLabel(label1);
            ilGenerator.Emit(OpCodes.Ldloc_1);
            ilGenerator.Emit(OpCodes.Ldarg_0);
            ilGenerator.Emit(OpCodes.Callvirt, method2);
            ilGenerator.Emit(OpCodes.Blt_S, label2);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_3);
            ilGenerator.Emit(OpCodes.Shl);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_S, 11);
            ilGenerator.Emit(OpCodes.Shr_Un);
            ilGenerator.Emit(OpCodes.Xor);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4_S, 15);
            ilGenerator.Emit(OpCodes.Shl);
            ilGenerator.Emit(OpCodes.Add);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ret);
            return (DynMethodFactory.OneParameter<uint, string>)dynamicMethod.CreateDelegate(typeof(DynMethodFactory.OneParameter<uint, string>));
        }

        public delegate TReturn OneParameter<TReturn, TParameter0>(TParameter0 p0);
    }
}
