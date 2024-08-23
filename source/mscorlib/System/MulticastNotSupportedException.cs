using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000AE RID: 174
	[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
	[global::System.Serializable]
	public sealed class MulticastNotSupportedException : global::System.SystemException
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x00015B45 File Offset: 0x00013D45
		[global::Cpp2ILInjected.Token(Token = "0x600083F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C375A4", Offset = "0x1C375A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MulticastNotSupportedException()
		{
			throw null;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00015B48 File Offset: 0x00013D48
		[global::Cpp2ILInjected.Token(Token = "0x6000840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37600", Offset = "0x1C37600", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CombineImpl", MemberParameters = new object[] { typeof(global::System.Delegate) }, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MulticastNotSupportedException(string message)
		{
			throw null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00015B4B File Offset: 0x00013D4B
		[global::Cpp2ILInjected.Token(Token = "0x6000841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37624", Offset = "0x1C37624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal MulticastNotSupportedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
