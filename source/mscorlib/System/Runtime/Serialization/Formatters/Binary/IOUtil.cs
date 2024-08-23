using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000358 RID: 856
	[global::Cpp2ILInjected.Token(Token = "0x2000400")]
	internal static class IOUtil
	{
		// Token: 0x06001D93 RID: 7571 RVA: 0x000197C0 File Offset: 0x000179C0
		[global::Cpp2ILInjected.Token(Token = "0x6001FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C4F4", Offset = "0x1B5C4F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool FlagTest(MessageEnum flag, MessageEnum target)
		{
			throw null;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000197C3 File Offset: 0x000179C3
		[global::Cpp2ILInjected.Token(Token = "0x6001FD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C500", Offset = "0x1B5C500", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void WriteStringWithCode(string value, __BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000197C6 File Offset: 0x000179C6
		[global::Cpp2ILInjected.Token(Token = "0x6001FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C560", Offset = "0x1B5C560", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void WriteWithCode(global::System.Type type, object value, __BinaryWriter sout)
		{
			throw null;
		}
	}
}
