using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A1 RID: 161
	[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
	[global::System.Serializable]
	public class InvalidCastException : global::System.SystemException
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x00015A2E File Offset: 0x00013C2E
		[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C352F4", Offset = "0x1C352F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Nullable<>), Member = "UnboxExact", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Nullable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InvalidCastException()
		{
			throw null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00015A31 File Offset: 0x00013C31
		[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32A18", Offset = "0x1C32A18", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 71)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidCastException(string message)
		{
			throw null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00015A34 File Offset: 0x00013C34
		[global::Cpp2ILInjected.Token(Token = "0x60007D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35350", Offset = "0x1C35350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected InvalidCastException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
