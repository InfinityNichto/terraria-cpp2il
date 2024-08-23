using System;
using Cpp2ILInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000518 RID: 1304
	[global::Cpp2ILInjected.Token(Token = "0x2000630")]
	public interface IEnumerable<out T> : IEnumerable
	{
		// Token: 0x06002C1E RID: 11294
		[global::Cpp2ILInjected.Token(Token = "0x600308F")]
		IEnumerator<T> GetEnumerator();
	}
}
