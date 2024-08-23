﻿using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000175 RID: 373
	[global::Cpp2ILInjected.Token(Token = "0x20001C7")]
	[global::System.Serializable]
	public class WaitHandleCannotBeOpenedException : global::System.ApplicationException
	{
		// Token: 0x06000F97 RID: 3991 RVA: 0x0001711A File Offset: 0x0001531A
		[global::Cpp2ILInjected.Token(Token = "0x60010C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9446C", Offset = "0x1C9446C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public WaitHandleCannotBeOpenedException()
		{
			throw null;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0001711D File Offset: 0x0001531D
		[global::Cpp2ILInjected.Token(Token = "0x60010CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C944C8", Offset = "0x1C944C8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public WaitHandleCannotBeOpenedException(string message)
		{
			throw null;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00017120 File Offset: 0x00015320
		[global::Cpp2ILInjected.Token(Token = "0x60010CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C944EC", Offset = "0x1C944EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected WaitHandleCannotBeOpenedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}