using System;
using Cpp2ILInjected;

namespace InControl
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public interface BindingSourceListener
	{
		// Token: 0x06000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		void Reset();

		// Token: 0x06000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		BindingSource Listen(BindingListenOptions listenOptions, InputDevice device);
	}
}
