using System;
using Cpp2ILInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003C3 RID: 963
	[global::Cpp2ILInjected.Token(Token = "0x2000473")]
	public interface IAsyncStateMachine
	{
		// Token: 0x06001FC1 RID: 8129
		[global::Cpp2ILInjected.Token(Token = "0x6002218")]
		void MoveNext();

		// Token: 0x06001FC2 RID: 8130
		[global::Cpp2ILInjected.Token(Token = "0x6002219")]
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
