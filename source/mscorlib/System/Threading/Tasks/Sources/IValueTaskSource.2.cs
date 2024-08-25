using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks.Sources
{
	[global::Cpp2ILInjected.Token(Token = "0x200025B")]
	public interface IValueTaskSource<out TResult>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001460")]
		ValueTaskSourceStatus GetStatus(short token);

		[global::Cpp2ILInjected.Token(Token = "0x6001461")]
		void OnCompleted(global::System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		[global::Cpp2ILInjected.Token(Token = "0x6001462")]
		TResult GetResult(short token);
	}
}
