using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020001D6 RID: 470
	[global::Cpp2ILInjected.Token(Token = "0x200025A")]
	public interface IValueTaskSource
	{
		// Token: 0x060012A4 RID: 4772
		[global::Cpp2ILInjected.Token(Token = "0x600145D")]
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060012A5 RID: 4773
		[global::Cpp2ILInjected.Token(Token = "0x600145E")]
		void OnCompleted(global::System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060012A6 RID: 4774
		[global::Cpp2ILInjected.Token(Token = "0x600145F")]
		void GetResult(short token);
	}
}
