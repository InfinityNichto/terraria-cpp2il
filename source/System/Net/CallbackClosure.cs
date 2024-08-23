using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C1 RID: 193
	[global::Cpp2ILInjected.Token(Token = "0x2000121")]
	internal class CallbackClosure
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x00003FE6 File Offset: 0x000021E6
		[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0270", Offset = "0x1EE0270", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CallbackClosure(ExecutionContext context, AsyncCallback callback)
		{
			throw null;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00003FE9 File Offset: 0x000021E9
		[global::Cpp2ILInjected.Token(Token = "0x60006E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0254", Offset = "0x1EE0254", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		internal bool IsCompatible(AsyncCallback callback)
		{
			throw null;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00003FEC File Offset: 0x000021EC
		[global::Cpp2ILInjected.Token(Token = "0x1700017A")]
		internal AsyncCallback AsyncCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE09C4", Offset = "0x1EE09C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00003FEF File Offset: 0x000021EF
		[global::Cpp2ILInjected.Token(Token = "0x1700017B")]
		internal ExecutionContext Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE09CC", Offset = "0x1EE09CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040003D7 RID: 983
		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AsyncCallback _savedCallback;

		// Token: 0x040003D8 RID: 984
		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ExecutionContext _savedContext;
	}
}
