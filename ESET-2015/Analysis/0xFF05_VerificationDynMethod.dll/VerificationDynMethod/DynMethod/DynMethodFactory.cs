using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace DynMethod
{
    public static class DynMethodFactory
    {
        public static DynamicMethod createMethod(string[] instructions)
        {
            OpCode[] opCodeArray = Enumerable.ToArray<OpCode>
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
                        (Func<FieldInfo, OpCode>)(x => (OpCode)x.GetValue(null))), 
                        (Func<OpCode, bool>)(x => !x.Name.Equals("break"))
                )
            );

            Hashtable hashtable = new Hashtable();
            foreach (OpCode opCode in opCodeArray)
                hashtable.Add(opCode.Name, opCode);

            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(bool), new Type[0]);
            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
            MethodInfo method1 = typeof(Encoding).GetMethod("get_ASCII", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
            MethodInfo method2 = typeof(Encoding).GetMethod("GetBytes", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof (string) }, null);
            MethodInfo method3 = typeof(BitConverter).GetMethod("ToUInt32", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2] { typeof (byte[]), typeof (int)}, null);
            ilGenerator.DeclareLocal(typeof(uint)); // 0xDEAD
            ilGenerator.DeclareLocal(typeof(uint)); // 0xBEEF
            ilGenerator.DeclareLocal(typeof(uint)); // 0xCAFE
            ilGenerator.DeclareLocal(typeof(uint)); // 0xBABE
            ilGenerator.DeclareLocal(typeof(uint)); // 0xFACE
            ilGenerator.DeclareLocal(typeof(uint));
            ilGenerator.DeclareLocal(typeof(byte[]));
            ilGenerator.DeclareLocal(typeof(uint));
            ilGenerator.DeclareLocal(typeof(bool));
            ilGenerator.DeclareLocal(typeof(bool));
            Label label1 = ilGenerator.DefineLabel();
            Label label2 = ilGenerator.DefineLabel();
            ilGenerator.Emit(OpCodes.Nop);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0xDEAD);
            ilGenerator.Emit(OpCodes.Stloc_0);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0xBEEF);
            ilGenerator.Emit(OpCodes.Stloc_1);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0xCAFE);
            ilGenerator.Emit(OpCodes.Stloc_2);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0xBABE);
            ilGenerator.Emit(OpCodes.Stloc_3);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0xFACE);
            ilGenerator.Emit(OpCodes.Stloc_S, 4);
            ilGenerator.Emit(OpCodes.Ldloc_0);
            ilGenerator.Emit(OpCodes.Ldloc_1);
            try
            {
                ilGenerator.Emit((OpCode)hashtable[instructions[0]]); // 
            }
            catch (Exception)
            {
            }
            ilGenerator.Emit(OpCodes.Ldloc_2);
            ilGenerator.Emit(OpCodes.Ldloc_3);

            try
            {
                ilGenerator.Emit((OpCode)hashtable[(object)instructions[1]]);
            }
            catch (Exception)
            {
            }
            ilGenerator.Emit(OpCodes.Xor);
            ilGenerator.Emit(OpCodes.Ldloc_S, 4);
            ilGenerator.Emit(OpCodes.Xor);
            ilGenerator.Emit(OpCodes.Ldc_I4, -229612108);
            ilGenerator.Emit(OpCodes.Xor);
            ilGenerator.Emit(OpCodes.Stloc_S, 5);
            ilGenerator.Emit(OpCodes.Call, method1);
            ilGenerator.Emit(OpCodes.Ldstr, "ESET");
            ilGenerator.Emit(OpCodes.Callvirt, method2);
            ilGenerator.Emit(OpCodes.Stloc_S, 6);
            ilGenerator.Emit(OpCodes.Ldloc_S, 6);
            ilGenerator.Emit(OpCodes.Ldc_I4_0);
            ilGenerator.Emit(OpCodes.Call, method3);
            ilGenerator.Emit(OpCodes.Stloc_S, 7);
            ilGenerator.Emit(OpCodes.Ldloc_S, 5);
            ilGenerator.Emit(OpCodes.Ldloc_S, 7);
            ilGenerator.Emit(OpCodes.Ceq);
            ilGenerator.Emit(OpCodes.Ldc_I4_0);
            ilGenerator.Emit(OpCodes.Ceq);
            ilGenerator.Emit(OpCodes.Stloc_S, 9);
            ilGenerator.Emit(OpCodes.Ldloc_S, 9);
            ilGenerator.Emit(OpCodes.Brtrue_S, label1);
            ilGenerator.Emit(OpCodes.Ldc_I4_1);
            ilGenerator.Emit(OpCodes.Stloc_S, 8);
            ilGenerator.Emit(OpCodes.Br_S, label2);
            ilGenerator.MarkLabel(label1);
            ilGenerator.Emit(OpCodes.Ldc_I4_0);
            ilGenerator.Emit(OpCodes.Stloc_S, 8);
            ilGenerator.Emit(OpCodes.Br_S, label2);
            ilGenerator.MarkLabel(label2);
            ilGenerator.Emit(OpCodes.Ldloc_S, 8);
            try
            {
                ilGenerator.Emit((OpCode)hashtable[(object)instructions[2]]);
            }
            catch (Exception)
            {
            }
            return dynamicMethod;
        }

        public delegate TReturn OneParameter<TReturn, TParameter0>(TParameter0 p0);
    }
}
