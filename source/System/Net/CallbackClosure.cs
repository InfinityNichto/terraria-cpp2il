using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000121")]
	internal class CallbackClosure
	{
		[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0270", Offset = "0x1EE0270", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CallbackClosure(ExecutionContext context, AsyncCallback callback)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private AsyncCallback _savedCallback;

		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ExecutionContext _savedContext;
	}
}
