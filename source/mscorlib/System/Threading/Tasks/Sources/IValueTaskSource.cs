using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks.Sources
{
	[global::Cpp2ILInjected.Token(Token = "0x200025A")]
	public interface IValueTaskSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x600145D")]
		ValueTaskSourceStatus GetStatus(short token);

		[global::Cpp2ILInjected.Token(Token = "0x600145E")]
		void OnCompleted(global::System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		[global::Cpp2ILInjected.Token(Token = "0x600145F")]
		void GetResult(short token);
	}
}
