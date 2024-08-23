using System;
using Cpp2ILInjected;

namespace System.Threading.Tasks
{
	// Token: 0x020001C0 RID: 448
	[global::Cpp2ILInjected.Token(Token = "0x200023E")]
	internal interface ITaskCompletionAction
	{
		// Token: 0x06001248 RID: 4680
		[global::Cpp2ILInjected.Token(Token = "0x60013F2")]
		void Invoke(Task completingTask);

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06001249 RID: 4681
		[global::Cpp2ILInjected.Token(Token = "0x170001F3")]
		bool InvokeMayRunArbitraryCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60013F3")]
			get;
		}
	}
}
