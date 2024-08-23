using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000111 RID: 273
	[global::Cpp2ILInjected.Token(Token = "0x2000149")]
	[global::System.Serializable]
	internal class DefaultBinder : global::System.Reflection.Binder
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x0001685C File Offset: 0x00014A5C
		[global::Cpp2ILInjected.Token(Token = "0x6000CFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C608BC", Offset = "0x1C608BC", Length = "0x1790")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CreateParamOrder", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(string[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "ReorderParams", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "UnsafeCreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 95)]
		public override global::System.Reflection.MethodBase BindToMethod(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.MethodBase[] match, ref object[] args, global::System.Reflection.ParameterModifier[] modifiers, global::System.Globalization.CultureInfo cultureInfo, string[] names, out object state)
		{
			throw null;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0001685F File Offset: 0x00014A5F
		[global::Cpp2ILInjected.Token(Token = "0x6000CFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C625B4", Offset = "0x1C625B4", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsClass", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificField", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingFieldException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override global::System.Reflection.FieldInfo BindToField(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.FieldInfo[] match, object value, global::System.Globalization.CultureInfo cultureInfo)
		{
			throw null;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00016862 File Offset: 0x00014A62
		[global::Cpp2ILInjected.Token(Token = "0x6000D00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C62AC4", Offset = "0x1C62AC4", Length = "0x8E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.Contracts.Contract), Member = "ForAll", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>", "System.Predicate`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecific", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Reflection.PropertyInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public override global::System.Reflection.PropertyInfo SelectProperty(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.PropertyInfo[] match, global::System.Type returnType, global::System.Type[] indexes, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00016865 File Offset: 0x00014A65
		[global::Cpp2ILInjected.Token(Token = "0x6000D01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C63D5C", Offset = "0x1C63D5C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override object ChangeType(object value, global::System.Type type, global::System.Globalization.CultureInfo cultureInfo)
		{
			throw null;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00016868 File Offset: 0x00014A68
		[global::Cpp2ILInjected.Token(Token = "0x6000D02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C63DB4", Offset = "0x1C63DB4", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "ReorderParams", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override void ReorderArgumentArray(ref object[] args, object state)
		{
			throw null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0001686B File Offset: 0x00014A6B
		[global::Cpp2ILInjected.Token(Token = "0x6000D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64028", Offset = "0x1C64028", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static global::System.Reflection.MethodBase ExactBinding(global::System.Reflection.MethodBase[] match, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0001686E File Offset: 0x00014A6E
		[global::Cpp2ILInjected.Token(Token = "0x6000D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64340", Offset = "0x1C64340", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.PropertyInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Reflection.PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static global::System.Reflection.PropertyInfo ExactPropertyBinding(global::System.Reflection.PropertyInfo[] match, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00016871 File Offset: 0x00014A71
		[global::Cpp2ILInjected.Token(Token = "0x6000D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6394C", Offset = "0x1C6394C", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static int FindMostSpecific(global::System.Reflection.ParameterInfo[] p1, int[] paramOrder1, global::System.Type paramArrayType1, global::System.Reflection.ParameterInfo[] p2, int[] paramOrder2, global::System.Type paramArrayType2, global::System.Type[] types, object[] args)
		{
			throw null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00016874 File Offset: 0x00014A74
		[global::Cpp2ILInjected.Token(Token = "0x6000D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C635C0", Offset = "0x1C635C0", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecific", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static int FindMostSpecificType(global::System.Type c1, global::System.Type c2, global::System.Type t)
		{
			throw null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00016877 File Offset: 0x00014A77
		[global::Cpp2ILInjected.Token(Token = "0x6000D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C62440", Offset = "0x1C62440", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecific", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CompareMethodSigAndName", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int FindMostSpecificMethod(global::System.Reflection.MethodBase m1, int[] paramOrder1, global::System.Type paramArrayType1, global::System.Reflection.MethodBase m2, int[] paramOrder2, global::System.Type paramArrayType2, global::System.Type[] types, object[] args)
		{
			throw null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0001687A File Offset: 0x00014A7A
		[global::Cpp2ILInjected.Token(Token = "0x6000D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C629E8", Offset = "0x1C629E8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToField", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.FieldInfo[]),
			typeof(object),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int FindMostSpecificField(global::System.Reflection.FieldInfo cur1, global::System.Reflection.FieldInfo cur2)
		{
			throw null;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0001687D File Offset: 0x00014A7D
		[global::Cpp2ILInjected.Token(Token = "0x6000D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C63C80", Offset = "0x1C63C80", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int FindMostSpecificProperty(global::System.Reflection.PropertyInfo cur1, global::System.Reflection.PropertyInfo cur2)
		{
			throw null;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00016880 File Offset: 0x00014A80
		[global::Cpp2ILInjected.Token(Token = "0x6000D0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C645B4", Offset = "0x1C645B4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool CompareMethodSigAndName(global::System.Reflection.MethodBase m1, global::System.Reflection.MethodBase m2)
		{
			throw null;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00016883 File Offset: 0x00014A83
		[global::Cpp2ILInjected.Token(Token = "0x6000D0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C646C8", Offset = "0x1C646C8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificField", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Reflection.PropertyInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int GetHierarchyDepth(global::System.Type t)
		{
			throw null;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00016886 File Offset: 0x00014A86
		[global::Cpp2ILInjected.Token(Token = "0x6000D0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64228", Offset = "0x1C64228", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static global::System.Reflection.MethodBase FindMostDerivedNewSlotMeth(global::System.Reflection.MethodBase[] match, int cMatches)
		{
			throw null;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00016889 File Offset: 0x00014A89
		[global::Cpp2ILInjected.Token(Token = "0x6000D0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6233C", Offset = "0x1C6233C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "ReorderArgumentArray", MemberParameters = new object[]
		{
			typeof(ref object[]),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ReorderParams(int[] paramOrder, object[] vars)
		{
			throw null;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0001688C File Offset: 0x00014A8C
		[global::Cpp2ILInjected.Token(Token = "0x6000D0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6204C", Offset = "0x1C6204C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CreateParamOrder(int[] paramOrder, global::System.Reflection.ParameterInfo[] pars, string[] names)
		{
			throw null;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0001688F File Offset: 0x00014A8F
		[global::Cpp2ILInjected.Token(Token = "0x6000D0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C633A4", Offset = "0x1C633A4", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectProperty", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool CanConvertPrimitive(global::System.RuntimeType source, global::System.RuntimeType target)
		{
			throw null;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00016892 File Offset: 0x00014A92
		[global::Cpp2ILInjected.Token(Token = "0x6000D10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C621EC", Offset = "0x1C621EC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToField", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.FieldInfo[]),
			typeof(object),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool CanConvertPrimitiveObjectToType(object source, global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00016895 File Offset: 0x00014A95
		[global::Cpp2ILInjected.Token(Token = "0x6000D11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64754", Offset = "0x1C64754", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool CompareMethodSig(global::System.Reflection.MethodBase m1, global::System.Reflection.MethodBase m2)
		{
			throw null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00016898 File Offset: 0x00014A98
		[global::Cpp2ILInjected.Token(Token = "0x6000D12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64868", Offset = "0x1C64868", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.ParameterInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "TryResolveAgainstGenericMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.SignatureType),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CanChangePrimitive", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase),
			typeof(int[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(object[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public sealed override global::System.Reflection.MethodBase SelectMethod(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.MethodBase[] match, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001689B File Offset: 0x00014A9B
		[global::Cpp2ILInjected.Token(Token = "0x6000D13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64E78", Offset = "0x1C64E78", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool CanChangePrimitive(global::System.Type source, global::System.Type target)
		{
			throw null;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0001689E File Offset: 0x00014A9E
		[global::Cpp2ILInjected.Token(Token = "0x6000D14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64EDC", Offset = "0x1C64EDC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool CanPrimitiveWiden(global::System.Type source, global::System.Type target)
		{
			throw null;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000168A1 File Offset: 0x00014AA1
		[global::Cpp2ILInjected.Token(Token = "0x6000D15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64F9C", Offset = "0x1C64F9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Binder), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultBinder()
		{
			throw null;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000168A4 File Offset: 0x00014AA4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C64FA4", Offset = "0x1C64FA4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static DefaultBinder()
		{
			throw null;
		}

		// Token: 0x04000396 RID: 918
		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		private static global::System.DefaultBinder.Primitives[] _primitiveConversions;

		// Token: 0x0200058C RID: 1420
		[global::Cpp2ILInjected.Token(Token = "0x200014A")]
		internal class BinderState
		{
			// Token: 0x06003FBD RID: 16317 RVA: 0x0001F9F7 File Offset: 0x0001DBF7
			[global::Cpp2ILInjected.Token(Token = "0x6000D17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C622FC", Offset = "0x1C622FC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray)
			{
				throw null;
			}

			// Token: 0x04001808 RID: 6152
			[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int[] m_argsMap;

			// Token: 0x04001809 RID: 6153
			[global::Cpp2ILInjected.Token(Token = "0x40004F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int m_originalSize;

			// Token: 0x0400180A RID: 6154
			[global::Cpp2ILInjected.Token(Token = "0x40004FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal bool m_isParamArray;
		}

		// Token: 0x0200058D RID: 1421
		[global::System.Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200014B")]
		private enum Primitives
		{
			// Token: 0x0400180C RID: 6156
			[global::Cpp2ILInjected.Token(Token = "0x40004FC")]
			Boolean = 8,
			// Token: 0x0400180D RID: 6157
			[global::Cpp2ILInjected.Token(Token = "0x40004FD")]
			Char = 16,
			// Token: 0x0400180E RID: 6158
			[global::Cpp2ILInjected.Token(Token = "0x40004FE")]
			SByte = 32,
			// Token: 0x0400180F RID: 6159
			[global::Cpp2ILInjected.Token(Token = "0x40004FF")]
			Byte = 64,
			// Token: 0x04001810 RID: 6160
			[global::Cpp2ILInjected.Token(Token = "0x4000500")]
			Int16 = 128,
			// Token: 0x04001811 RID: 6161
			[global::Cpp2ILInjected.Token(Token = "0x4000501")]
			UInt16 = 256,
			// Token: 0x04001812 RID: 6162
			[global::Cpp2ILInjected.Token(Token = "0x4000502")]
			Int32 = 512,
			// Token: 0x04001813 RID: 6163
			[global::Cpp2ILInjected.Token(Token = "0x4000503")]
			UInt32 = 1024,
			// Token: 0x04001814 RID: 6164
			[global::Cpp2ILInjected.Token(Token = "0x4000504")]
			Int64 = 2048,
			// Token: 0x04001815 RID: 6165
			[global::Cpp2ILInjected.Token(Token = "0x4000505")]
			UInt64 = 4096,
			// Token: 0x04001816 RID: 6166
			[global::Cpp2ILInjected.Token(Token = "0x4000506")]
			Single = 8192,
			// Token: 0x04001817 RID: 6167
			[global::Cpp2ILInjected.Token(Token = "0x4000507")]
			Double = 16384,
			// Token: 0x04001818 RID: 6168
			[global::Cpp2ILInjected.Token(Token = "0x4000508")]
			Decimal = 32768,
			// Token: 0x04001819 RID: 6169
			[global::Cpp2ILInjected.Token(Token = "0x4000509")]
			DateTime = 65536,
			// Token: 0x0400181A RID: 6170
			[global::Cpp2ILInjected.Token(Token = "0x400050A")]
			String = 262144
		}

		// Token: 0x0200058E RID: 1422
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200014C")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06003FBE RID: 16318 RVA: 0x0001F9FA File Offset: 0x0001DBFA
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000D18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C65038", Offset = "0x1C65038", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06003FBF RID: 16319 RVA: 0x0001F9FD File Offset: 0x0001DBFD
			[global::Cpp2ILInjected.Token(Token = "0x6000D19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C65094", Offset = "0x1C65094", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06003FC0 RID: 16320 RVA: 0x0001FA00 File Offset: 0x0001DC00
			[global::Cpp2ILInjected.Token(Token = "0x6000D1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6509C", Offset = "0x1C6509C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <SelectProperty>b__2_0(global::System.Type t)
			{
				throw null;
			}

			// Token: 0x0400181B RID: 6171
			[global::Cpp2ILInjected.Token(Token = "0x400050B")]
			public static readonly global::System.DefaultBinder.<>c <>9;

			// Token: 0x0400181C RID: 6172
			[global::Cpp2ILInjected.Token(Token = "0x400050C")]
			public static global::System.Predicate<global::System.Type> <>9__2_0;
		}
	}
}
