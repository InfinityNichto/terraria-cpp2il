using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Resources;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200043C RID: 1084
	[global::Cpp2ILInjected.Token(Token = "0x20004FB")]
	public static class CustomAttributeExtensions
	{
		// Token: 0x06002259 RID: 8793 RVA: 0x0001A4BC File Offset: 0x000186BC
		[global::Cpp2ILInjected.Token(Token = "0x60024F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87FA8", Offset = "0x1B87FA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Assembly) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Attribute))]
		public static global::System.Attribute GetCustomAttribute(this Assembly element, global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0001A4BF File Offset: 0x000186BF
		[global::Cpp2ILInjected.Token(Token = "0x60024F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x15798D4", Offset = "0x15798D4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguageAttribute", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(ref string),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T GetCustomAttribute<T>(this Assembly element) where T : global::System.Attribute
		{
			throw null;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0001A4C2 File Offset: 0x000186C2
		[global::Cpp2ILInjected.Token(Token = "0x60024F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87FB0", Offset = "0x1B87FB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Attribute[]))]
		public static global::System.Collections.Generic.IEnumerable<global::System.Attribute> GetCustomAttributes(this MemberInfo element, global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0001A4C5 File Offset: 0x000186C5
		[global::Cpp2ILInjected.Token(Token = "0x60024F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1579998", Offset = "0x1579998", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "ConvertAsyncStateMachineMethod", MemberParameters = new object[]
		{
			typeof(ref MethodBase),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<global::System.Attribute>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : global::System.Attribute
		{
			throw null;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x0001A4C8 File Offset: 0x000186C8
		[global::Cpp2ILInjected.Token(Token = "0x60024F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87FB8", Offset = "0x1B87FB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(MethodBase),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		public static bool IsDefined(this MemberInfo element, global::System.Type attributeType)
		{
			throw null;
		}
	}
}
