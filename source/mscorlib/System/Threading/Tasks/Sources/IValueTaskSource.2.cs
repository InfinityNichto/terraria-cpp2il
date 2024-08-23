using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020001D7 RID: 471
	[global::Cpp2ILInjected.Token(Token = "0x200025B")]
	public interface IValueTaskSource<out TResult>
	{
		// Token: 0x060012A7 RID: 4775
		[global::Cpp2ILInjected.Token(Token = "0x6001460")]
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060012A8 RID: 4776
		[global::Cpp2ILInjected.Token(Token = "0x6001461")]
		void OnCompleted(global::System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060012A9 RID: 4777
		[global::Cpp2ILInjected.Token(Token = "0x6001462")]
		TResult GetResult(short token);
	}
}
