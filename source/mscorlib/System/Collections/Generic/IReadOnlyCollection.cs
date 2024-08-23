using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200051C RID: 1308
	[global::Cpp2ILInjected.Token(Token = "0x2000634")]
	public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002C27 RID: 11303
		[global::Cpp2ILInjected.Token(Token = "0x170007D2")]
		int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003098")]
			get;
		}
	}
}
