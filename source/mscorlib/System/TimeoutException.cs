using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000D8 RID: 216
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	[global::System.Serializable]
	public class TimeoutException : global::System.SystemException
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00016001 File Offset: 0x00014201
		[global::Cpp2ILInjected.Token(Token = "0x60009DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C8F4", Offset = "0x1C4C8F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TimeoutException()
		{
			throw null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00016004 File Offset: 0x00014204
		[global::Cpp2ILInjected.Token(Token = "0x60009DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C94C", Offset = "0x1C4C94C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public TimeoutException(string message)
		{
			throw null;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00016007 File Offset: 0x00014207
		[global::Cpp2ILInjected.Token(Token = "0x60009DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C96C", Offset = "0x1C4C96C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected TimeoutException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
