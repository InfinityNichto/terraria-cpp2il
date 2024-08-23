using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000519 RID: 1305
	[global::Cpp2ILInjected.Token(Token = "0x2000631")]
	public interface IEnumerator<out T> : global::System.IDisposable, IEnumerator
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002C1F RID: 11295
		[global::Cpp2ILInjected.Token(Token = "0x170007D0")]
		T Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003090")]
			get;
		}
	}
}
