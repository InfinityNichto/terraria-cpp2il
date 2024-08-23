using System;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000040 RID: 64
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x000028EB File Offset: 0x00000AEB
		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595620", Offset = "0x1595620", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000028EE File Offset: 0x00000AEE
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595790", Offset = "0x1595790", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x060002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x060002C7 RID: 711
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x060002C8 RID: 712
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x060002C9 RID: 713
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002CA RID: 714
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CB RID: 715
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x060002CC RID: 716
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		// Token: 0x060002CD RID: 717 RVA: 0x000028F1 File Offset: 0x00000AF1
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0440", Offset = "0x1CD0440", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ReflectionDelegateFactory()
		{
			throw null;
		}
	}
}
