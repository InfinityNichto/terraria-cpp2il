using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200016A RID: 362
	[global::Cpp2ILInjected.Token(Token = "0x20001BC")]
	[global::System.Serializable]
	public class LockRecursionException : global::System.Exception
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x000170F3 File Offset: 0x000152F3
		[global::Cpp2ILInjected.Token(Token = "0x60010B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93DF8", Offset = "0x1C93DF8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LockRecursionException()
		{
			throw null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000170F6 File Offset: 0x000152F6
		[global::Cpp2ILInjected.Token(Token = "0x60010B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93E50", Offset = "0x1C93E50", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LockRecursionException(string message)
		{
			throw null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000170F9 File Offset: 0x000152F9
		[global::Cpp2ILInjected.Token(Token = "0x60010B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93EB8", Offset = "0x1C93EB8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected LockRecursionException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
