using System;
using System.Threading;
using Cpp2ILInjected;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
	public interface IAsyncResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000753")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		global::System.Threading.WaitHandle AsyncWaitHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000754")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		object AsyncState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000755")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		bool CompletedSynchronously
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000756")]
			get;
		}
	}
}
