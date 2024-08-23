using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x020003FC RID: 1020
	[global::Cpp2ILInjected.Token(Token = "0x20004BA")]
	[global::System.Serializable]
	public sealed class AmbiguousMatchException : global::System.SystemException
	{
		// Token: 0x060020C3 RID: 8387 RVA: 0x0001A0D5 File Offset: 0x000182D5
		[global::Cpp2ILInjected.Token(Token = "0x600235B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80560", Offset = "0x1B80560", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AmbiguousMatchException()
		{
			throw null;
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0001A0D8 File Offset: 0x000182D8
		[global::Cpp2ILInjected.Token(Token = "0x600235C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B805BC", Offset = "0x1B805BC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(MethodBase[]),
			typeof(ref object[]),
			typeof(ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToField", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(FieldInfo[]),
			typeof(object),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectProperty", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new object[]
		{
			typeof(PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new object[]
		{
			typeof(MethodBase[]),
			typeof(int)
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(MethodBase[]),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(CallingConventions),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public AmbiguousMatchException(string message)
		{
			throw null;
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0001A0DB File Offset: 0x000182DB
		[global::Cpp2ILInjected.Token(Token = "0x600235D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B805E0", Offset = "0x1B805E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal AmbiguousMatchException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
